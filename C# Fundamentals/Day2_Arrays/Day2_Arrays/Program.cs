﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = new int[5];
            //numbers[0] = 4;
            //numbers[1] = 8;
            //numbers[3] = 12;
            //numbers[4] = 3;

            int[] numbers = { 4, 8, 12, 3 };
    
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }


            string[] names = { "Bob", "Mike", "Anne" };

            foreach(string name in names)
            {
                Console.WriteLine(name);
            }


            //Console.WriteLine(numbers[1].ToString());
            Console.ReadLine();
        }
    }
}
