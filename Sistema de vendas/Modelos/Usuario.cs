using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_vendas.Modelos
{
    class Usuario
    {
        private int id;
        private string login;
        private string senha;

        public Usuario(string login, string senha)
        {
            this.login = login;
            this.senha = senha;
        }

        public Usuario(int id, string login, string senha)
        {
            this.id = id;
            this.login = login;
            this.senha = senha;
        }

        public Usuario() { }

        public string Login { get => login; set => login = value; }
        public string Senha { get => senha; set => senha = value; }
        public int Id { get => id; set => id = value; }
        public bool validar()
        {
            return this.id != null
                && this.login != "" && this.senha != "" ;
        }
    }
}
