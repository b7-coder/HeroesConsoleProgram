using HeroesConsoleProgram.Abstract;
using HeroesConsoleProgram.Loggers;

namespace HeroesConsoleProgram.Factories.Skills
{
    internal class Fire : IBaseSkill
    {
        public string Name { get; set; } = "Fire";
        public int Damage { get; set; } = 30;
        public int DamageRadius { get; set; } = 4;
        public int FireTime { get; set; } = 5;
        public ILogger logger { get; set; } = new ConsoleLogger();

        public int UseSkill() 
        {
            logger.log($"Using {Name}. Damage: {Damage}, Radius: {DamageRadius}, FireTime: {FireTime}");
            return Damage;
        }
    }
}
