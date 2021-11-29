
using System;
using System.Globalization;
namespace primeiro {
    class Conta {
        public string Nome { get; set; }
        public double Saldo { get; private set; }
        public int NumeroConta{ get; private set; }

        
        public Conta(string nome, int numConta) {
            NumeroConta = numConta;
            Nome = nome;
        }
        public Conta(string nome,  int numConta, double saldo): this(nome, numConta){          
            Saldo = saldo;           
        }
        public override string ToString() {
            return "Conta "+ NumeroConta +" , Titular: "+ Nome + 
                   " , Saldo: $" + Saldo.ToString("F2",CultureInfo.InvariantCulture);
        }
        public void Deposito (double quantia){
            Saldo += quantia;
        }

        public void Saque(double quantia) {           
            Saldo -= quantia + 5.0;
        }      
    }
}
