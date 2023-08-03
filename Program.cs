internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();

        var calculator = new Calculator();
        bool runAgain = true;

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("-------------------");
        Console.WriteLine("Calculator Program");
        Console.WriteLine("-------------------\n");
        Console.ResetColor();

        while (runAgain)
        {
            try
            {
                InputNumbers(calculator);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Environment.Exit(0);
            }

            calculator.PrintMenu();
            calculator.Operand = Console.ReadLine();
            var result = calculator.Process(calculator.FirstNumber, calculator.SecondNumber);
            Console.WriteLine($"Your result : {calculator.FirstNumber} {calculator.Operand} {calculator.SecondNumber} = {result}");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Would you like to continue ? ( y = yes , n = no )");
            var answer = Console.ReadLine();
            runAgain = answer.ToLower() == "y";
            Console.ResetColor();
        }
        Console.Clear();

        Console.WriteLine("Bye :)");
    }
    static void InputNumbers(Calculator calculator)
    {
        Console.WriteLine("Enter number1 : ");
        calculator.FirstNumber = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter number2 : ");
        calculator.SecondNumber = Convert.ToInt32(Console.ReadLine());

    }
}
