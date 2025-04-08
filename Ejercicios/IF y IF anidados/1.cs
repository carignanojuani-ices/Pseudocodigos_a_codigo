using System;

/*
Verificación de edad para votar:
Pide la edad de una persona y determina si puede votar.
- Si la edad es menor de 18: "No puedes votar".
- Si tiene 18 o más: "Puedes votar".
- Si tiene más de 70 años: "Puedes votar, pero no es obligatorio".
*/

public class Ejercicio1
{
    public void Ejecutar()
    {
        int edad;

        Console.WriteLine("Ingrese una edad (0 para salir):");

        while (int.TryParse(Console.ReadLine(), out edad) && edad > 0)
        {
            if (edad < 18)
            {
                Console.WriteLine($"No puedes votar. La edad de la persona es: {edad}");
            }
            else if (edad >= 18 && edad <= 70)
            {
                Console.WriteLine($"Puedes votar. La edad de la persona es: {edad}");
            }
            else // edad > 70
            {
                Console.WriteLine($"Puedes votar, pero es opcional. La edad de la persona es: {edad}");
            }

            Console.WriteLine("\nIngrese una nueva edad (0 para salir):");
        }

        Console.WriteLine("Programa finalizado.");
        Console.WriteLine("\nPresione enter para salir...");
        Console.ReadLine();
    }
}
