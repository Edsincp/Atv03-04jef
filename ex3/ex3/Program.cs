using System;

class Program
{
    static void Main()
    {
        int[,] matriz = new int[10, 10];
        PreencherMatriz(matriz);

        double mediaDiagonalPrincipal = CalcularMediaDiagonalPrincipal(matriz);
        double mediaDiagonalSecundaria = CalcularMediaDiagonalSecundaria(matriz);

        Console.WriteLine($"Média da diagonal principal: {mediaDiagonalPrincipal}");
        Console.WriteLine($"Média da diagonal secundária: {mediaDiagonalSecundaria}");
    }

    static void PreencherMatriz(int[,] matriz)
    {
        Random random = new Random();
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                matriz[i, j] = random.Next(1, 101); 
            }
        }
    }

    static double CalcularMediaDiagonalPrincipal(int[,] matriz)
    {
        double somaDiagonalPrincipal = 0;
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            somaDiagonalPrincipal += matriz[i, i];
        }
        return somaDiagonalPrincipal / matriz.GetLength(0);
    }

    static double CalcularMediaDiagonalSecundaria(int[,] matriz)
    {
        double somaDiagonalSecundaria = 0;
        int tamanho = matriz.GetLength(0);
        for (int i = 0; i < tamanho; i++)
        {
            somaDiagonalSecundaria += matriz[i, tamanho - 1 - i];
        }
        return somaDiagonalSecundaria / tamanho;
    }
}
