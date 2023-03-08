using HeroesConsoleProgram.Abstract;
using HeroesConsoleProgram.Loggers;

namespace HeroesConsoleProgram.Factories.Skills
{
    internal class Sword : IBaseSkill
    {
        public string Name { get; set; } = "Sword";
        public int Damage { get; set; } = 10;
        public int DamageRadius { get; set; } = 1;
        public int DamageMultiplier { get; set; } = 2;
        public ILogger logger { get; set; } = new ConsoleLogger();

        public int UseSkill()
        {
            logger.log($"Using {Name}. Base damage: {Damage}, Overall damage: {Damage * DamageMultiplier}, Radius: {DamageRadius}, Damage multiplier: {DamageMultiplier}");
            return Damage * DamageMultiplier;
        }
    }
}
