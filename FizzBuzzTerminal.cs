 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
	class FizzBuzzTerminal
	{
        public static void Main(string[] args) {
            fizzBuzz newFizzBuzz = new fizzBuzz();
            string[] array = fizzBuzz.FizzBuzz();
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(array[i]);
            }

            Console.ReadLine(); 

        }

    }

}
