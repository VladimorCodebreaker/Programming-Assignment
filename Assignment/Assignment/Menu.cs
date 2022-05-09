using System;

namespace Assignment
{
    public class Menu
    {
        public static void Run()
        {
            Implementation implementation = new Implementation();

            while (true)
            {
                Console.WriteLine("----------------- Menu ----------------- \n" +
                    "0. EXIT \n" +
                    "1. Add \n" +
                    "2. Display \n");

                bool userChoice = int.TryParse(Console.ReadLine(), out int choice);

                if (choice == 0)
                {
                    break;
                }

                Console.Clear();

                switch (choice)
                {
                    case 1:
                        implementation.Add();
                        break;
                    case 2:
                        implementation.Print();
                        break;
                    default:
                        Run();
                        break;
                }
            }
            Console.WriteLine("Thank you for using my application. I hope to get a high mark. :)");
            Console.ReadKey();
        }
    }
}

