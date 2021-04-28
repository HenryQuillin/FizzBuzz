using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class fizzBuzz
    {
        public static string[] FizzBuzz()
        {
            string[] result = new string[100]; 
            for (int i = 1; i < 101; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    result[i - 1] = "FizzBuzz";  
                }
                else if (i % 3 == 0)
                {
                    result[i - 1] = "Fizz";
                }
                else if (i % 5 == 0)
                {
                    result[i - 1] = "Buzz";
                }
                else
                {
                    result[i - 1] = Convert.ToString(i);
                }

            }
            return result;
        }
    }
}
