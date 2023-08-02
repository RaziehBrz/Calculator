class Calculator
{
    public double FirstNumber { get; set; }
    public double SecondNumber { get; set; }
    double _result;
    public string Operand { get; set; }
    public void PrintMenu()
    {
        Console.WriteLine("Options : ");
        Console.WriteLine("\t + : Add");
        Console.WriteLine("\t - : Substract");
        Console.WriteLine("\t * : Multiply");
        Console.WriteLine("\t / : Devide");
        Console.WriteLine("Enter an option : ");
    }
    public double Process(double FirstNumber, double SecondNumber)
    {
        switch (Operand)
        {
            case "+":
                return _result = FirstNumber + SecondNumber;
            case "-":
                return _result = FirstNumber - SecondNumber;
            case "*":
                return _result = FirstNumber * SecondNumber;
            case "/":
                return _result = FirstNumber / SecondNumber;
            default:
                throw new Exception("That was not a valid option");
        }
    }
}