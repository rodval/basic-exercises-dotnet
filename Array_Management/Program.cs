// See https://aka.ms/new-console-template for more information

/*Desarrollar un programa que solicite ingresar datos, los datos ingresados almacenarlos
en un arreglo y al finalizar mostrarlos en pantalla. El número de datos dependerá de
los que el usuario quiera ingresar.*/

string input = "";

Console.WriteLine("Generador De Array");

List<string> lista_1 = new List<string>();

Console.WriteLine("Ingresa un elemento a tu array:");
Console.WriteLine("para finalizar presiona ENTER");
input = Console.ReadLine();
lista_1.Add(input);

while (input != "")
{
    Console.WriteLine("Ingresa otro elemento a tu array: ");
    input = Console.ReadLine();
    lista_1.Add(input);

}


Console.WriteLine("  Lista Creada");
Console.WriteLine("---------------");
string[] array = lista_1.ToArray();
foreach (string a in array)
    Console.WriteLine(a);
