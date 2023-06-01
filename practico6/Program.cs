// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Hello, World!");

int a;
int b;
a=10;
b=a;
Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:"+b);*/

int intNum1=0;
string? numString= "";
Console.WriteLine("Ingrese un numero: ");
numString = Console.ReadLine();
if (int.TryParse(numString, out intNum1))
{
    if (intNum1 > 0)
    {
        string? numAux = "";
        while (intNum1 != 0)
        {
            int digito = intNum1 % 10;
            numAux = numAux + digito.ToString();
            intNum1 /= 10;
        }
        Console.WriteLine("El numero invertido es: " + numAux);
    } else
    {
        Console.WriteLine("El texto ingresado no es mayor a 0");
    }

} else
{
    Console.WriteLine("El texto ingresado no es un numero");
}
