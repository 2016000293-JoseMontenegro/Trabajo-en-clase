internal class Program
{
    private static void Main(string[] args)
    {
        double saldo = 1000;
        int intentos = 0;
        int pinCorrecto = 1234;
        int pin; 

        //Validación del PIN
        while (intentos < 3)
        {
            Console.Write("Ingrese su PIN: ");
            if (int.TryParse(Console.ReadLine(), out pin)) //out pin
            {
                if (pin == pinCorrecto)
                {
                    Console.WriteLine("Acceso concedido!!!");

                    int opc = 0;
                    //Menú Principal
                    while (opc != 4) 
                    {
                        Console.WriteLine("===========================");
                        Console.WriteLine("      MENÚ PRINIPAL");
                        Console.WriteLine("1. Consultar Saldo");
                        Console.WriteLine("2. Depositar Dinero Dinero");
                        Console.WriteLine("3. Retirar Dinero");
                        Console.WriteLine("4. Salir");
                        Console.WriteLine("===========================");
                        Console.WriteLine("Digite una Opción: [] ");
                        int.TryParse(Console.ReadLine(), out opc);


                        switch (opc) 
                        {
                            case 1:
                                Console.WriteLine("Su saldo actual es: " + saldo);
                                break;
                            case 2:
                                Console.WriteLine("Ingrese el monto a depositar: ");
                                double deposito;
                                if (double.TryParse(Console.ReadLine(), out deposito) && deposito > 0)
                                {
                                    saldo += deposito;
                                    Console.WriteLine("Depósito exitoso. Su nuevo saldo es: " + saldo);
                                }
                                else
                                {
                                    Console.WriteLine("Monto inválido. Intente nuevamente.");
                                }
                                break;
                            case 3:
                                Console.WriteLine("Ingrese el monto a retirar: ");
                                double retiro;
                                if (double.TryParse(Console.ReadLine(), out retiro) && retiro > 0)
                                {
                                    if (retiro <= saldo)
                                    {
                                        saldo -= retiro;
                                        Console.WriteLine("Retiro exitoso. Su nuevo saldo es: " + saldo);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Fondos insuficientes. Su saldo actual es: " + saldo);
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Monto inválido. Intente nuevamente.");
                                }
                                break;
                            case 4:
                                Console.WriteLine("Gracias por usar el Cajero. ");
                                break;
                            default:
                                Console.WriteLine("Opción Inválida");
                                break;
                        }
                        Console.WriteLine("");
                    }
                    //Finalizar programa
                    return;
                }
                else
                {
                    intentos++;
                    Console.WriteLine("PIN incorrecto. Intente "+intentos+" de 3 \n6");
                }
            }
            else 
            {
               
            }
        }
        Console.WriteLine("Tarjeta bloqueada.\n Demasiados intentos fallidos");
        Console.ReadKey();
    }
}
