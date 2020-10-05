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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            UsuarioDao.resetarTabela();
            
            UsuarioDao.criarTabela();

            UsuarioDao.salvar(new Usuario("Ostavio", "fsdgsdsgs"));
            UsuarioDao.retornarTudo();
            UsuarioDao.salvar(new Usuario("Allan", "fsdgsdsgs"));

            var usr = UsuarioDao.buscar("id = 1");
            
            UsuarioDao.deletar($"id = {usr[0].Id}");
        }
    }
}
