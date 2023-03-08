using HeroesConsoleProgram.Abstract;
using HeroesConsoleProgram.Factories.Hero.Base;
using HeroesConsoleProgram.Factories.Skills;
using HeroesConsoleProgram.Loggers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesConsoleProgram.Factories.Hero
{
    internal class SwordsFreezeHeroCreator : CreatorHeroBase
    {
        public IHero FactoryMethod()
        {
            var logger = new ConsoleLogger() { color = ConsoleColor.Blue };

            var skills = new List<IBaseSkill>();
            skills.Add(new Sword() { DamageMultiplier=4, logger = logger });
            skills.Add(new Freeze() { logger= logger });
            return new Hero()
            {
                Name = "SwordsFreezeHero",
                Skills = skills,
                logger = logger
            };
        }
    }
}
