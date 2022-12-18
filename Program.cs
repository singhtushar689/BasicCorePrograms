namespace BasicCorePrograms
{
    internal class LeapYear
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Nunber");
            int number = Convert.ToInt32(Console.ReadLine());
            int factor = 0;
            for(int i = 2; i < number/2; i++)
            {
                if(number % i == 0)
                {
                    Console.WriteLine("Number is divisible by {0} ",i);
                }
            }
        }
        
    }
}