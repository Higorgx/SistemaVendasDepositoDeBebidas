using Sistema_de_vendas.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_vendas.DAO
{
    class VendasDAO : Dao
    {
        private static string nomeTabela = "vendas";

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

        public static List<Vendas> buscarNomeCliente(string condicoes)
        {
            //abertura do comando sql
            var comando = conexão.CreateCommand();

            var sql = $"SELECT vendas.quantidade, vendas.data_compra, vendas.formaPagamento, vendas.Vencimento, cliente.nome " +
                      $"FROM {nomeTabela} " +
                      $"join cliente " +
                      $"on vendas.id_cliente = cliente.idcliente "+
                      $"WHERE {condicoes}";

            // criação do comando sql
            comando.CommandText = sql;

            // executando comando
            var resultado = comando.ExecuteReader();

            //destruindo objetos inuteis
            comando.Dispose();

            List<Vendas> vendas = new List<Vendas>();

            // adicionando dados da consulta a lista
            while (resultado.Read())
            {
                Vendas ven = new Vendas();
                ven.quantidade = Convert.ToInt32(resultado.GetString(0));
                ven.data_compra = Convert.ToDateTime(resultado.GetString(1));
                ven.formaPagamento = resultado.GetString(2);
                ven.Vencimento = resultado.GetDateTime(3);
                ven.Nome = resultado.GetString(4);
                vendas.Add(ven);
            }

            // destruindo objeto inutilizado 
            resultado.Dispose();

            return vendas;
        }

        public static List<Vendas> buscar(string condições)
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

            List<Vendas> vendas = new List<Vendas>();

            // adicionando dados da consulta a lista
            while (resultado.Read())
            {
                Vendas ven = new Vendas();
                ven.idvendas = Convert.ToInt32(resultado.GetString(0));
                ven.id_cliente = Convert.ToInt32(resultado.GetString(1));
                ven.id_produto = Convert.ToInt32(resultado.GetString(2));
                ven.quantidade = Convert.ToInt32(resultado.GetString(3));
                ven.data_compra = Convert.ToDateTime(resultado.GetString(4));
                ven.formaPagamento = resultado.GetString(5);
                ven.Vencimento = resultado.GetDateTime(6);
                ven.StatusVenda = resultado.GetString(7);
                ven.Valor = Convert.ToInt32(resultado.GetString(8));
                vendas.Add(ven);
            }

            // destruindo objeto inutilizado 
            resultado.Dispose();

            return vendas;
        }

        public static void criarTabela()
        {
            //abertura do comando sql
            var comando = conexão.CreateCommand();

            // criação do comando sql
            comando.CommandText = $"CREATE TABLE {nomeTabela} (" +
                                  "idvendas INT NOT NULL AUTO_INCREMENT," +
                                  "id_cliente int(11)," +
                                  "id_produto int(11)," +
                                  "quantidade int(11)," +
                                  "data_compra datetime," +
                                  "formaPagamento varchar(45)," +
                                  "Vencimento datetime," +
                                  "StatusVenda varchar(45)," +
                                  "Valor float," +
                                  "PRIMARY KEY (`idvendas`)" +
                                  ")";

            // execução do comando
            comando.ExecuteNonQuery();

            // destruição do objeto de comando
            comando.Dispose();
        }

        public static List<Vendas> retornarTudo()
        {
            //abertura do comando sql
            var comando = conexão.CreateCommand();

            //criação de comando sql
            comando.CommandText = $"SELECT * FROM {nomeTabela}";

            // execução do comando
            var resultado = comando.ExecuteReader();

            List<Vendas> vendas = new List<Vendas>();

            // adicionando dados da consulta a lista
            while (resultado.Read())
            {
                Vendas ven = new Vendas();
                ven.idvendas = Convert.ToInt32(resultado.GetString(0));
                ven.id_cliente = Convert.ToInt32(resultado.GetString(1));
                ven.id_produto = Convert.ToInt32(resultado.GetString(2));
                ven.quantidade = Convert.ToInt32(resultado.GetString(3));
                ven.data_compra = Convert.ToDateTime(resultado.GetString(4));
                ven.formaPagamento = resultado.GetString(5);
                ven.Vencimento = resultado.GetDateTime(6);
                ven.StatusVenda = resultado.GetString(7);
                ven.Valor = Convert.ToInt32(resultado.GetString(8));
                vendas.Add(ven);
            }

            // distruição de objetos não utilizadoss
            comando.Dispose();
            resultado.Dispose();

            return vendas;
        }

        public static void salvar(Vendas venda)
        {
            //abertura do comando sql
            var comando = conexão.CreateCommand();

            // criação do comando sql
            comando.CommandText = $"INSERT INTO {nomeTabela}(id_cliente,id_produto,quantidade,data_compra,formaPagamento,Vencimento,StatusVenda,Valor) values({venda.id_cliente},{venda.id_produto},{venda.quantidade},'{venda.data_compra}','{venda.formaPagamento}','{venda.Vencimento}','{venda.StatusVenda}',{venda.Valor})";

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
