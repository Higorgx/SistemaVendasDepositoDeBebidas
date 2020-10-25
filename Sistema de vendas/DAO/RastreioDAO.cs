using Sistema_de_vendas.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_vendas.DAO
{
    class RastreioDAO : Dao
    {
        private static string nomeTabela = "rastreio";

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

        public static List<Rastreio> buscar(string condições)
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

            List<Rastreio> rastreioLista = new List<Rastreio>();

            // adicionando dados da consulta a lista
            while (resultado.Read())
            {
                Rastreio rast = new Rastreio();
                rast.idrastreio = Convert.ToInt32(resultado.GetString(0));
                rast.codigorastreio = (resultado.GetString(1));
                rast.desc = (resultado.GetString(2));
                rast.idvenda = (resultado.GetInt32(3));
                rastreioLista.Add(rast);
            }

            // destruindo objeto inutilizado 
            resultado.Dispose();

            return rastreioLista;
        }

        public static void criarTabela()
        {
            //abertura do comando sql
            var comando = conexão.CreateCommand();

            // criação do comando sql
            comando.CommandText = $"CREATE TABLE `sys_vendas`.`rastreio` (" +
                                  "`idrastreio` INT NOT NULL AUTO_INCREMENT," +
                                  "`codigorastreio` VARCHAR(200) NULL," +
                                  "`desc` VARCHAR(400) NULL," +
                                  "`idvenda` INT NOT NULL," +
                                  "FOREIGN KEY (`idvenda`) REFERENCES `sys_vendas`.`vendas`(`idvendas`)," +
                                  "PRIMARY KEY(`idrastreio`));";

            // execução do comando
            comando.ExecuteNonQuery();

            // destruição do objeto de comando
            comando.Dispose();
        }

        public static List<Rastreio> retornarTudo()
        {
            //abertura do comando sql
            var comando = conexão.CreateCommand();

            //criação de comando sql
            comando.CommandText = $"SELECT * FROM {nomeTabela}";

            // execução do comando
            var resultado = comando.ExecuteReader();

            List<Rastreio> rastreioLista = new List<Rastreio>();

            // adicionando dados da consulta a lista
            while (resultado.Read())
            {
                Rastreio rast = new Rastreio();
                rast.idrastreio = Convert.ToInt32(resultado.GetString(0));
                rast.codigorastreio = (resultado.GetString(1));
                rast.desc = (resultado.GetString(2));
                rast.idvenda = (resultado.GetInt32(3));
                rastreioLista.Add(rast);
            }

            // distruição de objetos não utilizadoss
            comando.Dispose();
            resultado.Dispose();

            return rastreioLista;
        }

        public static void salvar(Rastreio rast)
        {
            //abertura do comando sql
            var comando = conexão.CreateCommand();

            // criação do comando sql
            comando.CommandText = $"INSERT INTO {nomeTabela}(codigorastreio,desc) values('{rast.codigorastreio}','{rast.desc}')";

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
