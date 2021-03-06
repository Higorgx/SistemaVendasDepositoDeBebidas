﻿using Sistema_de_vendas.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_vendas.DAO
{
    class UsuarioDao : Dao
    {

        private static string nomeTabela = "usuarios";

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
                                  "login varchar(60) not null," +
                                  "senha varchar(250) not null" +
                                  ")";

            // execução do comando
            comando.ExecuteNonQuery();

            // destruição do objeto de comando
            comando.Dispose();
        }

        public static List<Usuario> retornarTudo()
        {
            //abertura do comando sql
            var comando = conexão.CreateCommand();
          
            //criação de comando sql
            comando.CommandText = $"SELECT * FROM {nomeTabela}";
            
            // execução do comando
            var resultado = comando.ExecuteReader();

            List<Usuario> usuarios = new List<Usuario>();

            // adicionando dados da consulta a lista
            while (resultado.Read())
            {
                usuarios.Add(new Usuario(
                    resultado.GetInt32(0), //id
                    resultado.GetString(1),//login 
                    resultado.GetString(2) //senha
                ));

            }

            // distruição de objetos não utilizadoss
            comando.Dispose();
            resultado.Dispose();
            
            return usuarios;
        }

        public static void salvar(Usuario usuario)
        {
            //abertura do comando sql
            var comando = conexão.CreateCommand();
            
            // criação do comando sql
            comando.CommandText = $"INSERT INTO {nomeTabela}(login, senha) values('{usuario.Login}','{usuario.Senha}')";

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
