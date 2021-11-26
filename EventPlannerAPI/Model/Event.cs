using System;
namespace EventPlannerAPI.Model
{
    public class Event
    {

        public String Name { get; set; }

        public String Location { get; set; }

        public int Capacity { get; set; }

        public int Budget { get; set; }

        public Event(string name, string location, int capacity, int budget)
        {
            Name = name;
            Location = location;
            Capacity = capacity;
            Budget = budget;
        }

    }
}
