using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInterface
{
    public class Fish : IPrey, IPredator
    {
        private int _fleeSpeed;
        private int _attackSpeed;

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

        public int FleeSpeed
        {
            get { return _fleeSpeed; }
            set { _fleeSpeed = value; }
        }

        public void Flee()
        {
            Console.WriteLine("Fish fleeing");
        }
    }
}
