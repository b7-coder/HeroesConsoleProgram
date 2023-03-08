using System;
namespace HeroesConsoleProgram.Abstract
{
    internal interface ILogger
    {
        ConsoleColor color { get; set; }
        void log(string message);
    }
}
