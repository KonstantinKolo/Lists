using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string number;
            int sum = 0;
            for (int s1 = 0; s1 < list.Count ; s1++)
            {
                number = $"{list[s1]}";
                char[] charArray = number.ToCharArray();
                Array.Reverse(charArray);
                number = new string(charArray);
                sum = sum + int.Parse(number);
            }
            Console.WriteLine(sum);
        }
    }
}
