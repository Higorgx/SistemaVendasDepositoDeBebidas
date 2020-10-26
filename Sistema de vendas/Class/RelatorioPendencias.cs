using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_de_vendas.DAO;
using System.Windows.Forms;

namespace Sistema_de_vendas.Class
{
    class RelatorioPendencias : Relatorio
    {
        public List<ListViewItem> dados { get; set; } = new List<ListViewItem>();

        public override void mostrarLista()
        {
            var vendas = VendasDAO.buscarNomeCliente("StatusVenda = 'A pagar'");

            int i = 1;

            foreach (var venda in vendas)
            {
                ListViewItem item = new ListViewItem(i++.ToString());
                //item.SubItems.Add(venda.idvendas.ToString());
                item.SubItems.Add(venda.quantidade.ToString());
                item.SubItems.Add(venda.data_compra.ToString());
                item.SubItems.Add(venda.Vencimento.ToString());
                item.SubItems.Add(venda.Nome.ToString());
                dados.Add(item);
            }
        }
    }
}
