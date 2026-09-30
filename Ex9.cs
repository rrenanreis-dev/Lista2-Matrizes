using System;
using MinhaBiblioteca;

class Ex9
{
    static void CalcularForcaRegioes(int[,] matriz)
    {
        int linhas = matriz.GetLength(0);
        int cols = matriz.GetLength(1);

        Console.WriteLine("\nForça Total das Regiões:");

        for (int i = 0; i < linhas; i++)
        {
            int somaregiao = 0;
            for (int j = 0; j < cols; j++)
            {
                somaregiao += matriz[i, j]; 
            }
            Console.WriteLine($"Região {i + 1}: {somaregiao} tropas");
        }
    }
    static void Main()
    {
        Console.Write("Digite o número de linhas: ");
        int r = int.Parse(Console.ReadLine());
        Console.Write("Digite o número de cidades por região (colunas): ");
        int c = int.Parse(Console.ReadLine());
        int[,] tropas = new int[r, c];
        Biblioteca.GerarMatriz(tropas);
        Biblioteca.mostrarMatriz(tropas);
        CalcularForcaRegioes(tropas);
    }
}