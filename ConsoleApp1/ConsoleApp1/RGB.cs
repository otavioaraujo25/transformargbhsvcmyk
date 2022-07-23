using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    class RGB
    {
        public float R { private get; set; }
        public float G { private get; set; }
        public float B { private get; set; }

        public RGB(float r, float g, float b)
        {
            R = r;
            G = g;
            B = b;
        }

        public CMYK converteCMYK()
        {
            float r = R / 255;
            float g = G / 255;
            float b = B / 255;

            float K = 1 - Math.Max(Math.Max(r, g), b);
            float C = (1 - r - K) / (1 - K);
            float M = (1 - g - K) / (1 - K);
            float Y = (1 - b - K) / (1 - K);
            return new CMYK(C, M, Y, K);
        }

        public HSV converteHSV()
        {
            float r = R / 255;
            float g = G / 255;
            float b = B / 255;
            float Max = Math.Max(Math.Max(r, g), b);
            float Min = Math.Min(Math.Min(r, g), b);
            float H = 0;
            float S = 0;
            if (Max == r && g >= b)
            {
                H = 60 * ((g - b) / (Max - Min));
            }
            if (Max == r && g < b)
            {
                H = 60 * ((g - b) / (Max - Min)) + 360;
            }
            if (Max == g)
            {
                H = 60 * ((b - r) / (Max - Min)) + 120;
            }
            if (Max == b)
            {
                H = 60 * ((r - g) / (Max - Min)) + 240;
            }
            if (Max != 0)
            {
                S = 1 - (Min / Max);
            }
            else
            {
                S = 0;
            }
            float V = Max;
            return new HSV(H, S, V);
        }
    }
}
