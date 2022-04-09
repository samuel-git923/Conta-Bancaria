using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooContaBancaria
{
    public class ContaEstudante : ContaBancaria
    {

        public ContaEstudante() : base()
        {
            this.limite = 500;
        }

        private Double limite;
        public Double Limite
        {
            get
            {
                return this.Limite;
            }
        }

        public override Double Retirar(Double valor)
        {
            //retira apenas se tiver saldo
            if (this.saldo + this.limite >= valor)
            {
                this.saldo -= valor;
            }
            else
            {
                //error ao sacar
                throw new Exception("Saldo insuficiente!");
            }
            return this.saldo;
        }

        public void ExibirDadosBancarios()
        {
            Console.WriteLine("Dados do correntista: " + this.Correntista.Nome);
            Console.WriteLine("Saldo: " + this.Saldo);
            Console.WriteLine("Limite: " + this.Limite);
        }
    }
}
