namespace BasicCorePrograms
{
    internal class FlipCoin
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World! Welcome");
            int headCount = 0;
            int tailCount = 0;
            float headPercentage = 0;
            float tailPercentage = 0;
            Console.WriteLine("Enter the Number of Flips ");
            int flip = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= flip; i++)
            {
                Random random = new Random();
                int flipCheck = random.Next(2);
                if(flipCheck == 0)
                {
                    headCount++;
                    Console.WriteLine("It is Head");
                }
                else
                {
                    tailCount++;
                    Console.WriteLine("It is tail");
                }
            }
            Console.WriteLine("{0} out of {1}", headCount, flip);
            Console.WriteLine("{0} out of {1}", tailCount, flip);
            headPercentage = (headCount * 100) /flip;
            tailPercentage = (tailCount * 100) /flip;
            Console.WriteLine(headPercentage);
            Console.WriteLine(tailPercentage);
        }
    }
}