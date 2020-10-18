using Sistema_de_vendas.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_vendas.DAO
{
    class ClienteDAO : Dao
    {
        private static string nomeTabela = "cliente";

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

        public static List<Clientes> buscar(string condições)
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

            List<Clientes> clienteLista = new List<Clientes>();

            // adicionando dados da consulta a lista
            while (resultado.Read())
            {
                Clientes cliente = new Clientes();
                cliente.idcliente = Convert.ToInt32(resultado.GetString(0));
                cliente.nome = (resultado.GetString(1));
                cliente.rg = (resultado.GetString(2));
                cliente.cpf = (resultado.GetString(3));
                cliente.endereço = (resultado.GetString(4));
                cliente.telefone = resultado.GetString(5);
                clienteLista.Add(cliente);
            }

            // destruindo objeto inutilizado 
            resultado.Dispose();

            return clienteLista;
        }

        public static void criarTabela()
        {
            //abertura do comando sql
            var comando = conexão.CreateCommand();

            // criação do comando sql
            comando.CommandText = $"INSERT INTO {nomeTabela} CREATE TABLE `sys_vendas`.`cliente` (" +
                                  "`idcliente` INT NOT NULL AUTO_INCREMENT," +
                                  "`nome` VARCHAR(45) NULL," +
                                  "`rg` VARCHAR(45) NULL," +
                                  "`cpf` VARCHAR(45) NULL," +
                                  "`endereço` VARCHAR(45) NULL," +
                                  "`telefone` VARCHAR(45) NULL," +
                                  "PRIMARY KEY(`idcliente`));'";


            // execução do comando
            comando.ExecuteNonQuery();

            // destruição do objeto de comando
            comando.Dispose();
        }

        public static List<Clientes> retornarTudo()
        {
            //abertura do comando sql
            var comando = conexão.CreateCommand();

            //criação de comando sql
            comando.CommandText = $"SELECT * FROM {nomeTabela}";

            // execução do comando
            var resultado = comando.ExecuteReader();

            List<Clientes> clienteLista = new List<Clientes>();

            // adicionando dados da consulta a lista
            while (resultado.Read())
            {
                Clientes cliente = new Clientes();
                cliente.idcliente = Convert.ToInt32(resultado.GetString(0));
                cliente.nome = (resultado.GetString(1));
                cliente.rg = (resultado.GetString(2));
                cliente.cpf = (resultado.GetString(3));
                cliente.endereço = (resultado.GetString(4));
                cliente.telefone = resultado.GetString(5);
                clienteLista.Add(cliente);
            }

            // distruição de objetos não utilizadoss
            comando.Dispose();
            resultado.Dispose();

            return clienteLista;
        }

        public static void salvar(Clientes cliente)
        {
            //abertura do comando sql
            var comando = conexão.CreateCommand();

            // criação do comando sql
            comando.CommandText = $"INSERT INTO {nomeTabela}(nome,rg,cpf,endereço,telefone) values('{cliente.nome}','{cliente.rg}','{cliente.cpf}','{cliente.endereço}','{cliente.telefone}')";

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
