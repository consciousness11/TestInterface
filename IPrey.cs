using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInterface
{
   public interface IPrey
    {
        int FleeSpeed { get; set; }
        void Flee();

    }
}
