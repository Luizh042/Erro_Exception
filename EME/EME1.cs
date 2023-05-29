namespace EME;
public class EME1
{
    public static void Main(string[] args)
    {}

    public class MyCustomException : Exception
    {
        public MyCustomException(string message) : base (message){}
    }
    public void MethodThatThrowsException(string arg)
    {
        if (arg == null)
        {
            throw new ArgumentNullException(nameof(arg));
        }

        if (arg.Length > 10)
        {
            throw new MyCustomException("O argumento é muito longo");
        }

        Console.WriteLine("Método executado com sucesso");
    }

}
