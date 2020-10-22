using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_vendas.Modelos
{
    class Produto
    {
        private int id;
        private string Nome;
        private string Descr;
        private string Marca;
        private string qntde;
        private string ValUnit;


        public Produto(string descr,string nome, string marca, string qntde, string valunit)
        {
            this.Descr = descr;
            this.Nome = nome;
            this.Marca = marca;
            this.Qntde = qntde;
            this.ValUnit = valunit;
        }

        public Produto(int id, string descr, string nome, string marca, string qntde, string valunit)
        {
            this.id = id;
            this.Descr = descr;
            this.nome = nome;
            this.marca = marca;
            this.Qntde = qntde;
            this.ValUnit = valunit;
        }

        public Produto() { }

        public int Id { get; set; }
        public string nome { get; set; }
        public string descr { get; set; }
        public string marca { get; set; }
        public string Qntde { get; set; }
        public string Valunit { get; set; }

        public bool validar()
        {
            return this.id != null && this.nome != "" && this.Descr != "" && this.marca != "" && this.qntde != "" && this.Valunit != "";
        }
    }
}
