using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesConsoleProgram.Abstract
{
    internal interface IBaseSkill
    {
        string Name { get; set; }
        int Damage { get; set; }
        int DamageRadius { get; set; }
        int UseSkill();
        ILogger logger { get; }
    }
}
