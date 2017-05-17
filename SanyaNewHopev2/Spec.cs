using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanyaNewHopev2
{
    [Serializable]
    public class Spec
    {
        public Spec()
        {

        }
        public Spec(string name, List<ZNO> lzno, int popular, int minbal)
        {
            Name = name;
            Lzno = lzno;
            Popular = popular;
            Minbal = minbal;
        }
        public string Name { get; set; }
        public List<ZNO> Lzno { get; set; }
        public int Popular { get; set; }
        public int Minbal { get; set; }


    }
}
