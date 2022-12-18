namespace BasicCorePrograms
{
    internal class VowelAndConsonant

    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Character");
            char ch = Convert.ToChar(Console.ReadLine());
            if( (ch == 'a')|| ch == 'e'|| ch =='i' || ch =='o'|| ch == 'u' 
                || ch == 'A'|| ch =='E'|| ch =='I'|| ch == 'O'|| ch =='U')
            {
                Console.WriteLine("It is Vowel");
            }
            else if ((ch>='a' && ch<= 'z') ||(ch >='A' && ch <='Z'))
            {
                Console.WriteLine("It is Consonant");
            }
            else
            {
                Console.WriteLine("Invalid Entry");
            }
        }   
    }
}