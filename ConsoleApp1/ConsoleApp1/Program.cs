using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor de RGB ");
            Console.Write("R: ");
            float n1 = float.Parse(Console.ReadLine());
            Console.Write("G: ");
            float n2 = float.Parse(Console.ReadLine());
            Console.Write("B: ");
            float n3 = float.Parse(Console.ReadLine());
            RGB color = new RGB(n1, n2, n3);
            CMYK color2 = color.converteCMYK();
            HSV color3 = color.converteHSV();
            Console.WriteLine(color2);
            Console.WriteLine(color3);
            Console.ReadKey();
        }
    }
}
