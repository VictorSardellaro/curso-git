using System;
using System.Globalization;
namespace Aula_60 {
    class Conta {

        public int Numero { get; set; }
        private string _nome;
        public double Saldo { get; set; }

        public Conta() {
        }

        public Conta(int numero, string nome, double saldo) {
            Numero = numero;
            _nome = nome;
            Saldo = saldo;
        }

        public string Nome {
            get { return _nome; }
            set {
                if (value != null && value.Length > 1)
                    _nome = value;
            }
        }

        
        public void Deposito(double deposito) {
            Saldo += deposito;
        }
        public void Saque(double saque) {
            Saldo = (saque - Saldo) - 5.00;
        }

        public override string ToString() {
            return
            "Número da conta: "
            + Numero
            + ", Titular: "
            + _nome
            + ", Saldo: "
            + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
