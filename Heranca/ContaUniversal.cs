using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    public class ContaUniversal
    {
        public string Nome { get; set; }
        public int Conta { get; set; }
        public double Saldo { get; private set; }
        public Enum.TipoConta Tipo { get; set; }



        //Metodos construtores
        public ContaUniversal()
        {
        }

        public ContaUniversal(string nome, int conta)
        {
            Nome = nome;
            Conta = conta;
            Saldo = 0;
        }

        //Metodo
        public void Deposito(double valor)
        {
            Saldo += valor;
        }

        public void DadosDaConta()
        {
            Console.WriteLine($"Titular: {Nome}");
            Console.WriteLine($"No Conta: {Conta}");
            Console.WriteLine($"Saldo: {Saldo}");
        }

    }
}
