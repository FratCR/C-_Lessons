using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Test2
{
    internal class Parrot:Birds
    {
        public string name, color;

        public override string makesound()
        {
            return "cik cik";
        }
    }
}
