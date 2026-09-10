using System;
using BibliotecaMatriz;

class Ex2
{
    static void Main()
    {
        int linhas, cols;

        Console.Write("Quantidade de linhas: ");
        linhas = int.Parse(Console.ReadLine());
        Console.Write("Quantidade de colunas: ");
        cols = int.Parse(Console.ReadLine());

        int[,] matriz = new int[linhas, cols];

        Matriz.geraMatriz(matriz);
        Console.WriteLine("\nMatriz Gerada:");
        Matriz.mostraMatriz(matriz);

        int menor = Matriz.menorValor(matriz);
        Console.WriteLine($"\nO menor valor da matriz é: {menor}");

        Console.ReadKey();
    }
}
