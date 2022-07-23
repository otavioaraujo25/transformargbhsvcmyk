﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class HSV
    {
        public float H { private get; set; }
        public float S { private get; set; }
        public float V { private get; set; }

        public HSV(float h, float s, float v)
        {
            H = h;
            S = s;
            V = v;
        }

        public override string ToString()
        {
            return "H: "
                + H.ToString("0.000")
                + " "
                + "S: "
                + S.ToString("0.000")
                + " "
                + "V: "
                + V.ToString("0.000");
        }
    }
}
