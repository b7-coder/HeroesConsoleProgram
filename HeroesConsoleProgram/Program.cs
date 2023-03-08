using HeroesConsoleProgram.Factories.Hero;

namespace HeroesConsoleProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var swordsHero = new SwordHeroCreator().FactoryMethod();
            var swordsFireHero = new SwordsFireHeroCreator().FactoryMethod();
            var swordsFreezeHero = new SwordsFreezeHeroCreator().FactoryMethod();

            swordsHero.Attack(swordsFireHero);
            swordsFireHero.Attack(swordsFreezeHero);
            swordsFreezeHero.Attack(swordsHero);

        }
    }
}