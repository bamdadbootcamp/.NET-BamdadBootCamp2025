using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session05
{
    // struct 
    // public struct <Name>        NAME : PascalCase
    public struct Person
    {
        public string firstName;
        public string lastName;
        public string nationalId;
        public byte age;
    }
    
    internal class Helper
    {
        //public static void PrintPerson(string firstName,
        //    string lastName,
        //    string nationalId,
        //    byte age)
        //{
        //    Console.WriteLine($"First Name: {firstName}");
        //    Console.WriteLine($"Last Name: {lastName}");
        //    Console.WriteLine($"National Id: {nationalId}");
        //    Console.WriteLine($"Age: {age}");
        //}


        public static void PrintPerson(Person person)
        {
            Console.WriteLine($"First Name: {person.firstName}");
            Console.WriteLine($"Last Name: {person.lastName}");
            Console.WriteLine($"National Id: {person.nationalId}");
            Console.WriteLine($"Age: {person.age}");
        }


    }
}
