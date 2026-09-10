using System;
using BibliotecaMatriz;

class Ex1
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

        int maior = Matriz.maiorValor(matriz);
        Console.WriteLine($"\nO maior valor da matriz é: {maior}");

        Console.ReadKey();
    }
}
