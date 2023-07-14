namespace Task41 
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int count = 0;
            while(int.TryParse(Console.ReadLine(), out a))
            {
                if(a > 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}