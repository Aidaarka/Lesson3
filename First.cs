using System;

namespace lesson3
{
    class First
    {
        static void Main(string[] args)
        {
            int[] Mas = new int[1000];
            int CheckNum;
            int i;
            bool Check;

            for (CheckNum = 1; CheckNum < 1000; CheckNum++)
            {
                Check = true;
                for (i = 2; i <= CheckNum / 2; i++)
                {
                    if (!(Math.Sqrt(CheckNum) < 10) || (CheckNum % i) == 0)
                    {
                        Check = false;
                    }
                }
                if (Check)
                {
                    Mas[CheckNum] = CheckNum;
                    Console.Write("{0} ", Mas[CheckNum]);
                }
            }
        }
    }
}
