using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanyaNewHopev2
{
    [Serializable]
    public class Facultet
    {
        public Facultet(string NameOfFac, int PayForContract, List<Spec> specList)
        {
            this.NameOfFac = NameOfFac;
            this.PayForContract = PayForContract;
            SpecList = specList;
        }
        public string NameOfFac { get; set; }
        public int PayForContract { get; set; }
        public List<Spec> SpecList { get; set; }



    }
}
