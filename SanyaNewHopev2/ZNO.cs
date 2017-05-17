using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanyaNewHopev2
{
    [Serializable]
    public class ZNO
    {
        public string NAME { get; set; }
        public double KOOF { get; set; }
        public ZNO(double koof, string name)
        {
            KOOF = koof;
            NAME = name;
        }
    }
}
