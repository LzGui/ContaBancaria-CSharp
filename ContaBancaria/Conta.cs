using System.Globalization;

namespace ContaBancaria {
    class Conta {
        public int NumeroConta { get; private set; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }

        public Conta(int numeroConta, string nome) {
            NumeroConta = numeroConta;
            Nome = nome;
        }

        public Conta(int numeroConta, string nome, double depositoInicial) : this(numeroConta, nome) {
            Deposito(depositoInicial);
        }
        public void Deposito(double quantia) {
            Saldo += quantia;
        }

        public void Saque(double quantia) {
            Saldo -= quantia + 5.0;
        }
        public override string ToString() {
            return "Conta: "
                + NumeroConta
                + ", Titular: "
                + Nome
                + ", Saldo R$ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}
