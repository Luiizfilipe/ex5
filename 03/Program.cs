using System;
using System.Collections.Generic;

class Program {
    static void Main() {
        int[] numeros = new int[20];
        List<int> pares = new List<int>();
        List<int> impares = new List<int>();

        Console.WriteLine("Digite 20 números inteiros: ");
        
        for (int i = 0; i < 20; i++) {
            numeros[i] = int.Parse(Console.ReadLine());
            if (numeros[i] % 2 == 0) {
                pares.Add(numeros[i]);
            } else {
                impares.Add(numeros[i]);
            }
        }

        Console.WriteLine("Vetor original: ");
        Console.WriteLine(string.Join(", ", numeros));
        Console.WriteLine("Pares: ");
        Console.WriteLine(string.Join(", ", pares));
        Console.WriteLine("Ímpares: ");
        Console.WriteLine(string.Join(", ", impares));
    }
}
