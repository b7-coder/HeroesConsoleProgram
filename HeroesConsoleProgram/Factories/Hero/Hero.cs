using HeroesConsoleProgram.Abstract;

namespace HeroesConsoleProgram.Factories.Hero
{
    internal class Hero : IHero
    {
        public string Name { get; set; }
        public List<IBaseSkill> Skills { get; set; }
        public ILogger logger { get; set; }
        public void Attack(IHero enemy)
        {
            logger.log($"{Name} attacks {enemy.Name}");

            double damageSum = 0;
            foreach(var skill in Skills) 
            {
                damageSum += skill.UseSkill();
            }
            enemy.TakeDamage(damageSum, this);
        }
        public void TakeDamage(double damageSum, IHero enemy)
        {
            logger.log($"{Name} received {damageSum} damage from {enemy.Name}");
        }
    }
}
