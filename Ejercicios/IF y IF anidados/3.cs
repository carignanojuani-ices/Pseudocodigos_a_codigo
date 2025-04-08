using System;

/*
Clasificación de un número:
- Determina si el número es positivo, negativo o cero.
- Si es positivo y mayor que 100: "Número grande".
- Si es negativo y menor que -100: "Número muy pequeño".
*/

public class Ejercicio3
{
    public void Ejecutar()
    {
        Console.Write("Ingrese un número: ");
        double numero = double.Parse(Console.ReadLine());

        if (numero > 0)
        {
            Console.WriteLine("El número es positivo.");
            if (numero > 100)
            {
                Console.WriteLine("Número grande.");
            }
        }
        else if (numero < 0)
        {
            Console.WriteLine("El número es negativo.");
            if (numero < -100)
            {
                Console.WriteLine("Número muy pequeño.");
            }
        }
        else
        {
            Console.WriteLine("El número es cero.");
        }

        Console.WriteLine("\nPresione enter para salir...");
        Console.ReadLine();
    }
}
