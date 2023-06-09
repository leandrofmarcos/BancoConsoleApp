using BancoConsoleApp;

namespace BancoConsole.Test
{
    [TestFixture]
    public class ContaBancariaTest
    {
        [Test]
        public void SaldoInicial_DeveRetornarSaldoInicialCorreot()
        {
            //Arrange
            double saldoInicial = 1000.0;
            ContaBancaria conta = new ContaBancaria("12345789", saldoInicial);

            //Act
            double saldo = conta.Saldo;

            Assert.AreEqual(saldoInicial, saldo);
        }

        [Test]
        public void SacarValorMaiorQueSaldo_DisparaExcecao()
        {
            //Arrange
            double saldoInicial = 1000.00;
            ContaBancaria conta = new ContaBancaria("1234", saldoInicial);
            double valorSaque = 1500.00;

            Assert.Throws<InvalidOperationException>(() => conta.Sacar(valorSaque));
        }

        [Test]
        public void Sacar_ValorIgualAoSaldo_RetornaVerdadeiro()
        {
            //Arrange
            double saldoInicial = 1000.0;
            var conta = new ContaBancaria("12345678901", saldoInicial);
            double valorSaque = saldoInicial;

            //Act
            bool saqueRealizado = conta.Sacar(valorSaque);

            Assert.IsTrue(saqueRealizado);
        }

        [Test]
        public void Sacar_ValorMenorQueSaldo_RetornaVerdadeiro()
        {

            //Arrange
            double saldoInicial = 1000.00;
            var conta = new ContaBancaria("12345678901", saldoInicial);
            double valorSaque = 500.00;

            //Act
            bool saqueRealizado = conta.Sacar(valorSaque);

            Assert.IsTrue(saqueRealizado);
        }

        [Test]
        public void Depositar_ValorMaiorQueZero_RetornaVerdadeiro()
        {
            //Arrange
            double saldoInicial = 1000.0;
            var conta = new ContaBancaria("12345678901", saldoInicial);
            double valorDeposito = 500.0;

            //Act
            bool depositoRealizado = conta.Depositar(valorDeposito);

            //Assert
            Assert.IsTrue(depositoRealizado);

        }

        [Test]
        public void Depositar_ValorIgualAZero_DisparaExcecao()
        {
            double saldoInicial = 1000.0;
            var conta = new ContaBancaria("12345678901", saldoInicial);
            double valorDeposito = 0.0;

            //Act/Assert
            Assert.Throws<ArgumentException>(() => conta.Depositar(valorDeposito));
        }

        [Test]
        public void ObterExtrato_DeveRetornarExtratoCorretoAposSaque()
        {
            //arrange
            double saldoInicial = 1000.0;
            var conta = new ContaBancaria("12345678901", saldoInicial);
            double valorSaque = 500.0;
            double valorDeposito = 200.0;

            //act
            conta.Sacar(valorSaque);
            conta.Depositar(valorDeposito);
            string extrato = conta.ObterExtrato();

            StringAssert.Contains("Saque: -$500.00", extrato);
            StringAssert.Contains("Depósito: +$200.00", extrato);
            StringAssert.Contains("Saldo atual: $700.00", extrato);
        }

        [Test]
        public void Sacar_SaldoAtualizadoAposSaque()
        {
            //Arrange
            double saldoInicial = 1000.00;
            var conta = new ContaBancaria("12345678901", saldoInicial);
            double valorSaque = 500.00;

            //act
            conta.Sacar(valorSaque);
            double saldoAtual = conta.Saldo;

            //assert
            Assert.AreEqual(saldoInicial - valorSaque, saldoAtual);
        }

        [Test]
        public void Depositar_SaldoAtualizadoAposDeposito()
        {
            //arrange
            double saldoInicial = 1000.00;
            var conta = new ContaBancaria("12345678901", saldoInicial);
            double valorDeposito = 200.00;

            //act
            conta.Depositar(valorDeposito);
            double saldoAtual = conta.Saldo;

            //assert
            Assert.AreEqual(saldoInicial + valorDeposito, saldoAtual);
        }

        [Test]
        public void Construtor_DeveLancarExcecaoAoReceberCpfVazio()
        {
            //arrange
            string cpf = "";
            double saldoInicial = 1000.00;

            //act/arrange
            Assert.Throws<ArgumentException>(() => { new ContaBancaria(cpf, saldoInicial); });
        }
    }
}