namespace BasicCorePrograms
{
    internal class GreatestAmongThreeNumbers

    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the First Number");
            int first  = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second Number");
            int second = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Third Number");
            int third = Convert.ToInt32(Console.ReadLine());
            
            if ((first > second) && (first > third))
            {
                Console.WriteLine("{0} is greatest among three number",first);
            }
            else if ((second > first) && (second > third)) 
            {
                Console.WriteLine("{0} is greatest among three number", second);
            }
            else if ((third> second) && (third > first)) 
            {
                Console.WriteLine("{0} is greatest among three number", third);
            }
            else
            {
                Console.WriteLine("Invalid Entry");
            }
        
        
        
        }   
    }
}