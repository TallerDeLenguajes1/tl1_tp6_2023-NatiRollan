// See https://aka.ms/new-console-template for more information

int respuesta;

do
{
    Console.WriteLine("------------- MENU ------------------");
    Console.WriteLine("1- Sumar");
    Console.WriteLine("2- Restar");
    Console.WriteLine("3- Multiplicar");
    Console.WriteLine("4- Dividir");
    Console.WriteLine("5- Otras operaciones");
    Console.WriteLine("Seleccione una opcion: ");

    int opcion;
    int.TryParse(Console.ReadLine(), out opcion); //lee un string ingresado por el usuario, convierte a nro entero y almacena el resultado en la variable opcion

    float num, num1, num2;
    float resultado = 0; //en c# cuando divido 2 nros enteros el resultado se trunca automatica_ a nro entero
                         //si quiero un resultado con decimales, entonces num1 y num2 tienen que ser float
    
    if (opcion == 5)
    {
        Console.WriteLine("Ingrese un numero: ");
        float.TryParse(Console.ReadLine(), out num);

        Console.WriteLine("Numero: " + num);
        Console.WriteLine("Valor Absoluto: " + Math.Abs(num));
        Console.WriteLine("Cuadradro: " + Math.Pow(num, 2));
        if (num >= 0)
        {
            Console.WriteLine("Raiz cuadrada: " + Math.Sqrt(num));
        }else
        {
            Console.WriteLine("Raiz cuadrada: No se puede obtener");
        }
        Console.WriteLine("Seno: " + (float)Math.Sin(num));
        Console.WriteLine("Coseno: " + (float)Math.Cos(num));
        Console.WriteLine("Parte entera de un tipo float: " + (int)num);
    } else
    {
        Console.WriteLine("Ingrese el primer numero: ");
        float.TryParse(Console.ReadLine(), out num1);
        Console.WriteLine("Ingrese el segundo numero: ");
        float.TryParse(Console.ReadLine(), out num2);

        switch (opcion)
        {
            case 1:
                resultado = num1 + num2;
                Console.WriteLine("El resultado es: " + resultado);
            break;
            case 2:
                resultado = num1 - num2;
                Console.WriteLine("El resultado es: " + resultado);
            break;
            case 3:
                resultado = num1 * num2;
                Console.WriteLine("El resultado es: " + resultado);
            break;
            case 4:
                if (num2 != 0)
                {
                    resultado = num1 / num2;
                    Console.WriteLine("El resultado es: " + resultado);
                } else
                {
                    Console.WriteLine("Error");
                }
            break;   
        }

        if (num1 > num2)
        {
            Console.WriteLine("El maximo numero es: " + num1);
            Console.WriteLine("El minimo numero es: " + num2);
        } else
        {
            Console.WriteLine("El maximo numero es: " + num2);
            Console.WriteLine("El minimo numero es: " + num1);
        }
    }
    
    Console.WriteLine("\nDesea realizar otro calculo? (0=No - 1=Si): ");
    int.TryParse(Console.ReadLine(), out respuesta);

} while (respuesta != 0);
   
