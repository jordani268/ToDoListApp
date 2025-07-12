namespace DoList
{
    class MainProgram
    {
        static void Main(string[] args)
        {            
            List<String> tasks = new List<String>();
            
            string option;
            bool running = true;

            Console.WriteLine("Welcome to the DoList app!"); // consider adding a feature to reset after 24 hours
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("The input is case sensitive, so just type in the appropriate integer value.");

            while (running)
            {
                Console.WriteLine("1. Add Task ");
                Console.WriteLine("2. Remove Task");
                Console.WriteLine("3. View all saved Tasks");
                Console.WriteLine("4. End Program"); 
                Console.WriteLine();
                option = Console.ReadLine();

                if (option == "1") 
                {
                    Console.WriteLine("What would you like to add?");
                    string incomingTask = Console.ReadLine();
                    tasks.Add(incomingTask);
                    Console.WriteLine();
                }

                if (option == "2") 
                {
                    Console.WriteLine("What would you like to remove?");
                    string outgoingTask = Console.ReadLine();
                    tasks.Remove(outgoingTask);
                    Console.WriteLine();
                }

                if (option == "3") 
                {
                    Console.WriteLine();
                    foreach (string task in tasks)
                    {
                        Console.WriteLine(task);
                    }
                    Console.WriteLine();
                }

                if (option == "4")
                {
                    running = false;
                    break;
                    Console.ReadKey();
                    Environment.Exit(0);
                }
            }
        }
    }
}