using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB11_03_01_2023
{
    public class Person : IComparable<Person>
    {
        private DateTime _birthday;
        private string _surname;

        public Person(string name, string surname, DateTime birthday)
        {
            Name = name;
            Surname = surname;
            Birthday = birthday;
        }

        public String Name
        { get; set; }

        public String Surname
        {
            get
            { return _surname; }
            set
            {
                if (value != String.Empty) _surname = value;
                else throw new ArgumentException($"{this.GetType()}, Surname cannot be empty");
            }
        }

        public DateTime Birthday
        {
            get
            { return _birthday; }
            set
            {
                if (value <= DateTime.Today) _birthday = value;
                else throw new ArgumentOutOfRangeException($"{this.GetType()}, Date out of valid birthday range");
            }
        }

        public override string ToString()
        {
            return $"{Name} {Surname} {Birthday}";
        }

        public int CompareTo(Person other)
        {
            if (other == null)
            {
                return 1;
            }
            int surameComparison = Surname.CompareTo(other.Surname);
            if (surameComparison != 0)
            {
                return surameComparison;
            }
            int nameComparison = Name.CompareTo(other.Name);
            if (nameComparison != 0)
            {
                return nameComparison;
            }
            return Birthday.CompareTo(other.Birthday);
        }
    }
}
