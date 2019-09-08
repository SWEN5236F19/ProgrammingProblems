using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            bool cont = true;
            while (cont)
            {
                PrintMenu();
                var input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        ProgrammingProblem1();
                        break;
                    case "2":
                        ProgrammingProblem2();
                        break;
                    case "3":
                        ProgrammingProblem3();
                        break;
                    case "4":
                        ProgrammingProblem4();
                        break;
                    case "5":
                        ProgrammingProblem5();
                        break;
                    case "Q":
                    case "q":
                        cont = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Entry, Try Again");
                        break;
                }

            }
        }

        static void ProgrammingProblem1()
        {
            Console.WriteLine("Enter strings you'd like to print, one string per line, enter 'STOP' when finished");
            List<string> strings = GetStringInput();
            Functions.Print<string>(strings);
        }

        static void ProgrammingProblem2()
        {
            int lower, upper;
            GetLowerUpperBounds(out lower, out upper);
            Functions.PrintEvenNumbers(lower, upper);
        }

        static void ProgrammingProblem3()
        {
            Console.WriteLine("Enter integers, one integer per line, enter 'STOP' when finished");
            var numbers = GetIntInput();
            Functions.PrintLowestNumber(numbers);
        }

        static void ProgrammingProblem4()
        {
            int lower, upper;
            GetLowerUpperBounds(out lower, out upper);
            Console.WriteLine("Select Parity: 1 - Even, 2 - Odd");
            PARITY parity;
            var input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    parity = PARITY.EVEN;
                    break;
                case "2":
                    parity = PARITY.ODD;
                    break;
                default:
                    Console.WriteLine("Invalid Entry, exiting exercise");
                    return;
            }
            if(parity == PARITY.EVEN)
            {
                Functions.PrintEvenNumbers(lower, upper);
            }
            else
            {
                Functions.PrintOddNumbers(lower, upper);
            }
        }

        static void ProgrammingProblem5()
        {
            int lower, upper;
            GetLowerUpperBounds(out lower, out upper);
            List<int> range = new List<int>();
            for (int i = lower; i <= upper; i++)
            {
                range.Add(i);
            }
            Functions.PrintReverseOrder<int>(range);
            Functions.Print<int>(range);
        }

        private static void PrintMenu()
        {
            Console.WriteLine("Select a programming exercise to execute");
            Console.WriteLine("1 - Print Strings");
            Console.WriteLine("2 - Print Numbers divisible by 2 in a range");
            Console.WriteLine("3 - Print Lowest Number");
            Console.WriteLine("4 - List Even or Odds");
            Console.WriteLine("5 - Print Input in reverse and original order");
            Console.WriteLine("Q - Quit");
        }

        private static List<string> GetStringInput()
        {
            bool cont = true;
            List<string> strings = new List<string>();
            while (cont)
            {
                var input = Console.ReadLine();
                if (input.ToLower().Equals("stop"))
                {
                    cont = false;
                }
                else
                {
                    strings.Add(input);
                }
            }
            return strings;
        }

        private static List<int> GetIntInput()
        {
            bool cont = true;
            List<int> integers = new List<int>();
            while (cont)
            {
                var input = Console.ReadLine();
                if (input.ToLower().Equals("stop"))
                {
                    cont = false;
                }
                else
                {
                    int number = 0;
                    bool parsed = int.TryParse(input, out number);
                    if (parsed)
                    {
                        integers.Add(number);
                    }
                    else
                    {
                        Console.WriteLine("Please enter an integer");
                    }
                }
            }
            return integers;
        }

        static bool GetLowerUpperBounds(out int lower, out int upper)
        {
            lower = 0;
            upper = 0;

            Console.WriteLine("Please enter integer lower bound");
            var input = Console.ReadLine();

            bool parsed = int.TryParse(input, out lower);
            if (!parsed)
            {
                Console.WriteLine("Invalid entry, exiting exercise");
                return false;
            }

            Console.WriteLine("Please enter integer upper bound");
            input = Console.ReadLine();
            parsed = int.TryParse(input, out upper);
            if (!parsed)
            {
                Console.WriteLine("Invalid entry, exiting exercise");
                return false;
            }
            return true;
        }
    }
}
