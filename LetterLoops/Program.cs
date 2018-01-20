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

            foreach (var character in input)
            {
                //next loop over the input and print out 1st character once (uppercase), insert a dash, then, move on to the next character in the input
                for (int i = 0; i < input.Count(); i++)
                {
                    var alpha = input[i];
                    var upper = alpha.ToString().ToUpper();
                    var lower = alpha.ToString().ToLower();
                    var dash = "-";

                    //first character should be uppercase 
                    if (i == 0)
                    {
                        Console.Write(upper);
                    }

                    //next character should be a "-" and an uppercase letter
                    else if (i == 1)
                    {
                        Console.Write(dash + upper);
                    }

                    //next character should be a lowercase letter and "-"
                    else if (i == 2)
                    {
                   
                        Console.Write(lower + dash);
                    }

                    //the last character in the input should be a lowercase letter but no dash
                    else if (i == 3)
                    {
                        Console.Write(lower);
                    };
                }
            }
            

               
                   
        }

    }


}

