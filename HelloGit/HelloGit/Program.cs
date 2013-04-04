using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloGit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(("Hello Git"));
            Console.WriteLine(("You've been modified."));
            Console.WriteLine(("Todays fortune:" + GetFortune()));
            Console.ReadKey();
        }

        private static  string GetFortune()
        {
            Random rnd = new Random();
            int whichOne = rnd.Next(3);
            string fortune = "";
            switch (whichOne)
            {
                case 1:
                    fortune = "You will meet a dark stranger";
                    break;
                case 2:
                    fortune = "Your code will be bug-free";
                    break;
                case 3:
                    fortune = "Avoid dog today";
                    break;
                default:
                    fortune= "No fortune for you";
                    break;
            }
            return fortune;
        }
    }
}
