using System;
using System.Collections.Generic;
using System.Text;

namespace TestDrivenDevelopmentLecture
{
    class Primething
    {
        public string Kata(int num)
        {
            if (num == 1)
            {
                return "odd";
            }
            if (num == 2)
            {
                return "prime";
            }
            if(num % 2 == 0)
            { 
                return "even";
            }
            for (int i = 3; i < num; i++)
            {
                if (num % i == 0)
                {
                    return "odd";
                }
            }
            return "prime";
        }
    }
}
