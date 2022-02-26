using System;

namespace BenWeek5Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            ProblemOne();
            ProblemTwo();
            ProblemFour();

            void ProblemOne()
            {
                int[] myNumbers = { 100 }; //Total of numbers user can input
                int count = 0; //Starting point of counter
                for (int i = 1; i < myNumbers.Length; i++) //This is the for loop
                {
                    if (myNumbers[i] % 3 == 0) //The number must be divisable by 3 and have no remainder
                        count++; //
                    Console.WriteLine(myNumbers[i]); //Console displays number of all numbers divisable by 3 and have no remainder
                }
                Console.WriteLine(count + " is the count.\n");
            }

            void ProblemTwo()
            {
                string Ok = "Ok"; //String one 
                string OK = "OK"; //String two
                string ok = "ok"; //String three
                int sum = 0; //Sum is declared at 0

                bool continueLoop = true;

                do
                {
                    Console.WriteLine("Enter a number or Press Ok to exit. "); //Console displays text regarding to either type a number of press ok. 
                    string s = Console.ReadLine();

                    if (s == ok || s == OK || s == Ok) //If the user enters in any of the strings
                    {
                        continueLoop = false; //The function will end. 
                    }

                    else
                    {
                        int num = int.Parse(s); //The int is passed by parse to string. 

                        sum += num; //All numbers that are inputed will be added together until the user presses ok, Ok, or OK.

                    }
                    Console.WriteLine(sum); //Adds the sum of all the numbers that are inputed.
                }
                while (continueLoop);
            }

            void ProblemFour()

            {
                Random rand = new Random(); //Random is made to make a new random variable. 

                int[] myNumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; //An array of numbers to be allocated their position.

                bool continueChance = true; //A bool that is set to true.

                for (int i = 0; i < myNumbers.Length; i++) //For loop that has parameters set.
                {
                    string s = Console.ReadLine();

                    int rand_num = int.Parse(s);

                    Console.WriteLine("Write in your guess"); //Console displays the text shown.

                    myNumbers[i] = Console.Read(); //User has to input numbers

                    if (myNumbers[i] == rand_num) //The number will be equal to random number.
                    {
                        Console.WriteLine("You won"); //Console displays the text shown.
                    }
                    else if (myNumbers[i] != rand_num) //The number will be not equal to random number.
                    {
                        continueChance = false;
                    }
                    else
                    {
                        Console.WriteLine("You lost"); //Console displays the text shown.
                    }
                }
            }
        }
    }