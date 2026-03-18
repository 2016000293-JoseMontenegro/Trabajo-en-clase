internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Números Positivos y Negativos");
        //Variables
        int num;
        num = Convert.ToInt32(Console.ReadLine());

        if (num >= 0)
            Console.WriteLine("Soy un número POSITIVO");
        else
            Console.WriteLine("Soy un número NEGATIVO");
    }
}