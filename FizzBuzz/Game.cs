using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public static class Game
    {       
        public static string PlayNumber(int num)
        {
            if (num % 3 == 0 && num % 5 == 0) return "FizzBuzz";

            else if (num % 3 == 0) return "Fizz";

            else if (num % 5 == 0) return "Buzz";

            else return $"{num}";
        }
    }
}
