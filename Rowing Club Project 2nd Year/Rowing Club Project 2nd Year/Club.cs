﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Rowing_Club_Project_2nd_Year
{
    class Club
    {
        private String ClubName;
        private static List<String> ListOfMembers = new List<String>();
        private String date1 = null;
        public String GetClubName()
        {
            return ClubName;
        }
        public void SetClubName(String ClubName)
        {
            this.ClubName = ClubName;
        }
        public List<String> GetListOfMembers()
        {
            // add stuff here
            return ListOfMembers;
        }
        public void SetListOfMembers()
        {
            ListOfMembers = File.ReadAllLines("test.csv").ToList();
        }
    }
}
