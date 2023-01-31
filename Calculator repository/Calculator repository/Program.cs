using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Welcome message.
            Console.WriteLine("Hello, welcome to your personal Calculator:");

            //Allows the user to use the calculator again.
            string restartCodeLoop;

            //declare float here lastAnswer default to 0
             
            bool restartCode = true;
            while (restartCode)

            {
                //These are my variables.
                double number1;
                string answer1;
                double number2;
                string answer2;
                double Pi = 3.14159;  //Just in case the user wants to use Pi.
                double E = 2.71828;  //Just in case the user wants to use E.
                double e = 2.71828; //If the user accidently enters a lowercase e this makes sure that it still works                   
                int cancel = 0;

                InputFirst(out number1, out answer1, Pi, E, e, cancel); //I have made this into a method to neaten the code up a little bit.
               
                    //Changed the order in which the operations are asked for. This is because this is how a calculator actually asks for it.

                    Console.WriteLine("Enter the operation needed ( +, -, /, *, x^y, Sqrt, x!, 1/x, x^3, 10^x");
                    Console.WriteLine("You choose? ");
                    string Operator = Console.ReadLine(); // Operator refers to the calculation that the user would like to use.

                    //This makes it so that the program will not ask for a second number if any of these options are chosen. If not, the program will ask for the second number and calculate.
                    if (Operator == "Sqrt" || Operator == "x!" || Operator == "1/x" || Operator == "x^3" || Operator == "10^x")
                    {
                        Calculator(number1, 0, Operator);
                    }
                    else
                    {
                        InputSecond(out number2, out answer2, Pi, E, e, cancel);
                    
                        Calculator(number1, number2, Operator);
                    }

                    Console.WriteLine("Continue? Press any key to continue, E or e to exit:\n"); //Allows the user to Exit the program when E is pressed or will alllow the user to rerun the calculator program.
                    restartCodeLoop = Console.ReadLine();
                    if (restartCodeLoop == "E" || restartCodeLoop == "e")
                    {
                        restartCode = false; //Restarts the code.
                    }
                    else if (restartCodeLoop == "cancel")
                    {
                    Console.WriteLine("0");
                    Console.ReadKey(); //Restarts the code and resets to 0.                     
                    }
                    else
                    {
                        Console.ReadKey(); //Closes the program when E is pressed.
                    }



            }

            }





            //This below is all the methods/references.
            private static void InputFirst(out double number1, out string answer1, double Pi, double E, double e, int cancel) //An attempt at neatening up some code.
            {
                Console.WriteLine("Input first number.");
                answer1 = Console.ReadLine();
                if (answer1 == "pi")
                {
                    number1 = Pi;

                }
                else if (answer1 == "E")
                {
                    number1 = E;
                }
                else if (answer1 == "e")
                {
                    number1 = e;
                }
                else if (answer1 == "cancel")
                {
                number1 = 0;
                }
                else
                {
                    number1 = Convert.ToInt32(answer1);
                }
            }

            private static void InputSecond(out double number2, out string answer2, double Pi, double E, double e, int cancel) //An attempt at neatening up some code.
            {
                Console.WriteLine("Input second number.");
                answer2 = Console.ReadLine();
                if (answer2 == "pi")
                {
                    number2 = Pi;

                }
                else if (answer2 == "E")
                {
                    number2 = E;
                }
                else if (answer2 == "e")
                {
                    number2 = e;
                }
                else if (answer2 == "cancel")
                {
                    number2 = 0;
                }
                else
                {
                    number2 = Convert.ToInt32(answer2);
                }
            }
            

            //maybe make float?

            private static void Calculator(double number1, double number2, string Operator)
            {
                switch (Operator)
                {
                    case "+":  //This Is for Addition.
                        Console.WriteLine($"Your result: {number1} + {number2} = " + (number1 + number2));
                        break;
                    case "-":  //This Is for Subtraction.
                        Console.WriteLine($"Your result: {number1} - {number2} = " + (number1 - number2));
                        break;
                    case "/":  //This Is for Division.
                        Console.WriteLine($"Your result: {number1} / {number2} = " + (number1 / number2));
                        break;
                    case "*":  //This Is for Multiplication.
                        Console.WriteLine($"Your result: {number1} * {number2} = " + (number1 * number2));
                        break;
                    case "x^y":  //This Is for X to the power of Y.
                        Console.WriteLine($"Your result: {number1} ^ {number2} = " + (Math.Pow(number1, number2)));
                        break;
                    case "Sqrt": //This Is for squareroot.
                        Console.WriteLine($"Your result: Sqrt of {number1}  = " + (Math.Sqrt(number1)));
                        break;
                    case "x!":  //This Is for doing the Fatorial of a number.
                        {
                            double i, factorial = 1, number;
                            number = number1;
                            for (i = 1; i <= number; i++)
                            {
                                factorial = factorial * i;
                            }
                            Console.Write($"Your result: The Factorial of {number1} = " + (factorial) + " ");
                        }
                        break;
                    case "1/x":  //This Is for the Inverse of a number.
                        Console.WriteLine($"Your result: 1/{number1} = " + (1 / number1));
                        break;
                    case "x^3":  //This Is for X to the power of 3.
                        Console.WriteLine($"Your result: {number1} ^ 3 = " + (number1) * (number1) * (number1));
                        break;
                    case "10^x":  //This Is for 10 to the power of x.
                        Console.WriteLine($"Your result: 10 ^ {number1}  = " + (Math.Pow(10, number1)));
                        break;

                }

            }

        }

    }

