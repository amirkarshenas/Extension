using System;
using System.Linq;

namespace sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list = {1,20,30,4,50,6,70};

            var newList = list.Where(Compare);
            


            foreach(int item in newList)
                Console.WriteLine(item);

        }

        


        public static bool Compare(int x) => x > 10;  



    }
}
