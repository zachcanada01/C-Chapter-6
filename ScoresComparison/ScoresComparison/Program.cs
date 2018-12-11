using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace ScoresComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            int i;
            

            WriteLine("Enter your four previous test scores.");

            for (i = 1; i < 5; i++)
            {
                Write("Enter test score - " + i + ":");
                arr[i] = Convert.ToInt32(ReadLine());

            }

            if(arr[1] < arr[2] && arr[2] < arr[3] && arr[3] < arr[4])
            {

                for (int j = 1; j < arr.Length; j++)
                {
                    WriteLine("Test score : " + arr[j]);
                }

                WriteLine("Congratulations on your improvement");

               
            }
            else if(arr[1] > arr[2] && arr[2] > arr[3] && arr[3] > arr[4])
            {
               
                WriteLine("Your scores have decreased");
                
            }
            else if (arr[1] > arr[2] || arr[1] > arr[3] || arr[1] > arr[4])
            {

                for (int j = 1; j < arr.Length; j++)
                {
                    WriteLine("Test score : " + arr[j]);
                }

                WriteLine("Your scores are inconsistent");

               
            }
            


        }
    }
}
