using System;
using System.Collections.Generic;

namespace Daylinger.Models
{
    public interface IBaseEvent
    {
        public List<BaseEvent> BaseEvents { get; set; }
    }
}
