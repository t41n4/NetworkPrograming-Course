﻿using System.Data;

namespace Application
{
    public class ScreenType
    {
        public ScreenType(string iD, string name)
        {
            this.ID = iD;
            this.Name = name;
        }

        public ScreenType(DataRow row)
        {
            this.ID = row["id"].ToString();
            this.Name = row["TenMH"].ToString();
        }

        public string ID { get; set; }

        public string Name { get; set; }
    }
}