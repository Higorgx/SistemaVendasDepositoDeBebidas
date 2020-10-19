using Sistema_de_vendas.DAO;
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
    public partial class ListVendas : Form
    {
        public ListVendas()
        {
            InitializeComponent();

            /*
             * Inserir Total das vendas com faturamento total
             * e quantidade de vendas, produtos mais vendidos e lucro
             */
            var vendas = VendasDAO.retornarTudo();
            float valor = 0;
            foreach (var venda in vendas)
            {
                valor += (float)venda.Valor;
                listVenda.Rows.Add(venda.id_cliente,venda.id_produto,venda.quantidade,venda.formaPagamento,venda.Valor);
            }
            valorTotVendas.Text = valor.ToString();
            totVendas.Text = vendas.Count.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listVenda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listVenda_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void ListVendas_Load(object sender, EventArgs e)
        {

        }

        private void listVenda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
