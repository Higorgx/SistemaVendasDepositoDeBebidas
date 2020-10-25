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
        public override List<ListViewItem> mostrarLista()
        {
            var vendas = VendasDAO.buscar("StatusVenda = 'pago'");
            int i = 1;
            List<ListViewItem> list = new List<ListViewItem>();
            foreach (var venda in vendas)
            {
                ListViewItem item = new ListViewItem(i++.ToString());
                item.SubItems.Add(venda.idvendas.ToString());
                item.SubItems.Add(venda.quantidade.ToString());
                item.SubItems.Add(venda.data_compra.ToString());
                item.SubItems.Add(venda.Vencimento.ToString());
                item.SubItems.Add(venda.formaPagamento);
                list.Add(item);
            }
            //Retorna a lista dos itens resgatados do banco
            return list;
        }
    }
}
