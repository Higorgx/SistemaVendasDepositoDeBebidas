
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
using Sistema_de_vendas.DAL;
using MySql.Data.MySqlClient;
using System.Data.Common;

namespace Sistema_de_vendas.Telas
{
    public partial class ContEstoque : Form
    {
        public ContEstoque()
        {
            InitializeComponent();

            /*
             * Inserir Total das vendas com faturamento total
             * e quantidade de vendas, produtos mais vendidos e lucro
             */
            var estoques = ProdutosDao.retornarTudo();
            foreach (var estoque in estoques)
            {
                
                listEstoque.Rows.Add( estoque.Id, estoque.descr, estoque.nome, estoque.marca, estoque.Valunit, estoque.Qntde);
            }

       
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        public void teste()
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            listEstoque.Rows.Clear();
            /*
             * Inserir Total das vendas com faturamento total
             * e quantidade de vendas, produtos mais vendidos e lucro
             */
            var estoques = ProdutosDao.retornarTudo();
            foreach (var estoque in estoques)
            {
                
                listEstoque.Rows.Add( estoque.descr, estoque.nome, estoque.marca, estoque.Valunit, estoque.Qntde);
            }
        }

        private void ContEstoque_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            

                Produto produto = new Produto( txt_Desc.Text, txt_Nome.Text, txt_Marca.Text, txt_Valunit.Text, txt_Qntde.Text);
                if (produto.validar())
                {
                    ProdutosDao.salvar(produto);
                    MessageBox.Show("Fornecedor registrado com sucesso!");

                }
                else
                {
                    MessageBox.Show("Falha ao registrar fornecedor... Verifique os dados no formulário!");
                }
            
            

           
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var index = Convert.ToInt32(listEstoque.CurrentRow.Cells[0].Value);

            ProdutosDao.deletar($" id = '{index}'");


            /**/
            listEstoque.Rows.Clear();
            /*
             * Inserir Total das vendas com faturamento total
             * e quantidade de vendas, produtos mais vendidos e lucro
             */
            var estoques = ProdutosDao.retornarTudo();
            foreach (var estoque in estoques)
            {

                listEstoque.Rows.Add( estoque.descr, estoque.nome, estoque.marca, estoque.Valunit, estoque.Qntde);
            }
        }
    }
}
