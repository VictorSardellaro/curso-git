using System;
using System.Globalization;
namespace Aula_60 {
    class Conta {

        public int Numero { get; private set; }
        private string Nome { get; set; }
        public double Saldo { get; private set; }

        public Conta(int numero, string nome) {
            Numero = numero;
            Nome = nome;
        }

        public Conta (int numero, string nome, double saldo) : this (numero, nome) {            
            Saldo = saldo;
        }
        
        public void Deposito(double deposito) {
            Saldo += deposito;
        }
        public void Saque(double saque) {
            Saldo = (Saldo - 5.00) - saque;
        }

        public override string ToString() {
            return
            "Número da conta: "
            + Numero
            + ", Titular: "
            + Nome
            + ", Saldo: $"
            + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}