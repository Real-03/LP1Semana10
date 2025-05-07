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

        // Impressão com foreach
        Console.WriteLine("List:");
        foreach (int v in lista)
            Console.Write(v + " ");
        Console.WriteLine("\n");

        Console.WriteLine("Stack:");
        foreach (int v in pilha)
            Console.Write(v + " ");
        Console.WriteLine("\n");

        Console.WriteLine("Queue:");
        foreach (int v in fila)
            Console.Write(v + " ");
        Console.WriteLine("\n");

        Console.WriteLine("HashSet:");
        foreach (int v in conjunto)
            Console.Write(v + " ");
        Console.WriteLine("\n");
        }
    }
}
