using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ozone
{
    public class Disease
    {
        public int ID { get; set; }
        public string DiseaseName { get; set; }
        public string ProbablePercent { get; set; }
        public Disease(int i, string s1, string s2)
        {
            ID = i;
            DiseaseName = s1;
            ProbablePercent = s2;
        }
    }
}
