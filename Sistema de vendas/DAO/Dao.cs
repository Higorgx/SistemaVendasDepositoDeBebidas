using MySql.Data.MySqlClient;
using Sistema_de_vendas.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_vendas.DAO
{
    class Dao
    {
        protected static MySqlConnection conexão = BancoDeDados.Conexão;
    }
}
