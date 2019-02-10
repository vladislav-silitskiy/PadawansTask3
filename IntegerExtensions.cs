using System;

namespace PadawansTask3
{
    public static class IntegerExtensions
    {
        public static int Gcd(int a, int b)
        {
            // put your code here

            int Gcd = 0;
            int r = 0;

            int t = 0;
            if (a < b)
            {
                t = a;
                a = b;
                b = t;
            }

            if ((a == 0) && (b == 0))
            {
                Gcd = 0;
            }
            else if (a == 0)
            {
                Gcd = b;
            }
            else if (b == 0)
            {
                Gcd = a;
            }
            else if ((a == b) && (a != 0) && (b != 0))
            {
                Gcd = a;
            }
            else if (a % b == 0)
            {
                Gcd = b;
            }
            else if (a > b)
            {
                for (r = a % b; a % b != 0;)
                {
                    a = b;
                    b = r;
                }
                Gcd = r;
            }
            
            if (Gcd < 0)
            {
                Gcd = -Gcd;
            }
            return Gcd;

        }
    }
}
