using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CheckZips
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] zipcodes = {52800, 52801, 52802, 52803, 52804, 52805, 52806, 52807, 52808, 52809};
            int userChoice;
            
            string userString;


            WriteLine("Please enter your zipcode - ");
            userString = ReadLine();
            userChoice = Convert.ToInt32(userString);

            for (int i = 0; i < 10; i++)
            {

                if (userChoice == zipcodes[i])
                {
                    WriteLine("Correct Delivery");
                }
            }




        }
    }
}
