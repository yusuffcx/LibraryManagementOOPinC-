using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Staff : Person
    {
        private string position;
        public Staff(string firstName , string lastName, string position)
        {
            this.Firstname = firstName;
            this.LastName = lastName;
            this.Position = position;
        }

        public string Position
        {
            get
            {
                return this.position;
            }

            set
            {
               position = value;
            }
        }
    }

}
