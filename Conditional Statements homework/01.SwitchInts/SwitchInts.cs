using System;

    class SwitchInts
    {
        static void Main()
        {
            int n = 25;
            int m = 15;
            int switcher = 0;


            if (n > m)
            {
                switcher = n;
                n = m;
                m = switcher;
            }

            Console.WriteLine("Integer N is = " + n);
            Console.WriteLine("Integer M is = " + m);
        }
    }