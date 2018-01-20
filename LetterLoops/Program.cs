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
            //first count how many characters are in the input
            string input = "abcd";

            //next loop over the input and print out 1st character once (uppercase), insert a dash, then, repeat
            for (int i = 0; i < input.Count(); i++)
            {
                var onecharacter = input[i];
                //if the index is 0, change the letter to uppercase
                //for all other characters in the input, print and repeat by one more 
                if (i == 0)
                {
                    onecharacter.ToUpper;
                }
                    
            }

               
                   
        }

    }


}

