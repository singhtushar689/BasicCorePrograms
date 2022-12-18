namespace BasicCorePrograms
{
    internal class SwapNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first Number");
            int firstNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second Number");
            int secondNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Before swapping firstNumber and secondNumber are {0} and {1}",firstNum ,secondNum);

            firstNum = firstNum * secondNum;
            secondNum = firstNum / secondNum;
            firstNum = firstNum / secondNum;
            Console.WriteLine("After swapping firstNumber  and secondNumber are {0} and {1}",firstNum, secondNum);

        }   
    }
}