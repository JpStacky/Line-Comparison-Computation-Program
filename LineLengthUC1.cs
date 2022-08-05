using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProblem
{
    public static class LineLengthUC1
    {
        static int x1, x2, y1, y2;
        public static void getPointCoordinate()
        {
        //Taking coordinates input for 2 points
        //Input coordinates of first point
            Console.WriteLine("Enetr Co-ordinate for First Point.");
            Console.WriteLine("x1 = ");
            x1 = Convert.ToInt32(Console.Read());
            Console.WriteLine("y1 = ");
            y1 = Convert.ToInt32(Console.Read());
        //Input coordinates of second point
            Console.WriteLine("Enetr Co-ordinate for Second Point.");
            Console.WriteLine("x2 = ");
            x2 = Convert.ToInt32(Console.Read());
            Console.WriteLine("y2 = ");
            y2 = Convert.ToInt32(Console.Read());
            calculateLineLength();
        }
        static void calculateLineLength()
        {
            //calculate Length of the line
            double length = Math.Sqrt((x2 - x1) ^ 2 + (y2 - y1) ^ 2);
            Console.WriteLine("Length of the line " + length);
        }
    }
}
