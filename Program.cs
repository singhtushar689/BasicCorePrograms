namespace BasicCorePrograms
{
    internal class LeapYear
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Year to Check Whether it is LeapYear or not");
            int year = Convert.ToInt32(Console.ReadLine());
            if((year % 4 == 00 || year % 100 != 0) && (year % 400 == 0))
            {
                Console.WriteLine("It is a leap Year");

            }
            else
            {
                Console.WriteLine("It is not a Leap Year");
            }
            
        }
    }
}