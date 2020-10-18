using Sistema_de_vendas.DAO;
using Sistema_de_vendas.Modelos;
using System;
using System.Windows.Forms;

namespace Sistema_de_vendas.Telas
{
    public partial class CadFornecedores : Form
    {
        public CadFornecedores()
        {
            InitializeComponent();
            recarregarLista();
        }

        private void recarregarLista()
        {
            lista.Items.Clear();

            var fornecedores = FornecedorDao.retornarTudo();

            if (fornecedores.Count > 0)
            {
                foreach (var fornecedor in fornecedores)
                {
                    lista.Items.Add(fornecedor.Cnpj);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fornecedor fornecedor = new Fornecedor(cnpj.Text, nome.Text, endereco.Text, ramo.Text);
            if (fornecedor.validar())
            {
                FornecedorDao.salvar(fornecedor);
                MessageBox.Show("Fornecedor registrado com sucesso!");
                
                recarregarLista();

                cnpj.Clear();
                nome.Clear();
                ramo.Clear();

                endereco.Clear();
            }
            else
            {
                MessageBox.Show("Falha ao registrar fornecedor... Verifique os dados no formulário!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FornecedorDao.deletar(lista.SelectedItem.ToString());
            recarregarLista();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var empresas = FornecedorDao.buscar($" cnpj = '{lista.SelectedItem.ToString()}'");

            foreach(var empresa in empresas)
            {
                MessageBox.Show(
                    $"Nome: {empresa.Nome}\n" +
                    $"Ramo: {empresa.Ramo}\n" +
                    $"Endereço: {empresa.Endereço}\n" +
                    $"CNPJ: {empresa.Cnpj}");
            }
        }

        private void CadFornecedores_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Fechar?", "Fechar", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                this.Close();
        }

        private void lista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
