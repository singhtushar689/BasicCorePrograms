namespace BasicCorePrograms
{
    internal class LeapYear
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the terms for Harmonic Nunber");
            int terms = Convert.ToInt32(Console.ReadLine());
            double sum = 0;

            for(double i = 1; i<= terms; i++)
            {
                sum += 1 / i;   
            }
            Console.WriteLine("Sum of {0} terms of Harmonic Number is {1}",terms,sum);
        }
        
    }
}