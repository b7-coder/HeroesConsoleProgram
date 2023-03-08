using HeroesConsoleProgram.Abstract;

namespace HeroesConsoleProgram.Loggers
{
    internal class ConsoleLogger : ILogger
    {
        public ConsoleColor color { get; set; } = default;

        public void log(string message)
        {
            Console.BackgroundColor = color;
            Console.WriteLine(message);
        }

    }
}
