using System;
using System.Globalization;
using primeiro;

namespace Primeiro {
    class Program {

        static void Main(string[] args) {
            Conta contaBancaria;
            double valDepositoInicial;
           
            Console.Write("Entre o número da conta: ");
            int numConta = int.Parse(Console.ReadLine());
            
            Console.Write("Entre o Titular da conta: ");
            string nome = Console.ReadLine();
            
            Console.Write("Haverá depósito inicial (s/n)? ");
            char questDeposito = char.Parse(Console.ReadLine());
            if (questDeposito == 's') {
                Console.Write("Entre o valor de depósito inicial: ");
                valDepositoInicial = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                contaBancaria = new Conta(nome, numConta, valDepositoInicial);
            }
            else {
                contaBancaria = new Conta(nome, numConta);
            }
            
            Console.WriteLine();
            Console.WriteLine("Dados da Conta:");
            Console.WriteLine(contaBancaria);

            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            contaBancaria.Deposito(quantia);
            
            Console.WriteLine("Dados da Conta atualizados: ");
            Console.WriteLine(contaBancaria);

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            quantia = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            contaBancaria.Saque(quantia);

            Console.WriteLine();
            Console.WriteLine("Dados da Conta atualizados: ");
            Console.WriteLine(contaBancaria);
        }
    }
}