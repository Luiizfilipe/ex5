using System;

class Program {
    static void Main() {
        int[] A = new int[10];
        int soma = 0;
        
        Console.WriteLine("Digite 10 números inteiros: ");
        
        for (int i = 0; i < 10; i++) {
            A[i] = int.Parse(Console.ReadLine());
            soma += A[i] * A[i];
        }
        Console.WriteLine($"Soma dos quadrados dos elementos: {soma}");
    }
}
