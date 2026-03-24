//Un algoritmo que determine si un alumno aprueba o
//reprueba una materia, basado en 
//el promedio de cinco calificaciones.
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("==POMEDIO DE CALIFICACIONES==");
        //Variables
        string materia;
        int n1, n2, n3, n4, n5;
        double promedio;

        //Enviar información al usuario
        Console.Write("Dime la Materia: ");
        materia = Console.ReadLine();
        Console.Write("Dame 5 notas: ");
        n1 = Convert.ToInt32(Console.ReadLine());
        n2 = Convert.ToInt32(Console.ReadLine());
        n3 = Convert.ToInt32(Console.ReadLine());
        n4 = Convert.ToInt32(Console.ReadLine());
        n5 = Convert.ToInt32(Console.ReadLine());
        //Proceso
        promedio = (n1 + n2 + n3 + n4 + n5) / 5;
        //Evaluar si ganó o perdió
        if (promedio >= 70)
            Console.WriteLine("El promedio es "+promedio+ " y el estudiante Aprobó."); //No utilizo llaves porque solo utilizo una línea de código
        else
            Console.WriteLine("El promedio es " + promedio + " y el estudiante Reprobó.");
    }
}