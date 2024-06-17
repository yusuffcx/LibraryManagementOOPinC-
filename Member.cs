using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Member : Person
    {
        private string memberShipID;

        public string MemberShipID
        {
            get
            {
                return memberShipID;
            }

            set
            {
                memberShipID = value;
            }
        }

        public Member(string firstName , string lastName,string memberShipID)
        {
            this.Firstname = firstName;
            this.LastName = lastName;
            this.memberShipID = memberShipID;
        }

        

    }
}
