using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace TemperatureList
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[8];
            int i;
            int total = 0;
            int average;
            int distance;
            

            WriteLine("Enter the high temperatures of each day of the week >>");

            for (i = 1; i < 8; i++)
            {
                Write("Enter a temperature - " + i + ":");
                arr[i] = Convert.ToInt32(ReadLine());
                total = total + arr[i];

            }


           

            for (int j = 1; j < arr.Length; j++)
            {
               
                average = total / 7;
                distance = average - arr[j];
                WriteLine("The temp was " + arr[j] + ". The distance from the average was " + distance);
                
            }
            average = total / 7;
            WriteLine("The average temperature was " + average );
        }
    }
}
