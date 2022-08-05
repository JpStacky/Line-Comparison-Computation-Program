namespace LineComparisonProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program");

            //Calling method to compare line lengtn using OOP concept
            LineComparisonUC4 obj = new LineComparisonUC4();
            obj.getPointCoordinate();
            obj.compareLines();
            obj.checkEquality();
        }
    }
}