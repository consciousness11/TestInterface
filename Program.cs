using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat tom = new Cat();
            tom.AttackSpeed = 10;

            Fish frenzy = new Fish();
            frenzy.FleeSpeed = 12;

            tom.Purr();
            tom.Attack(frenzy);

        }
    }
}
