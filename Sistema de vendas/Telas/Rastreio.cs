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
    public partial class Rastreio : Form
    {
        public Rastreio()
        {
            InitializeComponent();
            recarregarLista();
        }

        private void recarregarLista()
        {
            lista.Items.Clear();

            var rastreios = RastreioDAO.retornarTudo();

            if (rastreios.Count > 0)
            {
                foreach (var rast in rastreios)
                {
                    lista.Items.Add(rast.codigorastreio);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Modelos.Rastreio rast = new Modelos.Rastreio();
            rast.codigorastreio = textBox1.Text;
            rast.desc = textBox2.Text;            

            try
            {
                rast.idvenda = Int32.Parse(textBox3.Text);
            }
            catch
            {
                MessageBox.Show("Falha ao registrar rastreio... Verifique os dados no formulário!");
                return;
            }

            if (rast.validar())
            {
                RastreioDAO.salvar(rast);                

                recarregarLista();
                MessageBox.Show("Rastreio registrado com sucesso!");

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
            else
            {
                MessageBox.Show("Falha ao registrar rastreio... Verifique os dados no formulário!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RastreioDAO.deletar($" codigorastreio = '{lista.SelectedItem.ToString()}'");
            recarregarLista();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var rasts = RastreioDAO.buscar($" codigorastreio = '{lista.SelectedItem.ToString()}'");

            foreach (var rast in rasts)
            {
                MessageBox.Show(
                    $"Codigo: {rast.codigorastreio}\n" +
                    $"Descrição: {rast.desc}\n" +
                    $"Venda: {rast.idvenda}\n");
            }
        }
    }
}
