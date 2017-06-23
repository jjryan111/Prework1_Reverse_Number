using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static string getInput()
        {
            //Make sure we can handle whatever is entered
            string inp = "";
            bool cept = false;
            while (!cept)
            {
                cept = true;
                Console.Write("Enter a number: ");
                inp = Console.ReadLine();
                try
                {
                    double inputTry = Convert.ToDouble(inp);
                }
                catch (Exception)
                {
                    Console.WriteLine("That's not a number. Try Again.");
                    cept = false;
                }
                if (inp.IndexOf(".") != -1 || inp.IndexOf("e") != -1 || (inp.Length > 15))
                    // Numbers with more than 16 digits have exponential notation associated with them and 
                    // can't be reversed by this method.
                {
                    Console.WriteLine("Complex numbers are out of scope!");
                    cept = false;
                }
               
            }
            return inp;
        }

        static void Main()
        {
           string input = getInput();
           double inputNum = Convert.ToDouble(input);
           int inputLength = input.Length;
           if (inputNum < 0) //Might as well allow for negative numbers because it's easy
                { 
                    Console.Write("-");
                    inputNum = Math.Abs(inputNum);
                    inputLength--; //make room for the - sign
                }
           inputLength--; //array indices start at 0, lengths start at 1
           while (inputLength != 0)
               {
                    Console.Write(inputNum % 10);
                    inputNum = Math.Truncate(inputNum / 10 * 1);
                            inputLength--;
               }
           Console.WriteLine(inputNum); //Write the last digit
           Console.WriteLine("That's all folks. Press enter to continue");
           Console.Read();
        }}}