using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProblem
{
    internal class LineComparisonUC3
    {
        static int x1, x2, y1, y2;
        static double length1, length2;
        public static void getPointCoordinate()
        {
            //Input coordinates of first line
                Console.WriteLine("Enter Co-ordinate for First Line");
                Console.WriteLine("Enter Co-ordinate of First Point.");
                Console.WriteLine("x1 = ");
                x1 = Convert.ToInt32(Console.Read());
                Console.WriteLine("y1 = ");
                y1 = Convert.ToInt32(Console.Read());
            //Input coordinates of second point
                Console.WriteLine("Enter Co-ordinate of Second Point.");
                Console.WriteLine("x2 = ");
                x2 = Convert.ToInt32(Console.Read());
                Console.WriteLine("y2 = ");
                y2 = Convert.ToInt32(Console.Read());
                
                length1 = calculateLineLength();

                //Input coordinates of first line
            Console.WriteLine("Enter Co-ordinate for First Line");
            Console.WriteLine("Enter Co-ordinate of First Point.");
            Console.WriteLine("x1 = ");
            x1 = Convert.ToInt32(Console.Read());
            Console.WriteLine("y1 = ");
            y1 = Convert.ToInt32(Console.Read());
            //Input coordinates of second point
            Console.WriteLine("Enter Co-ordinate of Second Point.");
            Console.WriteLine("x2 = ");
            x2 = Convert.ToInt32(Console.Read());
            Console.WriteLine("y2 = ");
            y2 = Convert.ToInt32(Console.Read());
            
            length2 = calculateLineLength();
            compareLines();
        }
        public static double calculateLineLength()
        {
            //calculate Length of the line
            double length = Math.Sqrt((x2 - x1) ^ 2 + (y2 - y1) ^ 2);
            Console.WriteLine("Length of the line " + length);
            return length;
        }

        public static void compareLines()
        {
            if (length1 > length2)
                Console.WriteLine("Fisrst line is Greater than Second line");
            else if (length1 < length2)
                Console.WriteLine("Second line is Greater than First line");
            else
                Console.WriteLine("Both the lines are Equal");
        }
    }
}