using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_de_vendas.DAO;
using System.Windows.Forms;

namespace Sistema_de_vendas.Class
{
    class RelatorioCliente : Relatorio
    {
        /*
         * Classe em que implementa o esqueleto para executar os passos especificos
         */
        public override List<ListViewItem> mostrarLista()
        {
            var clientes = ClienteDAO.retornarTudo();
            int i = 1;
            List<ListViewItem> list = new List<ListViewItem>();
            foreach (var cliente in clientes)
            {
                ListViewItem item = new ListViewItem(i++.ToString());
                item.SubItems.Add(cliente.nome);
                item.SubItems.Add(cliente.rg);
                item.SubItems.Add(cliente.cpf);
                item.SubItems.Add(cliente.endereço);
                item.SubItems.Add(cliente.telefone);
                list.Add(item);
            }
            //Retorna a lista dos itens resgatados do banco
            return list;
        }
    }
}
