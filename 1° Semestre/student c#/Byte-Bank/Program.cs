using System;

namespace Byte_Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.Write("Entre com o seu nome: ");
                string nome = Console.ReadLine();

                Console.Write("Digite seu cpf: ");
                string cpf = Console.ReadLine();

                Console.Write("Digite seu E-mail: ");
                string email = Console.ReadLine();



                Cliente cliente1 = new Cliente(nome, cpf, email);
                System.Console.WriteLine(cliente1.Senha);
                cliente1.Senha = "";


                bool TrocaSenha = false;
                do
                {
                    System.Console.Write("Senha: ");
                    string senha = Console.ReadLine();
                    TrocaSenha = cliente1.TrocaSenha(senha);
                    if (TrocaSenha)
                    {
                        System.Console.WriteLine("Senha alterada com sucesso !! ");
                    }
                    else
                    {
                        System.Console.WriteLine("Senha invalida");
                    }
                } while (TrocaSenha);
                Console.Clear();




                Console.Write("Digite sua agencia: ");
                int agencia = int.Parse(Console.ReadLine());

                Console.Write("Digite o N° do seu cartão: ");
                int N = int.Parse(Console.ReadLine());

                ContaCorrente conta = new ContaCorrente(cliente1, agencia, N);

                #region 

                Cliente cliente2 = new Cliente("Hebert", "435454545445", "ffefef");
                ContaCorrente contacorrente2 = new ContaCorrente(cliente2, 12, 312);

                Cliente usuario = conta.Titular;
                System.Console.WriteLine("ByteBank- Deposito em Conta");
                System.Console.WriteLine($"Bem Vindo -{usuario.Nome}");
                System.Console.WriteLine($"Agencia {conta.Agencia} Conta: {conta.Numero}");
                System.Console.WriteLine($"Saldo: {conta.Saldo}");
                System.Console.WriteLine();
                System.Console.WriteLine("Digite o valor do depósito");
                double valor = double.Parse(Console.ReadLine());
                do
                {

                    if (valor < 0)
                    {
                        System.Console.WriteLine("Não é possivel efetuar o deposito com esse valor");
                    }
                    else
                    {
                        System.Console.WriteLine("Deposito efetuado com sucesso");
                        System.Console.WriteLine($"Novo saldo: {conta.Saldo}");
                    }
                } while (valor >= 0);

                #endregion

                #region saque

                System.Console.WriteLine("ByteBank- saque");
                System.Console.WriteLine($"Bem Vindo -{usuario.Nome}");
                System.Console.WriteLine($"Agencia {conta.Agencia} Conta: {conta.Numero}");
                System.Console.WriteLine($"Saldo: {conta.Saldo}");
                System.Console.WriteLine();
                System.Console.WriteLine("Digite o valor do saque");
                valor = double.Parse(Console.ReadLine());


                if (valor < 0)
                {
                    System.Console.WriteLine("Você não possui saldo suficiente ");
                }
                else
                {
                    System.Console.WriteLine("Saque efetuado com sucesso");
                    System.Console.WriteLine($"Novo saldo: {conta.Saldo}");
                }


                #endregion

                #region 
                System.Console.WriteLine("ByteBank-  transferencia ");
                System.Console.WriteLine($"Bem Vindo -{usuario.Nome}");
                System.Console.WriteLine($"Agencia {conta.Agencia} Conta: {conta.Numero}");
                System.Console.WriteLine($"Saldo: {conta.Saldo}");
                System.Console.WriteLine($"Saldo destino: {conta.Saldo}");
                System.Console.WriteLine();
                System.Console.WriteLine("Digite o valor da transferencia");
                valor = double.Parse(Console.ReadLine());

                do
                {

                    if (valor < 0)
                    {
                        System.Console.WriteLine("Não é possivel efetuar essa transferencia");
                    }
                    else
                    {
                        if (conta.transferencia(contacorrente2, valor))
                        {
                            System.Console.WriteLine("Transferencia efetuada");
                            System.Console.WriteLine($"Novo saldo: {conta.Saldo}");
                        }
                        else
                        {
                            System.Console.WriteLine("Não foi possivel realizar a operação");
                        }

                    }
                } while (valor > 0);
                #endregion

            }
        }


    }
}
