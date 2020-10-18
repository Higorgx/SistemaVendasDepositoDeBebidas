using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_vendas.Modelos
{
    class Vendas
    {
        public int idvendas { get; set; }
        public int id_cliente { get; set; }
        public int id_produto { get; set; }
        public int quantidade { get; set; }
        public DateTime data_compra { get; set; }
        public string formaPagamento { get; set; }
        public DateTime Vencimento { get; set; }
        public string StatusVenda { get; set; }
        public double Valor { get; set; }

    }
}
