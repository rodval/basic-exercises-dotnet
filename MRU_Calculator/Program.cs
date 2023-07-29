// See https://aka.ms/new-console-template for more information
Console.WriteLine("Calculadora de Distancia, Velocidad y Tiempo");
Console.WriteLine("Ingrese los valores que conozca y deje los otros dos en blanco.");

Console.Write("Velocidad (m/s): ");
string strVelocidad = Console.ReadLine();
Console.Write("Distancia (m): ");
string strDistancia = Console.ReadLine();
Console.Write("Tiempo (s): ");
string strTiempo = Console.ReadLine();

double velocidad, distancia, tiempo;

if (!string.IsNullOrEmpty(strVelocidad) && !string.IsNullOrEmpty(strDistancia))
{
    // Si se ingresaron velocidad y distancia, calcular tiempo
    velocidad = double.Parse(strVelocidad);
    distancia = double.Parse(strDistancia);
    tiempo = distancia / velocidad;
    Console.WriteLine($"Tiempo: {tiempo} s");
}
else if (!string.IsNullOrEmpty(strVelocidad) && !string.IsNullOrEmpty(strTiempo))
{
    // Si se ingresaron velocidad y tiempo, calcular distancia
    velocidad = double.Parse(strVelocidad);
    tiempo = double.Parse(strTiempo);
    distancia = velocidad * tiempo;
    Console.WriteLine($"Distancia: {distancia} m");
}
else if (!string.IsNullOrEmpty(strDistancia) && !string.IsNullOrEmpty(strTiempo))
{
    // Si se ingresaron distancia y tiempo, calcular velocidad
    distancia = double.Parse(strDistancia);
    tiempo = double.Parse(strTiempo);
    velocidad = distancia / tiempo;
    Console.WriteLine($"Velocidad: {velocidad} m/s");
}
else
{
    Console.WriteLine("Debe ingresar al menos dos valores para realizar el cálculo.");
}

// Agregar pausa para que el usuario pueda ver el resultado antes de cerrar la terminal
Console.WriteLine("Presione Enter para salir...");
Console.ReadLine();