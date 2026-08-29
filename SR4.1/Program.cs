using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число N>0");
            int N = Convert.ToInt32(Console.ReadLine());
            int s = 0;
            int n = 1;
            for (int i = 1; i <= N; i++)
            {
                s+=n;
                Console.WriteLine(s);
                n+=2;
            }
            Console.ReadKey();
        }
    }
}
