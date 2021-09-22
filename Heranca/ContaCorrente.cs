using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    // ':' representa a herança
    public class ContaCorrente : ContaUniversal
    {
        public double Limite { get; private set; }

        //Metodos Construtores
        public ContaCorrente()
        {

        }

        public ContaCorrente(double limite, string nome, int conta) : base(nome, conta)
        {
            Limite = limite;
        }

        public void AumentaLimite(double valor)
        {
            Limite += valor;
        }

    }
}
