using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class Race
        {
        public static string euro = "европиоидная";
        public static string mongol = "монголоидная";
        public static string americ = "американоидная";

    }
     
    public class Man
    {
        static public int count = 0;

        public string name;
        public string race;

        public Man(string name, string race)
        {
            this.name = name;
            this.race = race;
            count++;
        }
    }
}
