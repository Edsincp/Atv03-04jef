using System;

class Program
{
    static void Main()
    {
        
        int[,] matriz = new int[5, 5];

        
        PreencherMatriz(matriz);

        
        int negativos = 0;
        int somaPositivos = 0;
        int somaPrimos = 0;

        foreach (int numero in matriz)
        {
            if (numero < 0)
            {
                negativos++;
            }
            else if (numero > 0)
            {
                somaPositivos += numero;

                if (EhPrimo(numero))
                {
                    somaPrimos += numero;
                }
            }
        }

        
        Console.WriteLine($"Quantidade de números negativos: {negativos}");
        Console.WriteLine($"Soma dos números positivos: {somaPositivos}");
        Console.WriteLine($"Soma dos números primos: {somaPrimos}");
    }

    static void PreencherMatriz(int[,] matriz)
    {
        Random random = new Random();

        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                matriz[i, j] = random.Next(-10, 11); 
            }
        }
    }

    static bool EhPrimo(int numero)
    {
        if (numero <= 1)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(numero); i++)
        {
            if (numero % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}
