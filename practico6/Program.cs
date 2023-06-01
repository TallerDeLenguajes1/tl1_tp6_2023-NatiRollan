// See https://aka.ms/new-console-template for more information

int respuesta;
do
{
    Console.WriteLine("------------- MENU ------------------");
    Console.WriteLine("1- Sumar");
    Console.WriteLine("2- Restar");
    Console.WriteLine("3- Multiplicar");
    Console.WriteLine("4- Dividir");
    Console.WriteLine("Seleccione una opcion: ");

    int opcion;
    int.TryParse(Console.ReadLine(), out opcion); //lee un string ingresado por el usuario, convierte a nro entero y almacena el resultado en la variable opcion

    int num1, num2;
    float resultado = 0; //en c# cuando divido 2 nros enteros el resultado se trunca automatica_ a nro entero
                         //si quiero un resultado con decimales, entonces num1 y num2 tienen que ser float
    Console.WriteLine("Ingrese el primer numero: ");
    int.TryParse(Console.ReadLine(), out num1);
    Console.WriteLine("Ingrese el segundo numero: ");
    int.TryParse(Console.ReadLine(), out num2);

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
    
    Console.WriteLine("\nDesea realizar otro calculo? (0=No - 1=Si): ");
    int.TryParse(Console.ReadLine(), out respuesta);

} while (respuesta != 0);