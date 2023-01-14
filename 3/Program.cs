using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> answer = new List<int>();
            int max = list.Max();
            int min = list.Min();
            int countMax = 0;
            int countMin = 0;
            foreach (var number in list)
            {
                if (number == max)
                {
                    countMax++;
                }
                if (number == min)
                {
                    countMin++;
                }
            }
            for (int s1 = 0; s1 < countMin; s1++)
            {
                answer.Add(min);
            }
            if (max != min)
            {
                for (int s2 = 0; s2 < countMax; s2++)
                {
                    answer.Add(max);
                }
            }
            Console.Write(String.Join(" ",answer));
        }
    }
}
