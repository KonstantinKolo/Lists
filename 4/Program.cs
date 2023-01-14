using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int before = 0;
            int count = 2;
            int maxcount = 0;
            int answer = 0;
            for (int s1 = list.Count - 1; s1>=0; s1--)
            {
                if (list[s1] == before)
                {
                    if (count >= maxcount)
                    {
                        maxcount = count;
                        answer = list[s1];
                    }
                    count++;
                }
                else
                {
                    count = 2;
                }
                before = list[s1];
            }
            for (int s2 = 0; s2 < maxcount; s2++)
            {
                Console.Write(answer + " ");
            }
        }
    }
}
