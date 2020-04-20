using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class FizzBuzz
    {
        public string GetFizzBuzz(int n)
        {
            if (n % 3 == 0 && n % 5 == 0)
                return "FizzBuzz";
            if (n % 3 == 0)
                return "Fizz";
            if (n % 5 == 0)
                return "Buzz";
            else
                return "";
            
        }
    }
}
