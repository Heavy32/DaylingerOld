using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace Daylinger.Controllers
{
    public static class TempDataExtensions
    {
        public static void Put<T>(this ITempDataDictionary tempData, string key, T value)
        {
            tempData[key] = JsonConvert.SerializeObject(value, new JsonSerializerSettings()
            {
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
            });
        }

        public static T Get<T>(this ITempDataDictionary tempData, string key)
        {
            object o;
            tempData.TryGetValue(key, out o);
            return (o == default) ? default : JsonConvert.DeserializeObject<T>((string)o);
        }
    }
}
