using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeWork4_u20494000.Models
{
    public class Staff : User
    {
        private string mJobType;
        private string mExperience;

        public Staff(string _FirstName, string _LastName, string _PhoneNumber, int _Age, string _JobType, string _Experience) : base(_FirstName, _LastName, _PhoneNumber, _Age)

        {
            mJobType = _JobType;

            mExperience = _Experience;

        }

        public string JobType { get { return mJobType; } set { mJobType = value; } }

        public string Experience { get { return mExperience; } set { mExperience = value; } }
    }
}
