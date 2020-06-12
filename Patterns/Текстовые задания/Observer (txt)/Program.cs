using System;
using System.Collections.Generic;

namespace Observer
{
    public interface ITrafficPoliceDepartment
    {
        void Update(PoliceNotificationSystem policeNotificationSystem, string message);
    }

    public class PoliceNotificationSystem
    {
        public string Name { get; private set; }
        public List<ITrafficPoliceDepartment> Departments { get; private set; }

        public PoliceNotificationSystem(string name) 
        {
            Name = name;
            Departments = new List<ITrafficPoliceDepartment>();
        }

        public void AddDepartment(ITrafficPoliceDepartment department) 
        {
            Departments.Add(department);
        }

        public void RemoveDepartment(ITrafficPoliceDepartment department)
        {
            Departments.Remove(department);
        }

        public void Notify(string message) 
        {
            foreach (var department in Departments) 
            {
                department.Update(this, message);
            }
        }
    }

    public class TrafficPoliceDepartment : ITrafficPoliceDepartment
    {
        public string Name { get; private set; }
        
        public TrafficPoliceDepartment(string name) 
        { 
            Name = name; 
        }

        public void Update(PoliceNotificationSystem policeNotificationSystem, string message)
        {
            Console.WriteLine($"{policeNotificationSystem.Name} notifies {Name}\nMessage : {message}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            PoliceNotificationSystem notifierSystem = new PoliceNotificationSystem("Main Traffic Police Department");

            TrafficPoliceDepartment dep1 = new TrafficPoliceDepartment("Traffic Police Department #1");
            notifierSystem.AddDepartment(dep1);
            
            TrafficPoliceDepartment dep2 = new TrafficPoliceDepartment("Traffic Police Department #2");
            notifierSystem.AddDepartment(dep2);

            TrafficPoliceDepartment dep3 = new TrafficPoliceDepartment("Traffic Police Department #3");
            notifierSystem.AddDepartment(dep3);

            TrafficPoliceDepartment dep4 = new TrafficPoliceDepartment("Traffic Police Department #4");
            notifierSystem.AddDepartment(dep4);

            notifierSystem.Notify("Organize system for checking the temperature of citizens at all posts of the traffic police");
        }
    }
}
