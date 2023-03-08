using HeroesConsoleProgram.Abstract;
using HeroesConsoleProgram.Factories.Hero.Base;
using HeroesConsoleProgram.Factories.Skills;
using HeroesConsoleProgram.Loggers;

namespace HeroesConsoleProgram.Factories.Hero
{
    internal class SwordHeroCreator : CreatorHeroBase
    {
        public IHero FactoryMethod()
        {
            var skills = new List<IBaseSkill>();
            skills.Add(new Sword());

            return new Hero() 
            {
                Name = "SwordsHero",
                Skills = skills,
                logger = new ConsoleLogger()
            };
        }
    }
}
