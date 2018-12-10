using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace ArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[9];
            int i;
            int userChoice;
            string userString;
           
            WriteLine("Input 8 elements in the array, enter 999 to end program.");
            for (i = 1; i < 9; i++)
            {
                Write("Enter a number - " + i + ": ");
                arr[i] = Convert.ToInt32(ReadLine());
            }

            WriteLine("Enter 1 to view list from first to last or enter 2 to view list " + 
                "from last to first");
            userString = ReadLine();
            userChoice = Convert.ToInt32(userString);
            if (userChoice == 1)
            {
                for(int j = 1; j < arr.Length; j++)
                {
                    WriteLine("Numbers entered were " + arr[j]);
                }
            }
            else if(userChoice == 2)
            {
                for (int b = 8; b < arr.Length; --b)
                {
                    WriteLine("Numbers entered were" + arr[b]);
                }
            }
            
        }
    }
}
