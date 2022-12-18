namespace BasicCorePrograms
{
    internal class LeapYear
    {
        static void Main(string[] args)
        {
            double number = 2;
            double PowerOf2 = 31;
            double result = 0;

            for(int i = 1; i<= PowerOf2; i++)
            {
                result = Math.Pow(2, i);
                Console.WriteLine(result);
            }
            
            
        }
    }
}