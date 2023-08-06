class Calculator
{
    public double FirstNumber { get; set; }
    public double SecondNumber { get; set; }
    string _operand;
    double _result;
    public string Operand
    {
        set
        {
            if (value == "+" ||
             value == "-" ||
             value == "*" ||
             value == "/")
            {
                _operand = value;
            }
        }
    }
    public void printOptions()
    {
        Console.WriteLine("Options : ");
        Console.WriteLine("\t + : Add");
        Console.WriteLine("\t - : Substract");
        Console.WriteLine("\t * : Multiply");
        Console.WriteLine("\t / : Devide");
        Console.WriteLine("Enter an Option : ");
    }
    public double Process()
    {
        switch (_operand)
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
    public override string ToString()
    {
        return $"Your result : {FirstNumber} {_operand} {SecondNumber} = {_result}";
    }
}