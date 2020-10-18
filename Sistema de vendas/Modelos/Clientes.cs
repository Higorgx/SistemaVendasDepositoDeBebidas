using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_vendas.Modelos
{
    class Clientes
    {
        public int idcliente { get; set; }
        public string nome { get; set; }
        public string rg { get; set; }

        public string cpf { get; set; }

        public string endereço { get; set;  }
        public string telefone { get; set;  }
    }
}
