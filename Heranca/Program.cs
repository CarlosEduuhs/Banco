using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criem uma classe chamada Banco, com os atributos Nome (string),
            //Conta (int), Saldo (double). Lembrando que o Saldo só pode ser
            //manipulado através de uma classe SET, que recebe um valor de
            //depósito e soma esse valor ao saldo.


             ContaUniversal conta1 = new ContaUniversal();
            Console.WriteLine(conta1.Saldo);
            conta1.Deposito(100);
            Console.WriteLine(conta1.Saldo);

             ContaUniversal conta2 = new ContaUniversal();
            Console.WriteLine("Informe o titular da conta:");
            conta2.Nome = Console.ReadLine();
            Random rand = new Random();
            conta2.Conta = rand.Next(10000,99999);
            Console.WriteLine();
            Console.WriteLine($"Titular: {conta2.Nome}");
            Console.WriteLine($"No. da Conta: {conta2.Conta}");
            Console.WriteLine($"Saldo: {conta2.Saldo}");
            Console.WriteLine("Conta criada com sucesso!!!");
            Console.WriteLine("Informe o valor do deposito inicial: ");
            double valor = double.Parse(Console.ReadLine());
            conta2.Deposito(valor);
            Console.WriteLine();
            Console.WriteLine("Deposito realizado com sucesso!!!");
            Console.WriteLine($"Saldo atualizado: {conta2.Saldo}");
            

            ContaUniversal conta = new ContaUniversal("Edu", 123456);
            conta.DadosDaConta();

            ContaCorrente cc1 = new ContaCorrente(500, "Eduardo", 654321);
            cc1.DadosDaConta();
            cc1.Tipo = Enum.TipoConta.ContaCorrente;

        }
    }
}
