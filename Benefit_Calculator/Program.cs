// See https://aka.ms/new-console-template for more information

using Benefit_Calculator;

double Income;
bool CloseProgram = false;

while (CloseProgram == false)
{
    Console.WriteLine("\n\t**Calculadora de salario mensual líquido a pagar**\n\n");

    try
    {
        Console.Write("\tIngreso mensual: ");
        Income = Convert.ToDouble(Console.ReadLine());

        if (Income > 0)
        {
            var salaryDescription = new Salary(Income);

            Console.WriteLine("\n\tSalario mensual - ${0}", salaryDescription.Income.ToString("N2"));
            Console.WriteLine("\tDescuento de ISSS - ${0}", salaryDescription.ISSS.ToString("N2"));
            Console.WriteLine("\tDescuento de AFP - ${0}", salaryDescription.AFP.ToString("N2"));
            Console.WriteLine("\tDescuento de RENTA - ${0}", salaryDescription.Rent.ToString("N2"));
            Console.WriteLine("\tSalario por pagar - ${0}", salaryDescription.NetSalary.ToString("N2"));

            Console.WriteLine("\n\tSi deseas hacer otro calculo presiona la tecla Y");
            var option = Console.ReadLine();

            CloseProgram = !(option != null && option.ToLower().Equals("y"));

            Console.Clear();
        }
        else
        {
            Console.WriteLine("\n\tDebes ingresar una cantidad valida...");
            Console.ReadKey();
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine("\n\tA ocurrido un error, se reiniciara el programa...\n");
        Console.WriteLine(ex);
    }
}