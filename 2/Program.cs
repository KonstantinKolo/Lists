using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            foreach(var number in list)
            {
                if (number % 2 == 0)
                {
                    Console.Write(number + " ");
                }
            }
        }
    }
}
