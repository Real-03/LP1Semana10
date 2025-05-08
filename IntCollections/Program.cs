using System;
using System.Collections.Generic;
namespace IntCollections
{
    public class Program
    {
        private static void Main(string[] args)
        {
            List<int> lista = new List<int>();
            Stack<int> pilha = new Stack<int>();
            Queue<int> fila = new Queue<int>();
            HashSet<int> conjunto = new HashSet<int>();

        // Valores a inserir
        int[] valores = { 1, 10, -30, 10, -5 };

        // Inserção dos valores nas coleções
        foreach (int valor in valores)
        {
            lista.Add(valor);
            pilha.Push(valor);
            fila.Enqueue(valor);
            conjunto.Add(valor); // HashSet ignora duplicados automaticamente
        }

        // Impressão
        Console.WriteLine("List: " + string.Join(", ", lista));
        Console.WriteLine("Stack: " + string.Join(", ", pilha));
        Console.WriteLine("Queue: " + string.Join(", ", fila));
        Console.WriteLine("HashSet: " + string.Join(", ", conjunto));
        }
    }
}
