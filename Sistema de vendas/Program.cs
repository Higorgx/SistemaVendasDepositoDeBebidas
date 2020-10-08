using Sistema_de_vendas.DAL;
using Sistema_de_vendas.DAO;
using Sistema_de_vendas.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_vendas
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            UsuarioDao.resetarTabela();
            FornecedorDao.resetarTabela();
            FornecedorDao.criarTabela();
            UsuarioDao.criarTabela();
            

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
