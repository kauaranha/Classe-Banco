using System;
using ContaCorrente;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
              int opcao;
              opcao = 0;
              

              Conta p1 = new Conta();

            while (opcao != 4)
            {
                Console.WriteLine("1 - Consultar Saldo");
                Console.WriteLine("2 - Depositar Valor");
                Console.WriteLine("3 - Sacar Valor");
                Console.WriteLine("4 - Sair");

                Console.WriteLine("Digite a opção desejada: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        p1.ExibirSaldo();
                        break;
                    case 2:
                        Console.WriteLine("Digite o valor a ser depositado na conta: ");

                        double vrmovimento;
                        vrmovimento  = double.Parse(Console.ReadLine());

                        if(vrmovimento != 0){
                          p1.InsereSaldo(vrmovimento);  
                        } else{
                          Console.WriteLine("Não é possivel depositar valores zerados...");  
                        }
                        break;
                    case 3:

                        Console.WriteLine("Digite o valor a ser sacado da conta: ");

                        double ValorASerRetirado;
                        ValorASerRetirado  = double.Parse(Console.ReadLine());

                        if(ValorASerRetirado != 0){
                          p1.SacaValores(ValorASerRetirado);  
                        } else{
                          Console.WriteLine("Não é possivel sacar valores zerados...");  
                        }
                        break;
                    case 4:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }
        }
    }
}
