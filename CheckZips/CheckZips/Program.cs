﻿using System;
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
            int userChoice;
            string userString;

            WriteLine("Please enter your zipcode - ");
            userString = ReadLine();
            userChoice = Convert.ToInt32(userString);

            ZipCodes.displayZips(userString, userChoice);

        }
       
        }
    }
}
