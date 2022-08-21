using HomeWork4_u20494000.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeWork4_u20494000.Controllers
{
    public class HomeController : Controller
    {

        public static List<Player> PlayerList = new List<Player>();
        public static List<Staff> StaffList = new List<Staff>();
        public static List<Parent> ParentList = new List<Parent>();

        public void LoadData()
        {
            Player newplayer = new Player("Ushir", "Goolab", "0767292372", 21 ,"Striker", "1.72","Right");
            PlayerList.Add(newplayer);

            Staff newstaff = new Staff("Thashil", "Rama", "0767292372", 31, "Coach","10 years");
            StaffList.Add(newstaff);

            Parent newparent = new Parent("Shahiel", "Jeram", "0767292372", 21, "22 Star st", "parent@gmail.com");
            ParentList.Add(newparent);

        }


        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Goal()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Player()
        {
            ViewBag.Message = "Your application description page.";

            return View(PlayerList);
        }


        public ActionResult DelfosFC()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Staff()
        {
            ViewBag.Message = "Your contact page.";
          
            return View(StaffList);
        
        }

        public ActionResult Parent()
        {
            ViewBag.Message = "Your contact page.";
            return View(ParentList);
        }

        public ActionResult Tournaments()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult AddPlayer(FormCollection Player)
        {
            //Function add player
            string Name = Player["Name"];
            string Surname = Player["Surname"];
            string Cellpone = Player["CellPhone"];
            int Age = Convert.ToInt32(Player["Age"]);
            string Position = Player["Position"];
            string Height = Player["Height"];
            string Foot = Player["StrongF"];

            Player newPlayer = new Player(Name, Surname, Cellpone, Age, Position, Height, Foot);
            PlayerList.Add(newPlayer);
            return Redirect("Player");
        }

        public ActionResult AddStaff(FormCollection Staff)
        {
            //Function add staff
            string Name = Staff["Name"];
            string Surname = Staff["Surname"];
            string Cellpone = Staff["CellPhone"];
            int Age = Convert.ToInt32(Staff["Age"]);
            string JobType = Staff["JobT"];
            string Exp = Staff["Exp"];


            Staff newStaff = new Staff(Name, Surname, Cellpone, Age, JobType, Exp);
            StaffList.Add(newStaff);
            return Redirect("Staff");

        }

        public ActionResult AddParent(FormCollection Parent)
        {
            //Function add parent
            string Name = Parent["Name"];
            string Surname = Parent["Surname"];
            string Cellpone = Parent["CellPhone"];
            int Age = Convert.ToInt32(Parent["Age"]);
            string Email = Parent["Email"];
            string Address = Parent["Address"];


            Parent newParent = new Parent(Name, Surname, Cellpone, Age, Address, Email);
            ParentList.Add(newParent);
            return Redirect("Parent");
        }

    }
}