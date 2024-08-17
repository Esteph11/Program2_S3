using EjercicioExcepciones;

Operaciones operaciones = new Operaciones();
int opcion = 0;

do
{
    Console.WriteLine("Seleccione operación matemática:");
    Console.WriteLine("1. Sumar");
    Console.WriteLine("2. Restar");
    Console.WriteLine("3. Multiplicar");
    Console.WriteLine("4. Dividir");
    Console.WriteLine("0. Salir");
    Console.WriteLine();

    opcion = Convert.ToInt16(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            OperacionMatematica(operaciones.Sumar);
            break;
        case 2:
            OperacionMatematica(operaciones.Restar);
            break;
        case 3:
            OperacionMatematica(operaciones.Multiplicar);
            break;
        case 4:
            OperacionMatematica(operaciones.Dividir);
   

        static void OperacionMatematica(Func<double, double, double> operacion)  
        {
        try
        {
            Console.WriteLine();
            Console.WriteLine("Ingrese el primer número:");
            double n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número:");
            double n2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            double resultado = operacion(n1, n2);
            Console.WriteLine($"El resultado es: {resultado}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Por favor ingrese un número válido.");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ha ocurrido un Error: {ex.Message}");
        }
    }

            break;
        default:
            Console.WriteLine("Opción no es válida");
            break;
    }

    Console.WriteLine();
} while (opcion != 0);


