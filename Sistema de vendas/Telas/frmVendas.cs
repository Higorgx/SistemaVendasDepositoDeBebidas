using Sistema_de_vendas.DAO;
using Sistema_de_vendas.Modelos;
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
    public partial class frmVendas : Form
    {
        //List<Cliente> Cliente = new List<Cliente>();
        List<Produto> Produtos = new List<Produto>();

        public frmVendas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vendas Venda = new Vendas();
            Venda.id_cliente = Convert.ToInt32(txtIdcliente.Text);
            Venda.id_produto = Convert.ToInt32(txtIdproduto.Text);
            Venda.quantidade = Convert.ToInt32(txtQtde.Text);
            Venda.Vencimento = Convert.ToDateTime(txtVencimento.Text);
            Venda.formaPagamento = cmbFormaPagamento.Text;
            Venda.StatusVenda = cmbSatus.Text;
            Venda.Valor = Convert.ToDouble(txtValorfinal.Text);
            VendasDAO.salvar(Venda);
            MessageBox.Show("Venda efetuada com sucesso!", "Venda");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmVendas_Load(object sender, EventArgs e)
        {
            cmbFormaPagamento.Items.Add("Dinheiro a vista");
            cmbFormaPagamento.Items.Add("Cartão Crédito");
            cmbFormaPagamento.Items.Add("Cartão Débito");
            cmbFormaPagamento.Items.Add("Cheque");
            cmbSatus.Items.Add("Pago");
            cmbSatus.Items.Add("A pagar");
            /*Produtos = ProdutosDao.retornarTudo();
            for (int i = 0; i < Clientes.Count; i++)
            {
                cmbCliente.Items.Add(Clientes[i].nome);
            }*/
            /*Produtos = ProdutosDao.retornarTudo();
            for (int i = 0; i < Produtos.Count; i++)
            {
                cmbProduto.Items.Add(Produtos[i].descr);
            }*/
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void cmbFormaPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btncCalcularValor_Click(object sender, EventArgs e)
        {
            txtValorfinal.Text = (Convert.ToInt32(txtQtde.Text) * Convert.ToDouble(txtValorProduto.Text)).ToString();
        }

        private void txtIdproduto_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < Produtos.Count; i++)
            {
                if (Produtos[i].Id == Convert.ToInt32(txtIdproduto.Text))
                {
                    cmbProduto.SelectedIndex = i;
                }
            }
        }

        private void cmbProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIdproduto.Text = cmbProduto.SelectedIndex.ToString();
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIdcliente.Text = cmbCliente.SelectedIndex.ToString();
        }
    }
}
