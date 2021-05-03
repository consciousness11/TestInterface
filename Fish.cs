using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInterface
{
    public class Fish:IPrey
    {
        private int _fleeSpeed;

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
