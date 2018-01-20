using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //first count how many characters are in the input and create a foreach loop to loop over each character of the input
            string input = "abcd";
            string Repeat = (input.Length * Count);

            foreach (var character in input)
            {
                //next loop over the input and print out 1st character once (uppercase), insert a dash, then, move on to the next character in the input
                for (int i = 0; i < input.Count(); i++)
                {
                    var alpha = input[i];
                    
                    //after the 1st charcter, for all characters in the input, print the first instance uppercase and repeat the characters in increments of 1 then insert a dash
                    if (i == 0)
                    {
                        alpha.ToString().ToUpper();
                    }

                    alpha.ToString().ToUpper();
                    Console.WriteLine(alpha(Repeat), "-");

                }
            }
            

               
                   
        }

    }


}

