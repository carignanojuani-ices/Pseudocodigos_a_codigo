using System;

/*
Cálculo de descuentos en una tienda:
Pide al usuario el monto de su compra.
Si el monto es menor a $100, no hay descuento.
Si el monto está entre $100 y $500, aplica un 10% de descuento.
Si el monto es mayor a $500, aplica un 20% de descuento.
Muestra el precio final después del descuento.
*/

public class EjercicioDescuento
{
    public void Ejecutar()
    {
        Console.Write("Ingrese el monto de su compra: $");
        if (!double.TryParse(Console.ReadLine(), out double monto))
        {
            Console.WriteLine("Monto inválido. Intente nuevamente.");
            return;
        }

        double descuento = 0;

        if (monto >= 100 && monto <= 500)
        {
            descuento = 0.10; // 10%
        }
        else if (monto > 500)
        {
            descuento = 0.20; // 20%
        }

        double montoFinal = monto - (monto * descuento);

        Console.WriteLine($"\nDescuento aplicado: {descuento * 100}%");
        Console.WriteLine($"Monto final a pagar: ${montoFinal:F2}");

        Console.WriteLine("\nPresione enter para salir...");
        Console.ReadLine();
    }
}
