using System;
namespace EventPlannerAPI.Model
{
    public class Person
    {

        public String FirstName { get; set; }

        public String LastName { get; set; }

        public String Address { get; set; }

        public int Age { get; set; }

        public Person(String firstName, String lastName, String address, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            Age = age;
        }
    }
}
