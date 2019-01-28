using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            for(int t = 0; t < T; t++)
            {
                string line = Console.ReadLine();
                string[] space = line.Split('\n');
                string Num1 = space[0];
                int sum = FunBack((Convert.ToInt32(Num1)));
                Console.WriteLine(sum);
            }
        }
        public static int FunBack(int n)
        {
            int ret = 0;
            for(int i = 1; i < n; i++)
            {
                if (gcd(i, (int)n) > 1)
                    ret += i;
            }
            return ret;
        }
        public static int gcd(int a,int b)
        {
            if (a == 0) return b;
            return gcd(b % a, a);
        }
    }
}
