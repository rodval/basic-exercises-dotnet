
class Program
{
    static void Main()
    {
        Console.WriteLine("Programa que determina si un numero es par o impar:");

        int numero = 0;
        bool esNumeroValido = false;

        // realizando valiidacion (que el numero sea entero y positivo)
        while (!esNumeroValido)
        {
            string input = Console.ReadLine(); //leyendo por consola

            if (int.TryParse(input, out numero) && numero >= 0)
            {
                esNumeroValido = true;
            }
            else
            {
                Console.WriteLine("Por favor, ingrese un número válido y positivo:");
            }
        }

        // analizando si es par o impar 
        if (EsPar(numero))
        {
            Console.WriteLine($"El número {numero} es par.");
        }
        else
        {
            Console.WriteLine($"El número {numero} es impar.");
        }
    }

    // Función para determinar si un número es par o impar
    static bool EsPar(int numero)
    {
        return numero % 2 == 0;
    }
}