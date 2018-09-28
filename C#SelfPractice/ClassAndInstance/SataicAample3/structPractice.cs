using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticSample3
{
    class StructPractice
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Brush.DefaultColor.Red);
            Console.WriteLine(Brush.DefaultColor.Green);
            Console.WriteLine(Brush.DefaultColor.Blue);
        }
        struct Color
        {
            public int Red;
            public int Green;
            public int Blue;
        }

        class Brush
        {
            public static readonly Color DefaultColor;
            //public static readonly Color DefaultColor = new Color() { Red = 0, Green = 0, Blue = 0 };

            static Brush()
            {
             Brush.DefaultColor = new Color() { Red = 0, Green = 0, Blue = 0 };
            }

            /*
             *    Color DefaultColor = new Color();
             *    DefaultColor.Red = 0;
             *    DefaultColor.Green = 0;
             *    DefaultColor.Blue = 0;
             */
        }
    }
}
