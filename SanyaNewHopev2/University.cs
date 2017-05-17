using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanyaNewHopev2
{
    [Serializable]
    public class University
    {
        public string Name { get; set; }
        public List<Facultet> FacultetList { get; set; }
        public List<string> Hostel { get; set; }

        public University()
        {

        }

        public University(string Name, List<Facultet> facList, List<string> hostel=null)
        {
            this.Name = Name;
            FacultetList = facList;
            Hostel = hostel;
        }


    }
}
