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
            //Cat tom = new Cat();
            //tom.AttackSpeed = 15;

            //Fish frenzy = new Fish();
            //frenzy.FleeSpeed = 12;

            //IPredator tom = new Cat();
            //tom.AttackSpeed = 10;

            // IPrey frenzy = new Fish();
            // tom.Purr();
            // tom.Attack(frenzy);

            IPredator shark = new Fish();
            shark.AttackSpeed = 20;

           
            IPrey ray = new Fish();
            ray.FleeSpeed = 15;

            shark.Attack(ray);

           
            Console.Read();

        }
    }
}
