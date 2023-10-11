using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Matriz Aleatoria
        int[] randomArray = RandomArray();
        Console.WriteLine("Matriz Aleatoria:");
        PrintArray(randomArray);
        Console.WriteLine($"Valor mínimo: {randomArray.Min()}");
        Console.WriteLine($"Valor máximo: {randomArray.Max()}");
        Console.WriteLine($"Suma de valores: {randomArray.Sum()}");

        // Lanzamiento de Moneda
        string coinResult = TossCoin();
        Console.WriteLine("Lanzamiento de Moneda:");
        Console.WriteLine(coinResult);

        // Lanzamiento de Moneda Múltiple (Opcional)
        int numTosses = 10; // Cambia este valor según tus necesidades
        double headRatio = TossMultipleCoins(numTosses);
        Console.WriteLine($"Relación de lanzamientos de cabeza: {headRatio:P}");

        // Nombres
        List<string> names = new List<string> { "Todd", "Tiffany", "Charlie", "Ginebra", "Sydney" };
        List<string> longNames = FilterLongNames(names);
        Console.WriteLine("Nombres más largos de 5 caracteres:");
        foreach (string name in longNames)
        {
            Console.WriteLine(name);
        }
    }

    // Función para crear una matriz de enteros aleatorios
    static int[] RandomArray()
    {
        Random random = new Random();
        int[] array = new int[10];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(5, 26);
        }
        return array;
    }

    // Función para imprimir una matriz de enteros
    static void PrintArray(int[] array)
    {
        foreach (int value in array)
        {
            Console.Write($"{value} ");
        }
        Console.WriteLine();
    }

    // Función para lanzar una moneda y devolver el resultado
    static string TossCoin()
    {
        Console.WriteLine("¡Tirando una moneda!");
        Random random = new Random();
        return random.Next(2) == 0 ? "Cara" : "Cruz";
    }

    // Función para lanzar monedas múltiples y calcular la relación de caras (Opcional)
    static double TossMultipleCoins(int num)
    {
        int headCount = 0;
        Random random = new Random();

        for (int i = 0; i < num; i++)
        {
            if (random.Next(2) == 0)
            {
                headCount++;
            }
        }

        return (double)headCount / num;
    }

    // Función para filtrar nombres de más de 5 caracteres
    static List<string> FilterLongNames(List<string> names)
    {
        return names.Where(name => name.Length > 5).ToList();
    }
}
