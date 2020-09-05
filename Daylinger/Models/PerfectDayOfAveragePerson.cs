using Daylinger.Models;
using System;
using System.Collections.Generic;

namespace Daylinger.Models
{
    public class PerfectDayOfAveragePerson : DayTemplate
    {
        public PerfectDayOfAveragePerson()
        {
            hours = new Period[24];
            SetRatingSchedule();
            SetBaseEvents();
        }

        private void SetBaseEvents()
        {
            BaseEvents = new List<BaseEvent>
            {
                new BaseEvent
                {
                    Id = Guid.NewGuid(),
                    Description = "Breakfast",
                },

                new BaseEvent
                {
                    Id = Guid.NewGuid(),
                    Description = "Lunch",
                },

                new BaseEvent
                {
                    Id = Guid.NewGuid(),
                    Description = "Dinner",
                },
            };
        }

        private void SetRatingSchedule()
        {
            hours[0] = new Period
            {
                activitiesType = new List<EventType>
                {
                new Sleep { EventRating = 5 },
                new Food { EventRating = 0},
                new Routine { EventRating = 1},
                new Chill {EventRating = 1 },
                new Sport { EventRating = 0},
                new Work { EventRating = 0 }
                },

                Start = new DateTime().AddHours(0),
                Finish = new DateTime().AddHours(1)
            };

            hours[1] = new Period
            {
                activitiesType = new List<EventType>
                {
                    new Work { EventRating = 0 },
                    new Sleep { EventRating = 5 },
                    new Food { EventRating = 0 },
                    new Routine { EventRating = 1 },
                    new Chill { EventRating = 1 },
                    new Sport { EventRating = 0 }
                },
                Start = new DateTime().AddHours(1),
                Finish = new DateTime().AddHours(2)
            };

            hours[2] = new Period
            {
                activitiesType = new List<EventType>
                {
                    new Work { EventRating = 0 },
                    new Sleep { EventRating = 5 },
                    new Food { EventRating = 0 },
                    new Routine { EventRating = 0 },
                    new Chill { EventRating = 0 },
                    new Sport { EventRating = 0 }
                },
                Start = new DateTime().AddHours(2),
                Finish = new DateTime().AddHours(3)
            };

            hours[3] = new Period
            {
                activitiesType = new List<EventType>
                {
                    new Work { EventRating = 0 },
                    new Sleep { EventRating = 5 },
                    new Food { EventRating = 0 },
                    new Routine { EventRating = 0 },
                    new Chill { EventRating = 0 },
                    new Sport { EventRating = 0 }
                },
                Start = new DateTime().AddHours(3),
                Finish = new DateTime().AddHours(4)
            };

            hours[4] = new Period
            {
                activitiesType = new List<EventType>
                {
                    new Work { EventRating = 0 },
                    new Sleep { EventRating = 5 },
                    new Food { EventRating = 0 },
                    new Routine { EventRating = 0 },
                    new Chill { EventRating = 0 },
                    new Sport { EventRating = 0 }
                },
                Start = new DateTime().AddHours(4),
                Finish = new DateTime().AddHours(5)
            };

            hours[5] = new Period
            {
                activitiesType = new List<EventType>
                {
                    new Work { EventRating = 0 },
                    new Sleep { EventRating = 5 },
                    new Food { EventRating = 0 },
                    new Routine { EventRating = 0 },
                    new Chill { EventRating = 0 },
                    new Sport { EventRating = 0 }
                },
                Start = new DateTime().AddHours(5),
                Finish = new DateTime().AddHours(6)
            };


            hours[6] = new Period
            {
                activitiesType = new List<EventType>
                {
                    new Work { EventRating = 1 },
                    new Sleep { EventRating = 5 },
                    new Food { EventRating = 2 },
                    new Routine { EventRating = 2 },
                    new Chill { EventRating = 0 },
                    new Sport { EventRating = 1 }
                },

                Start = new DateTime().AddHours(6),
                Finish = new DateTime().AddHours(7)
            };

            hours[7] = new Period
            {
                activitiesType = new List<EventType>
                {
                    new Work { EventRating = 1 },
                    new Sleep { EventRating = 3 },
                    new Food { EventRating = 5 },
                    new Routine { EventRating = 5 },
                    new Chill { EventRating = 0 },
                    new Sport { EventRating = 4 }
                },

                Start = new DateTime().AddHours(7),
                Finish = new DateTime().AddHours(8)
            };

            hours[8] = new Period
            {
                activitiesType = new List<EventType>
                {
                    new Work { EventRating = 3 },
                    new Sleep { EventRating = 2 },
                    new Food { EventRating = 5 },
                    new Routine { EventRating = 5 },
                    new Chill { EventRating = 0 },
                    new Sport { EventRating = 4 }
                },

                Start = new DateTime().AddHours(8),
                Finish = new DateTime().AddHours(9)
            };

            hours[9] = new Period
            {
                activitiesType = new List<EventType>
                {
                    new Work { EventRating = 5 },
                    new Sleep { EventRating = 0 },
                    new Food { EventRating = 2 },
                    new Routine { EventRating = 2 },
                    new Chill { EventRating = 0 },
                    new Sport { EventRating = 1 }
                },

                Start = new DateTime().AddHours(9),
                Finish = new DateTime().AddHours(10)
            };

            hours[10] = new Period
            {
                activitiesType = new List<EventType>
                {
                    new Work { EventRating = 5 },
                    new Sleep { EventRating = 0 },
                    new Food { EventRating = 2 },
                    new Routine { EventRating = 2 },
                    new Chill { EventRating = 0 },
                    new Sport { EventRating = 1 }
                },

                Start = new DateTime().AddHours(10),
                Finish = new DateTime().AddHours(11)
            };


            hours[11] = new Period
            {
                activitiesType = new List<EventType>
                {
                    new Work { EventRating = 4 },
                    new Sleep { EventRating = 0 },
                    new Food { EventRating = 2 },
                    new Routine { EventRating = 2 },
                    new Chill { EventRating = 1 },
                    new Sport { EventRating = 1 }
                },

                Start = new DateTime().AddHours(11),
                Finish = new DateTime().AddHours(12)
            };

            hours[12] = new Period
            {
                activitiesType = new List<EventType>
                {
                    new Work { EventRating = 3 },
                    new Sleep { EventRating = 0 },
                    new Food { EventRating = 5 },
                    new Routine { EventRating = 2 },
                    new Chill { EventRating = 3 },
                    new Sport { EventRating = 1 }
                },

                Start = new DateTime().AddHours(12),
                Finish = new DateTime().AddHours(13)
            };

            hours[13] = new Period
            {
                activitiesType = new List<EventType>
                {
                    new Work { EventRating = 2 },
                    new Sleep { EventRating = 0 },
                    new Food { EventRating = 5 },
                    new Routine { EventRating = 3 },
                    new Chill { EventRating = 4 },
                    new Sport { EventRating = 1 }
                },

                Start = new DateTime().AddHours(13),
                Finish = new DateTime().AddHours(14)
            };

            hours[14] = new Period
            {
                activitiesType = new List<EventType>
                {
                    new Work { EventRating = 2 },
                    new Sleep { EventRating = 0 },
                    new Food { EventRating = 1 },
                    new Routine { EventRating = 3 },
                    new Chill { EventRating = 4 },
                    new Sport { EventRating = 0 }
                },

                Start = new DateTime().AddHours(14),
                Finish = new DateTime().AddHours(15)
            };

            hours[15] = new Period
            {
                activitiesType = new List<EventType>
                {
                    new Work { EventRating = 2 },
                    new Sleep { EventRating = 0 },
                    new Food { EventRating = 0 },
                    new Routine { EventRating = 3 },
                    new Chill { EventRating = 4 },
                    new Sport { EventRating = 0 }
                },

                Start = new DateTime().AddHours(15),
                Finish = new DateTime().AddHours(16)
            };

            hours[16] = new Period
            {
                activitiesType = new List<EventType>
                {
                    new Work { EventRating = 5 },
                    new Sleep { EventRating = 0 },
                    new Food { EventRating = 1 },
                    new Routine { EventRating = 3 },
                    new Chill { EventRating = 1 },
                    new Sport { EventRating = 0 }
                },

                Start = new DateTime().AddHours(16),
                Finish = new DateTime().AddHours(17)
            };

            hours[17] = new Period
            {
                activitiesType = new List<EventType>
                {
                    new Work { EventRating = 5 },
                    new Sleep { EventRating = 0 },
                    new Food { EventRating = 1 },
                    new Routine { EventRating = 3 },
                    new Chill { EventRating = 1 },
                    new Sport { EventRating = 0 }
                },

                Start = new DateTime().AddHours(17),
                Finish = new DateTime().AddHours(18)
            };

            hours[18] = new Period
            {
                activitiesType = new List<EventType>
                {
                    new Work { EventRating = 3 },
                    new Sleep { EventRating = 0 },
                    new Food { EventRating = 5 },
                    new Routine { EventRating = 3 },
                    new Chill { EventRating = 3 },
                    new Sport { EventRating = 0 }
                },

                Start = new DateTime().AddHours(18),
                Finish = new DateTime().AddHours(19)
            };

            hours[19] = new Period
            {
                activitiesType = new List<EventType>
                {
                    new Work { EventRating = 2 },
                    new Sleep { EventRating = 0 },
                    new Food { EventRating = 5 },
                    new Routine { EventRating = 3 },
                    new Chill { EventRating = 3 },
                    new Sport { EventRating = 2 }
                },

                Start = new DateTime().AddHours(19),
                Finish = new DateTime().AddHours(20)
            };

            hours[20] = new Period
            {
                activitiesType = new List<EventType>
                {
                    new Work { EventRating = 1 },
                    new Sleep { EventRating = 0 },
                    new Food { EventRating = 2 },
                    new Routine { EventRating = 4 },
                    new Chill { EventRating = 4 },
                    new Sport { EventRating = 5 }
                },

                Start = new DateTime().AddHours(20),
                Finish = new DateTime().AddHours(21)
            };

            hours[21] = new Period
            {
                activitiesType = new List<EventType>
                {
                    new Work { EventRating = 0 },
                    new Sleep { EventRating = 2 },
                    new Food { EventRating = 0 },
                    new Routine { EventRating = 4 },
                    new Chill { EventRating = 4 },
                    new Sport { EventRating = 3 }
                },

                Start = new DateTime().AddHours(21),
                Finish = new DateTime().AddHours(22)
            };

            hours[22] = new Period
            {
                activitiesType = new List<EventType>
                {
                    new Work { EventRating = 0 },
                    new Sleep { EventRating = 4 },
                    new Food { EventRating = 0 },
                    new Routine { EventRating = 4 },
                    new Chill { EventRating = 4},
                    new Sport { EventRating = 2 }
                },

                Start = new DateTime().AddHours(22),
                Finish = new DateTime().AddHours(23)
            };

            hours[23] = new Period
            {
                activitiesType = new List<EventType>
                {
                    new Work { EventRating = 0 },
                    new Sleep { EventRating = 5 },
                    new Food { EventRating = 0 },
                    new Routine { EventRating = 1 },
                    new Chill { EventRating = 3 },
                    new Sport { EventRating = 0 }
                },

                Start = new DateTime().AddHours(23),
                Finish = new DateTime().AddHours(24)
            };
        }
    }
}
