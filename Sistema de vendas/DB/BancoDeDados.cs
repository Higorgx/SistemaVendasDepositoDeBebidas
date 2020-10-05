using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Sistema_de_vendas.DAL
{
    class BancoDeDados
    {
        static string credenciais = "Server=127.0.0.1;Database=sys_vendas;Uid=root;Pwd=";
        static MySqlConnection conexão = null;

        public static MySqlConnection Conexão
        {
            get
            {
                if (conexão == null)
                {
                    criarConexão();
                }
                return conexão;
            }
        }

        static void criarConexão()
        {
            conexão = new MySqlConnection(credenciais);
            conexão.Open();
        }

        public static void fecharConexão()
        {
            conexão.Close();
        }
    }
}
