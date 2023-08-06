internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        Calculator calculator = new Calculator();

        do
        {
            Console.WriteLine("\t------------------ ");
            Console.WriteLine("\tCalculator Program");
            Console.WriteLine("\t------------------");
            try
            {
                setCalculatorOperators(calculator);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Environment.Exit(0);
            }

            calculator.printOptions();
            calculator.Operand = Console.ReadLine();

            try
            {
                var result = calculator.Process();
                Console.WriteLine(calculator);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Would you like to continue ? Y = yes , N = no");

        } while (Console.ReadLine().ToUpper() == "Y");

        Console.Clear();
        Console.WriteLine("Good Bye :)");

    }
    private static void setCalculatorOperators(Calculator calculator)
    {
        Console.WriteLine("Enter number 1 : ");
        calculator.FirstNumber = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter number 2 : ");
        calculator.SecondNumber = Convert.ToDouble(Console.ReadLine());
    }
}
