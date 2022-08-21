using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeWork4_u20494000.Models
{
    public abstract class User
    {
        private string mFirstName;
        private string mLastName;
        private string mPhoneNumber;
        private int mAge;


        //Constructor
        public User(string _FirstName, string _LastName, string _PhoneNumber, int _Age)

        {
            mFirstName = _FirstName;

            mLastName = _LastName;

            mPhoneNumber = _PhoneNumber;

            mAge = _Age;
        }


        //Properties

        public string FirstName { get { return mFirstName; } set { mFirstName = value; } }

        public string LastName { get { return mLastName; } set { mLastName = value; } }

        public string PhoneNumber { get { return mPhoneNumber; } set { mPhoneNumber = value; } }

        public int Age { get { return mAge; } set { mAge = value; } }


    }
}