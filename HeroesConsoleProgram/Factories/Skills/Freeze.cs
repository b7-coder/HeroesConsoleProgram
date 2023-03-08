using HeroesConsoleProgram.Abstract;
using HeroesConsoleProgram.Loggers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesConsoleProgram.Factories.Skills
{
    internal class Freeze : IBaseSkill
    {
        public string Name { get; set; } = "Freeze";
        public int Damage { get; set; } = 20;
        public int DamageRadius { get; set; } = 2;
        public int ReloadTime { get; set; } = 2;
        public IceColor IceColor { get; set; }
        public ILogger logger { get; set; } = new ConsoleLogger();

        public int UseSkill()
        {
            var color = (IceColor)IceColor;
            logger.log($"Using {Name}. Damage: {Damage}, Radius: {DamageRadius}, ReloadTime: {ReloadTime}, IceColor: {color}");
            return Damage;
        }
    }
    enum IceColor
    {
        white,
        blue,
        green,
        yellow,
        red
    }
}
