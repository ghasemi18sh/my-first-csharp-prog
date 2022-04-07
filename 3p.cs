using System;

namespace palmpolompilish
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int emtiazpc1 = 0, emtiazpc2 = 0, emtiazuser = 0, index1, index2;
            string computer1_choice, computer2_choice, user_choice;

            string[] options = new string[2];
            options[0] = "palam";
            options[1] = "polom";

            while (true)
            {
                index1 = r.Next(0, 2);
                index2 = r.Next(0, 2);
                computer1_choice = options[index1];
                computer2_choice = options[index2];

                user_choice = Console.ReadLine();
                Console.WriteLine("computer1: {0:X}", computer1_choice);
                Console.WriteLine("computer2: {0:X}", computer2_choice);

                if (computer1_choice == computer2_choice && user_choice != computer1_choice)
                {
                    emtiazuser++;
                }
                else if (computer1_choice == user_choice && computer2_choice != computer1_choice)
                {
                    emtiazpc2++;
                }
                else if (computer2_choice == user_choice && computer1_choice != computer2_choice)
                {
                    emtiazpc1++;
                }

     

                if (emtiazuser == 5)
                {
                    Console.WriteLine("user barandeshod");
                    break;
                }
                else if (emtiazpc1 == 5)
                {
                    Console.WriteLine("pc 1 barande shod ");
                    break;
                }
                else if (emtiazpc2 == 5)
                {
                    Console.WriteLine("pc 2  barande shod");
                    break;
                }
            }

        }
    }
}
