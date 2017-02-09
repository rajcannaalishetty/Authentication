using System;


namespace Authentication
{
    class Program
    {

        static void Main(string[] args)
        {
            int i = 0;

        TryAgain:
            Console.WriteLine("\nenter your username ");
            string user = Console.ReadLine().ToUpper();
            Console.WriteLine("\nenter your password");
            string password = (Console.ReadLine().ToUpper());

            if (user == "RAJCANNA" && password == "RAJ18110")
            {
                Console.WriteLine("login successful \n\n*****enjoy your day*****");

            }
            else

                do
                {
                    while (i < 2)
                    {
                        Console.WriteLine("I'm sorry ..something went wrong..please try again");
                        Console.WriteLine("\n\nnumber of attempts left to u are {0}", 2 - i);
                        i++;
                        goto TryAgain;

                    }
                    Console.WriteLine("user account has been blocked");
                    Console.ReadLine();
                } while (i < 2);

        }

    }
}
