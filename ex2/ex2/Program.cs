using System;

class Program
{
    static void Main()
    {
        
        int[,] matriz = new int[2, 4];

        
        PreencherMatriz(matriz);

        
        int[] quantidades = new int[2];
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                if (matriz[i, j] >= 12 && matriz[i, j] <= 20)
                {
                    quantidades[i]++;
                }
            }
        }

        
        for (int i = 0; i < quantidades.Length; i++)
        {
            Console.WriteLine($"Quantidade de elementos entre 12 e 20 na linha {i + 1}: {quantidades[i]}");
        }

        
        double somaPares = 0;
        int contadorPares = 0;
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                if (matriz[i, j] % 2 == 0)
                {
                    somaPares += matriz[i, j];
                    contadorPares++;
                }
            }
        }

        double mediaPares = contadorPares > 0 ? somaPares / contadorPares : 0;

        
        Console.WriteLine($"Média dos elementos pares da matriz: {mediaPares}");
    }

    static void PreencherMatriz(int[,] matriz)
    {
        Random random = new Random();

        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                matriz[i, j] = random.Next(1, 31); 
            }
        }
    }
}
