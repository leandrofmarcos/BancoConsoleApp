using BancoConsoleApp;

namespace Banco.BancoConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ContaBancaria minhaConta = new ContaBancaria("12345678901", 1000.00);

            bool sair = false;
            while (!sair)
            {
                Console.WriteLine("======= Menu =======");
                Console.WriteLine("1. Saldo");
                Console.WriteLine("2. Sacar");
                Console.WriteLine("3. Depositar");
                Console.WriteLine("4. Extrato");
                Console.WriteLine("0. Sair");
                Console.WriteLine("=====================");
                Console.Write("Escolha uma opção: ");

                string opcaoStr = Console.ReadLine();
                int opcao;
                if (int.TryParse(opcaoStr, out opcao))
                {
                    try
                    {
                        switch (opcao)
                        {
                            case 1:
                                double saldo = minhaConta.Saldo;
                                Console.WriteLine($"Saldo atual: {saldo:C2}");
                                break;
                            case 2:
                                Console.Write("Digite o valor para sacar: ");
                                string valorSaqueStr = Console.ReadLine();
                                double valorSaque;
                                if (double.TryParse(valorSaqueStr, out valorSaque))
                                {
                                    bool saqueRealizado = minhaConta.Sacar(valorSaque);
                                    if (saqueRealizado)
                                    {
                                        Console.WriteLine($"Saque de {valorSaque:C2} realizado com sucesso.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Não foi possível realizar o saque.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Valor inválido.");
                                }
                                break;
                            case 3:
                                Console.Write("Digite o valor para depositar: ");
                                string valorDepositoStr = Console.ReadLine();
                                double valorDeposito;
                                if (double.TryParse(valorDepositoStr, out valorDeposito))
                                {
                                    bool depositoRealizado = minhaConta.Depositar(valorDeposito);
                                    if (depositoRealizado)
                                    {
                                        Console.WriteLine($"Depósito de {valorDeposito:C2} realizado com sucesso.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Não foi possível realizar o depósito.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Valor inválido.");
                                }
                                break;
                            case 4:
                                string extrato = minhaConta.ObterExtrato();
                                Console.WriteLine(extrato);
                                break;
                            case 0:
                                sair = true;
                                Console.WriteLine("Programa encerrado.");
                                break;
                            default:
                                Console.WriteLine("Opção inválida.");
                                break;
                        }
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine($"Erro: {ex.Message}");
                    }
                    catch (InvalidOperationException ex)
                    {
                        Console.WriteLine($"Erro: {ex.Message}");
                    }
                }
                else
                {
                    Console.WriteLine("Opção inválida.");
                }

                Console.WriteLine();
            }
        }
    }
}