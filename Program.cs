using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooContaBancaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaEstudante conta = new ContaEstudante();
            conta.Correntista.Nome = "Samuel Bacellar";
            int menu = 0;
            while(menu != 3)
            {
                Console.WriteLine("Menu de opções");
                Console.WriteLine("1 - Exibir Dados do correntista");
                Console.WriteLine("2 - Depositar");
                Console.WriteLine("3 - Retirar");
                Console.WriteLine("4 - Sair");
                Console.Write("Opção: ");
                menu = Convert.ToInt32(Console.ReadLine());

                if (menu == 1)
                {
                    conta.ExibirDadosBancarios();
                }

                if (menu == 2)
                {
                    try
                    {
                        Console.WriteLine("Valor para depósito: ");
                        Double valor = Convert.ToDouble(Console.ReadLine());
                        conta.Depositar(valor);
                        Console.WriteLine("Saldo atual: " + conta.Saldo);
                    }
                    catch (Exception erro)
                    {
                        Console.WriteLine("Ops!!! Algo deu errado.");
                        Console.WriteLine("Error: " + erro.Message);
                    }

                }

                if (menu == 3)
                {
                    try
                    {
                        Console.WriteLine("Valor para retirada: ");
                        Double valor = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Saldo restante: " + conta.Retirar(valor));
                    }
                    catch (Exception erro)
                    {
                        Console.WriteLine("Ops!!! Algo deu errado.");
                        Console.WriteLine("Error: " + erro.Message);
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
