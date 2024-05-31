using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Man a = new Man("Алан", Race.mongol);
            Console.WriteLine(Man.count);

            Man b = new Man("Чингачкуг", Race.americ);
            Console.WriteLine(Man.count);

            Man с = new Man("Ын", Race.mongol);
            Console.WriteLine(Man.count);

            Man с = new Man("Мин", Race.mongol);
            Console.WriteLine(Man.count);
        }
    }
}
