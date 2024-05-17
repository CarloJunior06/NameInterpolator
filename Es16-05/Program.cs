using Es16_05.handler;
using Microsoft.Extensions.DependencyInjection;

namespace Es16_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var host = ContainerNEW.CreateHostBuilder();
            var greetHandler = host.Services.GetRequiredService<IGreet>();
            string[] names = AskNames();
            string greet = greetHandler.Greet(names);
            Console.WriteLine(greet);
        }
        public static string[] AskNames()
        {
            Console.WriteLine("Insert your name (or names by separating with comma if two or more):");
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

        //public static IGreet InitializeSuccession()
        //{
        //    BaseGreetHandler baseGreetHandler = new BaseGreetHandler();
        //    NullHandler nullHandler = new NullHandler();
        //    ShoutHandler shoutHandler = new ShoutHandler();
        //    TwoNamesHandler twoNamesHandler = new TwoNamesHandler();
        //    MultiNameHandler multiNameHandler = new MultiNameHandler();
        //    nullHandler.SetSuccessor(multiNameHandler)
        //               .SetSuccessor(shoutHandler)
        //               .SetSuccessor(twoNamesHandler)
        //               .SetSuccessor(baseGreetHandler);
        //    return nullHandler;  
        //}
    }
}
