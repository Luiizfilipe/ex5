using System;

class Program {
    static void Main() {
        double[] numeros = new double[10];
        Console.WriteLine("Digite 10 números reais:");
        for (int i = 0; i < 10; i++) {
            numeros[i] = double.Parse(Console.ReadLine());
        }
        Console.WriteLine("Números na ordem inversa:");
        for (int i = 9; i >= 0; i--) {
            Console.WriteLine(numeros[i]);
        }
    }
}
