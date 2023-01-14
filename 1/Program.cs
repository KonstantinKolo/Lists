using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List <int>list = new List <int>();
            for (int i = 0; i < n; i++) 
            {
                list.Add(int.Parse(Console.ReadLine()));
            }
            for (int index = 0; index < list.Count; index++) 
            {
                Console.WriteLine("list[{0}] = {1}", index, list[index]);
            }
        }
    }
}
