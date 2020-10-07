using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_vendas.Modelos
{
    class Fornecedor
    {
        private string nome;
        private string ramo;
        private string endereço;
        private string cnpj;

        public Fornecedor(string cnpj, string nome, string endereço, string ramo)
        {
            this.Nome = nome;
            this.Ramo = ramo;
            this.Endereço = endereço;
            this.Cnpj = cnpj;
        }

        public string Nome { get => nome; set => nome = value; }
        public string Ramo { get => ramo; set => ramo = value; }
        public string Endereço { get => endereço; set => endereço = value; }
        public string Cnpj { get => cnpj; set => cnpj = value; }

        public bool validar()
        {
            return this.cnpj.Length == 14 
                && this.nome != "" && this.nome != null
                && this.endereço != "" && this.endereço != null
                && this.ramo != "" && this.ramo != null;
        }
    }
}
