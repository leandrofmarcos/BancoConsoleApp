using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoConsoleApp
{
    public class ContaBancaria
    {
        private string cpf;
        private double saldo;
        private List<string> extrato;
        public DateTime Modified { get; set; }

        public ContaBancaria(string cpf, double saldoInicial)
        {
            this.cpf = cpf;
            this.saldo = saldoInicial;
            this.extrato = new List<string>();

            if(String.IsNullOrEmpty(cpf))
            {
                throw new ArgumentException("Cpf não pode ser vazio.");
            }
        }

        public double Saldo
        {
            get { return saldo; }
        }

        public bool Sacar(double valor)
        {
            if (valor <= 0)
            {
                throw new ArgumentException("O valor do saque deve ser maior que zero.");
            }

            if (valor > saldo)
            {
                throw new InvalidOperationException("Saldo insuficiente para realizar o saque.");
            }

            saldo -= valor;
            extrato.Add($"Saque: -{valor:C2}");
            return true;
        }

        public bool Depositar(double valor)
        {
            if (valor <= 0)
            {
                throw new ArgumentException("O valor do depósito deve ser maior que zero.");
            }

            saldo += valor;
            extrato.Add($"Depósito: +{valor:C2}");
            return true;
        }

        public string ObterExtrato()
        {
            string extratoStr = "Extrato:\n";
            foreach (string operacao in extrato)
            {
                extratoStr += operacao + "\n";
            }
            extratoStr += $"Saldo atual: {saldo:C2}";
            return extratoStr;
        }
    }
}
