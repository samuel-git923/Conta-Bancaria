using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooContaBancaria
{
    public class Cliente
    {
        public Cliente()
        {
            this.Id = 0;
            this.Nome = "";
            this.Cpf = "";
        }

        public int Id { get; set; }
        public String Nome { get; set; }
        public String Cpf { get; set; }
    }
}
