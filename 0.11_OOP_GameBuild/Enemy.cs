using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._11_OOP_GameBuild
{
    class Enemy: Character
    {
        //Constructor - should have the same name as the class
        public Enemy(string name, int level)
        {
            this.Name = name;
            this.Level = level;
            this.IsAlive = true;
            this.Health = 100;
            this.AttackPower = 8;
            this.CritChance = 0.20;
        }

    }
}
