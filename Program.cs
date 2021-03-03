using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lowest_common_denominator
{
    class Program
    {
        static int gcd(int a,int b) {
            if (b == 0)
                return a;
            return gcd(b, a % b);
        }
        static int lcd(int a, int b) {
            if (a > b) {
                int t = a;
                a = b;
                b = t;
            }
            if (b % a == 0)
                return b;
            int dif = b % a;
            int dif2 = a % dif;
            if (dif2 == 0)
                return b*a/dif;
            double mul = (double)dif /(int)((double)dif/dif2+(double)dif2/dif);
           // double mul = (double)dif / gcd(dif, dif2);
            if (dif % dif2 == 0)
                mul = dif / dif2;
            return (int)(((double)a/dif*mul)*b);
        }
        static int lcd2(int a, int b)
        {
            if (a > b)
            {
                int t = a;
                a = b;
                b = t;
            }
            if (b % a == 0)
                return b;
            int dif = b % a;
            int dif2 = a % dif;
            if (dif2 == 0)
                return b * a / dif;
            //double mul = (double)dif / (int)((double)dif / dif2 + (double)dif2 / dif);
            double mul = (double)dif / gcd(dif, dif2);
            if (dif % dif2 == 0)
                mul = dif / dif2;
            return (int)(((double)a / dif * mul) * b);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Lowest common denominator = " + lcd(a, b));
            Console.WriteLine("Lowest common denominator2 = " + lcd2(a, b));
            Console.ReadLine();
        }
    }
}
