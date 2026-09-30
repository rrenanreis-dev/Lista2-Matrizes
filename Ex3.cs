using System;
using MinhaBiblioteca;

class Ex3
{
    static void DiagonalPrincipal(int[,] matriz)
    {
        int linhas = matriz.GetLength(0);
        int cols = matriz.GetLength(1);

        
        if (linhas != cols)
        {
            Console.WriteLine("A matriz precisa ser quadrada (linhas = colunas) para ter diagonal principal.");
            return;
        }

        Console.WriteLine("\n*** Diagonal Principal ***");
        for (int i = 0; i < linhas; i++)
        {
            Console.Write($"{matriz[i, i]} ");
        }
        Console.WriteLine();
    }
    static void Main()
    {
        int n;
            do
            {
                Console.Write("Digite a ordem da matriz quadrada N x N (máximo 100): ");
                n = int.Parse(Console.ReadLine());

                if (n <= 0 || n > 100)
                {
                    Console.WriteLine("Tamanho inválido! A ordem deve estar entre 1 e 100.\n");
                }
            } while (n <= 0 || n > 100);

            int[,] matriz = new int[n, n];

            Biblioteca.GerarMatriz(matriz);

            Biblioteca.mostrarMatriz(matriz);

            DiagonalPrincipal(matriz);
    }
}