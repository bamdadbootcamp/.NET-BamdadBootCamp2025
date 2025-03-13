using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session08.Folder1.Folder2.Folder3.Folder
{
    public class Person // Instance Member Class ( PascalCase )
    {
        public Person()  // Parameter Less Constructor
        {
            CreatedOn = DateTime.Now;
        }
        public Person(string firstName, string lastName) : this()
        {
            _firstName = firstName;
            _lastName = lastName;
        }
        public Person(string firstName, string lastName, DateOnly birthdate) : this(firstName, lastName)
        {
            _birthdate = birthdate;
        }




        public DateTime CreatedOn { get; set; }


        private string _firstName;    // FIELD  (  _camelCase )
        public string FirstName     // PROPERTY ( PascalCase )  | Complete Property
        {
            get { return _firstName; }
            //set { _firstName = value; }
        }


        public string Address { get; set; }     // Small Property


        private string _lastName;
        public string LastName
        {
            get { return _lastName; }
            //set { _lastName = value; }
        }


        private DateOnly _birthdate;
        public DateOnly Birthdate
        {
            get { return _birthdate; }
            set { _birthdate = value; }
        }


        public string FullName
        {
            get { return $"{_firstName} {_lastName}"; }
        }

        public byte Age
        {
            get
            {
                int age = DateOnly.FromDateTime(DateTime.Now).Year - _birthdate.Year;
                return (byte)age;
            }
        }


        public byte GetAge()   // Method
        {
            int age = DateOnly.FromDateTime(DateTime.Now).Year - _birthdate.Year;
            return (byte)age;
        }
       

        public void UpdateFirstName(string newName)
        {
            if (newName != "David")
            {
                _firstName = newName;
            }
        }

    }


}
