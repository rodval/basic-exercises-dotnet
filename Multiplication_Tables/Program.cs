// See https://aka.ms/new-console-template for more information

int Num;
bool CloseProgram = false;

while (CloseProgram == false)
{
    Console.WriteLine("\n\t**Tablas de multiplicacion**\n\n");

    try
    {
        Console.Write("\tQue tabla de multiplicar deseas ver? ");
        Num = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\n");

        if (Num > 0)
        {
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine("\t {0} x {1} = {2}", Num, i, Num * i);
            }

            Console.WriteLine("\n\tSi deseas hacer otro calculo presiona la tecla Y");
            var option = Console.ReadLine();

            CloseProgram = !(option != null && option.ToLower().Equals("y"));

            Console.Clear();
        }
        else
        {
            Console.WriteLine("\n\tDebes ingresar un valor valido...");
            Console.ReadKey();
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine("\n\tA ocurrido un error, se reiniciara el programa...\n");
        Console.WriteLine(ex);
        Console.ReadKey();
        Console.Clear();
    }
}