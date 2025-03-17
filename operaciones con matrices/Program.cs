using System;
/*class Program
{
    static int[,] CrearMatriz(int N)
    {
        int[,] matriz = new int[N, N];
        for (int i = 0; i < N; i++) //filas N-1
        {
            for (int j = 0; j < N; j++) //columnas
            {
                matriz[i, j] = i + j;
            }
        }
        return matriz;
    }

    static void MostrarMatriz(int[,] matriz)
    {
        int N = matriz.GetLength(0);
        int maxNumber = matriz[N - 1, N - 1];
        int maxLength = maxNumber.ToString().Length; 
        for (int i = 0; i < N; i++) //filas
        {
            for (int j = 0; j < N; j++) //columnas
            {
                Console.Write(matriz[i, j].ToString().PadRight(maxLength + 1));
            }
            Console.WriteLine();
        }
    }

    // tirangulo inferior
    static void MostrarTriangularInferior(int[,] matriz)
    {
        int N = matriz.GetLength(0); //# de filas
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j <= i; j++) //solo toma los valores de j<=i
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    // interfaz de interaccion
    static void Main(string[] args)
    {
        Console.Write("Ingresa el orden de la matriz (N): ");
        int N = int.Parse(Console.ReadLine()); 

        // Crear la matriz
        int[,] matriz = CrearMatriz(N);

        // la imprime
        Console.WriteLine("\nMatriz original:");
        MostrarMatriz(matriz);

        // imprime el triangulo
        Console.WriteLine("\nTriangular inferior:");
        MostrarTriangularInferior(matriz);
    }
}*/

//punto 34

public class MatrizRelojArena
{
    public static void Main(string[] args)
    {
        Console.Write("Ingrese el orden de la matriz (N): ");
        int n = int.Parse(Console.ReadLine());

        if (n % 2 == 0)
        {
            Console.WriteLine("El orden de la matriz debe ser un número impar.");
            return;
        }

        int[,] matriz = new int[n, n];

       
        LlenarMatriz(matriz);

       //matriz completa
        Console.WriteLine("\nMATRIZ COMPLETA");
        ImprimirMatriz(matriz);

        // Figura del reloj de arena
        Console.WriteLine("\nRELOJ DE ARENA");
        ImprimirRelojArena(matriz);
    }

    public static void LlenarMatriz(int[,] matriz)
    {
        int n = matriz.GetLength(0);
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matriz[i, j] = i * 2 + j;
            }
        }
    }

    public static void ImprimirMatriz(int[,] matriz)
    {
        int n = matriz.GetLength(0);
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            { 
                Console.Write(matriz[i, j].ToString().PadRight(3));
            }
            Console.WriteLine();
        }
    }

    public static void ImprimirRelojArena(int[,] matriz)
    {
        int n = matriz.GetLength(0);
        int mitad = n / 2;

        // Parte superior del reloj de arena
        for (int i = 0; i <= mitad; i++)
        {
            for (int k = 0; k < i; k++)
            {
                Console.Write("   ");
            }
            for (int j = i; j < n - i; j++)
            {
               
                Console.Write(matriz[i, j].ToString().PadRight(3));
            }
            Console.WriteLine();
        }

        // Parte inferior del reloj de arena
        for (int i = mitad + 1; i < n; i++)
        {
            for (int k = 0; k < n - i - 1; k++)
            {
                Console.Write("   ");
            }
            for (int j = n - i - 1; j <= i; j++)
            {
               
                Console.Write(matriz[i, j].ToString().PadRight(3));
            }
            Console.WriteLine();
        }
    }
}
