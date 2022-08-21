using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeWork4_u20494000.Models
{
    public class Player : User
    {
        private string mPosition;
        private string mHeight;
        private string mStrongFoot;

        public Player(string _FirstName, string _LastName, string _PhoneNumber, int _Age, string _Position, string _Height, string _StrongFoot) : base (_FirstName, _LastName, _PhoneNumber, _Age)

        {
            mPosition = _Position;

            mHeight = _Height;

            mStrongFoot = _StrongFoot;

        }

        public string Position { get { return mPosition; } set { mPosition = value; } }

        public string Height { get { return mHeight; } set { mHeight = value; } }

        public string StrongFoot { get { return mStrongFoot; } set { mStrongFoot = value; } }
    }
}