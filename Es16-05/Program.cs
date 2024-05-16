using Es16_05.handler;

namespace Es16_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = AskNames();
            IGreet greetHandler = InitializeSuccession();
            string greet = greetHandler.Greet(names);
            Console.WriteLine(greet);
        }
        public static string[] AskNames()
        {
            Console.WriteLine("Insert your name (or names by separating with comma if two names):");
            string input = Console.ReadLine();
            if (input == "")
            {
                return new string[0];
            }
            else
            {
                return input.Split(',');
            }
        }

        public static IGreet InitializeSuccession()
        {
            BaseGreetHandler baseGreetHandler = new BaseGreetHandler();
            NullHandler nullHandler = new NullHandler();
            ShoutHandler shoutHandler = new ShoutHandler();
            TwoNamesHandler twoNamesHandler = new TwoNamesHandler();

            nullHandler.SetSuccessor(shoutHandler)
                       .SetSuccessor(twoNamesHandler)
                       .SetSuccessor(baseGreetHandler);

            return nullHandler;  
        }
    }
}
