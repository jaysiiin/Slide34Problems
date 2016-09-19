using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slide34Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Animals = new List<string>();
            Animals.Add("Oxy");
            Animals.Add("Doge");
            Animals.Add("Kitty");
            Animals.Add("Horsey");
            Animals.Add("Birdy");

            foreach(string Display in Animals)
            {
                Console.WriteLine(Display);
                Console.WriteLine();
            }



            List<bool> boolList = new List<bool>() { true, false, false, true, false };

            foreach (bool ThisDisplay in boolList)
            {
                //Console.WriteLine(ThisDisplay);
                
                if (ThisDisplay == true)
                        {
                    Console.WriteLine("Better bring an umbrella");

                        }
                else
                {
                    Console.WriteLine("No rain today, enjoy the sun!");
                }
            }




            Dictionary<string, int> phoneBook = new Dictionary<string, int>();
            phoneBook.Add("Juan", 111);
            phoneBook.Add("Yo", 222);
            phoneBook.Add("Another1", 333);
            phoneBook.Add("Number", 444);
            phoneBook.Add("LOL", 555);

            foreach(KeyValuePair<string, int> tempKeyValue in phoneBook)
            {
                Console.WriteLine();
                Console.WriteLine(tempKeyValue);
            }









        }
    }
}
