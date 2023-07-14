namespace Task34
{
    class Program 
    {
        static void Main(string[] args)
        {
            double[] point = GetPoint(new double[] {5, 2}, new double[] {9, 4});
            Console.WriteLine(point[0] + " " + point[1]);
        }

        static double[] GetPoint(double[] firstLine, double[] secondLine)
        {
            double[] point = new double[2];
            if(Math.Abs(firstLine[0] - secondLine[0]) < 0.001)
            {
                if(Math.Abs(firstLine[1] - secondLine[1]) < 0.001)
                {
                    Console.WriteLine("Прямые совпадают");
                    return null;
                }
                Console.WriteLine("Прямые пар-ны");
                return null;
            }
            point[0] = (secondLine[1] - firstLine[1]) / (firstLine[0] - secondLine[0]);
            point[1] = firstLine[0] * point[0] + firstLine[1];
            return point;
        }
    }
}