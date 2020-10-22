using Sistema_de_vendas.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_vendas.DAO
{
    class ProdutosDao : Dao
    {

        private static string nomeTabela = "produtos";

        public static void resetarTabela()
        {
            //abertura do comando sql
            var comando = conexão.CreateCommand();

            // criação do comando sql
            comando.CommandText = $"DROP TABLE IF EXISTS {nomeTabela}";

            //execução do comando
            comando.ExecuteNonQuery();

            //excluindo objetos sem uso
            comando.Dispose();
        }

        public static List<Usuario> buscar(string condições)
        {
            //abertura do comando sql
            var comando = conexão.CreateCommand();

            var sql = $"SELECT * FROM {nomeTabela} WHERE {condições}";

            // criação do comando sql
            comando.CommandText = sql;

            // executando comando
            var resultado = comando.ExecuteReader();

            //destruindo objetos inuteis
            comando.Dispose();

            List<Usuario> usuarios = new List<Usuario>();

            // adicionando dados da consulta a lista
            while (resultado.Read())
            {
                usuarios.Add(new Usuario(
                    resultado.GetString(1), //login
                    resultado.GetString(2) //senha
                ));
            }

            // destruindo objeto inutilizado 
            resultado.Dispose();

            return usuarios;
        }

        public static void criarTabela()
        {
            //abertura do comando sql
            var comando = conexão.CreateCommand();

            // criação do comando sql
            comando.CommandText = $"CREATE TABLE {nomeTabela}" +
                                  "(" +
                                  "id int AUTO_INCREMENT PRIMARY KEY," +
                                  "nome varchar(100) not null," +
                                  "descr varchar(60) not null," +
                                  "marca varchar(60) not null," +
                                  "valunit varchar(60) not null," +
                                  "Qntde varchar(250) not null" +
                                  ")";

            // execução do comando
            comando.ExecuteNonQuery();

            // destruição do objeto de comando
            comando.Dispose();
        }

        public static List<ProdutoCerto> retornarTudo()
        {
            //abertura do comando sql
            var comando = conexão.CreateCommand();

            //criação de comando sql
            comando.CommandText = $"SELECT * FROM {nomeTabela}";

            // execução do comando
            var resultado = comando.ExecuteReader();

            List<ProdutoCerto> ListaProdutos = new List<ProdutoCerto>();

            // adicionando dados da consulta a lista
            while (resultado.Read())
            {
                /*Produto.Add(new ProdutoCerto(
                    resultado.GetInt32(0), 
                    resultado.GetString(1),
                    resultado.GetString(2),
                    resultado.GetString(3),
                    resultado.GetString(4)
                ));*/

                ProdutoCerto Prod = new ProdutoCerto();
                Prod.Id = Convert.ToInt32(resultado.GetString(0));
                Prod.nome = resultado.GetString(1);
                Prod.descr = resultado.GetString(2);
                Prod.marca = resultado.GetString(3);
                Prod.Valunit = resultado.GetString(4); ;
                Prod.Qntde = resultado.GetString(5);

                ListaProdutos.Add(Prod);

            }

            // distruição de objetos não utilizadoss
            comando.Dispose();
            resultado.Dispose();

            return ListaProdutos;
        }

        public static void salvar(Produto produto)
        {
            //abertura do comando sql
            var comando = conexão.CreateCommand();

            // criação do comando sql
            comando.CommandText = $"INSERT INTO {nomeTabela}( nome, descr, marca, Valunit, Qntde) values('{produto.nome}','{produto.descr}','{produto.marca}','{produto.Valunit}','{produto.Qntde}')";

            // execução do comando
            comando.ExecuteNonQuery();

            // destruição do objeto de comando
            comando.Dispose();
        }

        public static void deletar(string condições)
        {
            //abrindo comando sql
            var comando = conexão.CreateCommand();

            string sql = $"DELETE FROM {nomeTabela} WHERE {condições}";

            //criando comando sql
            comando.CommandText = sql;

            //executando comando
            comando.ExecuteNonQuery();

            //destruindo objetos não utilizados
            comando.Dispose();
        }
    }
}
