﻿using System;
using System.Linq;

namespace sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list = {1,20,30,4,50,6,70};

            var newList = list.Where(Compare);
            
            //new 
            //second commit add new function

            foreach(int item in newList)
                Console.WriteLine(item);

        }

        public int sum()
        {

        }


        public static bool Compare(int x) => x > 15;  



    }
}
