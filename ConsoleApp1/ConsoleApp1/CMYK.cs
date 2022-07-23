using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    class CMYK
    {
        public float C { private get; set; }
        public float M { private get; set; }
        public float Y { private get; set; }
        public float K { private get; set; }

        public CMYK(float c, float m, float y, float k)
        {
            C = c;
            M = m;
            Y = y;
            K = k;
        }

        public override string ToString()
        {
            return "C: "
                + C.ToString("0.000")
                + " "
                + "M: "
                + M.ToString("0.000")
                + " "
                + "Y: "
                + Y.ToString("0.000")
                + " "
                + "K: "
                + K.ToString("0.000");
        }
    }
}
