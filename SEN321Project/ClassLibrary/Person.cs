using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Person
    {

        protected string name;

        public string Name
        {
            set { this.name = value; }
            get { return this.name; }
        }

        protected string surname;

        public string Surname
        {
            get { return this.surname; }
            set { this.surname = value; }
        }      

        protected DateTime dateOfBirth;

        public DateTime DateOfBirth
        {
            get { return this.dateOfBirth; }
            set { this.dateOfBirth = value; }
        }

        public Person(string name, string surname, DateTime dateOfBirth)
        {
            this.name = name;
            this.surname = surname;
            this.dateOfBirth = dateOfBirth;
        }

        public Person()
        {

        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return string.Format(" Name = {0} \n Surname = {1} \n Date of Birth = {2} \n", this.name, this.surname, this.dateOfBirth);
        }
    }
}
