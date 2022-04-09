using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooContaBancaria
{
    public class ContaBancaria
    {
        public Cliente Correntista { get; set; }
        public ContaBancaria()
        {
            this.saldo = 0;
            this.Correntista = new Cliente();
        }

        protected Double saldo;

        public Double Saldo
        {
            get 
            {
                return saldo;
            }
        }

        public void Depositar(Double valor)
        {
            this.saldo += valor;
        }

        public virtual Double Retirar(Double valor)
        {
            //retira apenas se tiver saldo
            if (this.Saldo >= valor)
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
    }
}
