using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInterface
{
   public class Cat : IPredator
    {
        private int _attackSpeed;
      //  public int AttackSpeed { get; set; }
        public int AttackSpeed
        {
            get { return _attackSpeed; }
            set { _attackSpeed = value; }
        }

        public void Attack(IPrey prey)
        {
            if (_attackSpeed > prey.FleeSpeed)
                Console.WriteLine("Caught Prey");
            else
                Console.WriteLine("Prey Escaped");

        }
        public void Purr()
        {
            Console.WriteLine("Cat Purr");

        }
    }
}
