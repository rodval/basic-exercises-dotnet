// See https://aka.ms/new-console-template for more information

/*Elaborar un programa para calcular el índice de masa corporal de una persona,
utilizando los datos de la estatura (cm) y el peso (kilogramos). Al obtener el resultado,
mostrar la clasificación según los siguientes rangos. */

//decalracion de variable

using System;
//declaracion de variables
double talla = 0;
double peso = 0;
double imc = 0;
double talla_metros = 0;

//reocopilar doatos de usuario
Console.WriteLine("Ingresa tu talla en cm:");
talla = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingresa tu talla en Kg:");
peso = Convert.ToDouble(Console.ReadLine());


// conversion de cm ---> m
talla_metros = talla / 100;

//formula peso (kg) / talla(m) ^2
imc = peso / (talla_metros * talla_metros);

// casos para determinar resultados del IMC

switch (imc)
{
    case double n when (n <= 18.5):

        Console.WriteLine("Tu IMC es de : " + imc + " composicion cormoral es:  PESO INFERIOR AL NORMAL ");
        break;
    case double n when (n >= 18.6 && n <= 24.9):
        Console.WriteLine("Tu IMC es de : " + imc + " composicion cormoral es:  NORMAL ");
        break;
    case double n when (n >= 25.0 && n <= 29.9):
        Console.WriteLine("Tu IMC es de: " + imc + " composicion cormoral es: SUPERIOR AL PESO NORMAL ");
        break;
    case double n when (n >= 30):
        Console.WriteLine("Tu IMC es de : " + imc + "composicion cormoral es:   OBESIDAD ");
        break;

}
