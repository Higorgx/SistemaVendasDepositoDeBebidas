using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Sistema_de_vendas.DAO;
using System.Windows.Forms;

namespace Sistema_de_vendas.Class
{
    /*
     * Classe em que implementa o esqueleto para executar os passos especificos
     */

    public class RelatorioFornecedor : Relatorio
    {
        public List<ListViewItem> dados { get; set; } = new List<ListViewItem>();

        public override void mostrarLista()
        {
            var fornecedores = FornecedorDao.retornarTudo();
            int i = 1;

            foreach (var fornecedor in fornecedores)
            {
                ListViewItem item = new ListViewItem(i++.ToString());
                item.SubItems.Add(fornecedor.Cnpj);
                item.SubItems.Add(fornecedor.Nome);
                item.SubItems.Add(fornecedor.Endereço);
                item.SubItems.Add(fornecedor.Ramo);
                dados.Add(item);
            }
        }
    }
}
