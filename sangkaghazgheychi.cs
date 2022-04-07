// See https://aka.ms/new-console-template for more information




using System;

namespace prs

{

    class Program

    {

        static void Main(string[] args)

        {

            Random r = new Random();

            int user_score = 0, computer_score = 0, index;

            string computer_choice, user_choice;

            string[] options = new string[3];

                      options[0] = "rock";

                      options[1] = "paper";

                      options[2] = "scissor";

            for (int i = 0; i < 5; i++)

            {

                index = r.Next(0, 3);

                computer_choice = options[index];




                user_choice = Console.ReadLine();

                Console.WriteLine(computer_choice);




                if (computer_choice == "paper" && user_choice == "rock")

                {

                    computer_score++;

                }

                else if (computer_choice == "paper" && user_choice == "scissor")

                {

                    user_score++;

                }
                else if (computer_choice == "paper" && user_choice == "paper")

                {

                    user_score++;
                    computer_score++;


                }

                else if (computer_choice == "scissor" && user_choice == "scissor")

                {

                    computer_score++;

                    user_score++;

                }
                else if (computer_choice == "scissor" && user_choice == "paper")

                {

                    computer_score++;

                }
                else if (computer_choice == "scissor" && user_choice == "rock")

                {

                    user_score++;

                }
                else if (computer_choice == "scissor" && user_choice == "scissor")

                {

                    computer_score++;
                    user_score++;


                }
                else if (computer_choice == "rock" && user_choice == "rock")

                {

                    user_score++;
                    computer_score++;


                }
                else if (computer_choice == "rock" && user_choice == "scissor")

                {

                    computer_score++;

                }
                else if (computer_choice == "rock" && user_choice == "paper")

                {

                    user_score++;

                }




            }

            if (user_score > computer_score)

            {

                Console.WriteLine("you win");

            }

            else if (computer_score > user_score)

            {

                Console.WriteLine("computer win");

            }

            else

            {

                Console.WriteLine("the same");

            }

        }

    }

}
