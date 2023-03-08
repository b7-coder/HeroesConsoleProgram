using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesConsoleProgram.Abstract
{
    internal interface IHero
    {
        string Name { get; set; }
        List<IBaseSkill> Skills { get; set; }
        void Attack(IHero enemy);
        void TakeDamage(double damageSum, IHero enemy);
        ILogger logger { get; }
    }
}
