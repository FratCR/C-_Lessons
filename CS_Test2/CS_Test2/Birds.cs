using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Test2
{
    internal class Birds
    {
        public string type;
        public int speed;
        public double weight;

        public virtual string makesound()
        {
            return "Sounds will write here";
        }
    }
}
