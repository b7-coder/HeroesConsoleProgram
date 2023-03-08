using HeroesConsoleProgram.Abstract;

namespace HeroesConsoleProgram.Factories.Hero.Base
{
    internal interface CreatorHeroBase
    {
        IHero FactoryMethod();
    }
}
