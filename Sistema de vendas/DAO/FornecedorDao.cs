using Sistema_de_vendas.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_vendas.DAO
{
    class FornecedorDao : Dao
    {

        private static string nomeTabela = "fornecedores";

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

        public static List<Fornecedor> buscar(string condições)
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

            List<Fornecedor> fornecedores = new List<Fornecedor>();

            // adicionando dados da consulta a lista
            while (resultado.Read())
            {
                fornecedores.Add(new Fornecedor(
                    resultado.GetString(0),
                    resultado.GetString(1),
                    resultado.GetString(2),
                    resultado.GetString(3)
                ));
            }

            // destruindo objeto inutilizado 
            resultado.Dispose();

            return fornecedores;
        }

        public static void criarTabela()
        {
            //abertura do comando sql
            var comando = conexão.CreateCommand();

            // criação do comando sql
            comando.CommandText = $"CREATE TABLE {nomeTabela}" +
                                  "(" +
                                  "cnpj varchar(14) PRIMARY KEY," +
                                  "nome varchar(60) not null," +
                                  "endereco varchar(250) not null," +
                                  "ramo varchar(60) not null" +
                                  ")";

            // execução do comando
            comando.ExecuteNonQuery();

            // destruição do objeto de comando
            comando.Dispose();
        }

        public static List<Fornecedor> retornarTudo()
        {
            //abertura do comando sql
            var comando = conexão.CreateCommand();

            //criação de comando sql
            comando.CommandText = $"SELECT * FROM {nomeTabela}";

            // execução do comando
            var resultado = comando.ExecuteReader();

            List<Fornecedor> fornecedores = new List<Fornecedor>();

            // adicionando dados da consulta a lista
            while (resultado.Read())
            {
                fornecedores.Add(new Fornecedor(
                    resultado.GetString(0),
                    resultado.GetString(1),
                    resultado.GetString(2),
                    resultado.GetString(3)
                ));

            }

            // distruição de objetos não utilizadoss
            comando.Dispose();
            resultado.Dispose();

            return fornecedores;
        }

        public static void salvar(Fornecedor fornecedor)
        {
            //abertura do comando sql
            var comando = conexão.CreateCommand();

            // criação do comando sql
            comando.CommandText = $"INSERT INTO {nomeTabela}(cnpj,nome,endereco,ramo) values({fornecedor.Cnpj},'{fornecedor.Nome}','{fornecedor.Endereço}','{fornecedor.Ramo}')";

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
