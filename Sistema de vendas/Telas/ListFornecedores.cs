using Sistema_de_vendas.DAO;
using Sistema_de_vendas.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_vendas.Telas
{
    public partial class ListFornecedores : Form
    {
        public ListFornecedores()
        {
            InitializeComponent();

            var items = new RelatorioFornecedor();

            // Chamando o metodo relatório da classe RelatorioFornecedor onde sera executado todos os metodos na ordem informada
            items.relatorio();

            //Listando os itens que estão sendo retornados na lista do RelatórioFornecedor
            foreach(var fornecedor in items.dados)
            {
                listFornecedor.Items.Add(fornecedor);
            }
        }

        private void listFornecedor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
