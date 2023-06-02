// See https://aka.ms/new-console-template for more information

//------------------------------------Ejercicio 4-------------------------------------------
//Primera cadena
string? cadena = "";

Console.WriteLine("Ingrese una palabra: ");
cadena = Console.ReadLine(); 

//Longitud primera cadena
int longitud = cadena.Length;

Console.WriteLine("La longitud de la cadena es: " + longitud);

//Segunda cadena
string? cadena2 = "";

Console.WriteLine("Ingrese otra palabra: ");
cadena2 = Console.ReadLine();

//Concatenar ambas cadenas distintas
string? concatenar = "";

concatenar = cadena + ' ' + cadena2;
Console.WriteLine("Cadenas concatenadas: " + concatenar);

//Extraer una subcadena de la cadena ingresada
int indiceInicial, longitudSubcadena;
Console.WriteLine("Ingrese el índice inicial para la subcadena: ");
int.TryParse(Console.ReadLine(), out indiceInicial);

Console.WriteLine("Ingrese la longitud de la subcadena:");
int.TryParse(Console.ReadLine(), out longitudSubcadena);

if ((indiceInicial + longitudSubcadena) <= longitud)
{
    string subcadena = cadena.Substring(indiceInicial, longitudSubcadena);
    Console.WriteLine("La subcadena extraída es: " + subcadena);
} else
{
    Console.WriteLine("No se puede extraer una subcadena");
}
    

//Realizar operaciones con la calculadora??

//Recorrer la cadena con un ciclo Foreach
Console.WriteLine("Recorro la cadena de texto: ");
foreach (char caracter in cadena)
{
    Console.WriteLine(caracter);
}

//Buscar la ocurrencia de una palabra determinada en la cadena ingresada
string? palabraBuscada = "";
Console.WriteLine("Ingrese la palabra que quiere buscar: ");
palabraBuscada = Console.ReadLine();

bool palabraEncontrada = cadena.Contains(palabraBuscada); //Devuelve T o F que indica si una subcadena especificada aparece o no dentro de esta cadena
if (palabraEncontrada)
{
     Console.WriteLine("La palabra '" + palabraBuscada + "' se encuentra en la cadena.");
}
else
{
    Console.WriteLine("La palabra '" + palabraBuscada + "' no se encuentra en la cadena.");
}

//Convertir la cadena a mayúsculas y luego a minúsculas
Console.WriteLine("Cadena en mayusculas: " + cadena.ToUpper());
Console.WriteLine("Cadena en minuscula: " + cadena.ToLower());

//Cadena separada por caracteres
string? cadenaSeparada = "";
Console.WriteLine("Ingrese una cadena separada por caracteres: ");
cadenaSeparada = Console.ReadLine();

string[] subcadenas = cadenaSeparada.Split(' ');

Console.WriteLine("Subcadenas: ");
foreach (string resultado in subcadenas)
{
    Console.WriteLine(resultado);
}
