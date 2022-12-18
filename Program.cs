namespace BasicCorePrograms
{
    internal class LeapYear
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Dividend");
            int dividend = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Divisor");
            int divisor = Convert.ToInt32(Console.ReadLine());

            int quotient = dividend / divisor;
            int remainder = dividend % divisor;
            Console.WriteLine("Quotient for the Given Number is {0}",quotient);
            Console.WriteLine("Remainder for the Given Number is {0}",remainder);   
        }   
    }
}