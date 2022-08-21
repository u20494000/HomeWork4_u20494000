using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeWork4_u20494000.Models
{
    public class Parent : User
    {
        private string mEmail;
        private string mAddress;

        public Parent(string _FirstName, string _LastName, string _PhoneNumber, int _Age, string _Address, string _Email) : base(_FirstName, _LastName, _PhoneNumber, _Age)

        {
            mEmail = _Email;

            mAddress = _Address;


        }

        public string Email { get { return mEmail; } set { mEmail = value; } }

        public string Address { get { return mAddress; } set { mAddress = value; } }

    }
}