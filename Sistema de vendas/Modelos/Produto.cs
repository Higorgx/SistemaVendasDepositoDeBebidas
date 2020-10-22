using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_vendas.Modelos
{
    class Produto
    {
     
        private string Nome;
        private string Descr;
        private string Marca;
        private string qntde;
        private string ValUnit;


        public Produto( string descr, string nome, string marca, string qntde, string valunit)
        {
           
            this.Descr = descr;
            this.nome = nome;
            this.marca = marca;
            this.Qntde = qntde;
            this.ValUnit = valunit;
        }

        public Produto() { }

      
        public string nome { get; set; }
        public string descr { get; set; }
        public string marca { get; set; }
        public string Qntde { get; set; }
        public string Valunit { get; set; }

        public bool validar()
        {
            return  this.nome != "" && this.Descr != "" && this.marca != "" && this.qntde != "" && this.Valunit != "";
        }
    }
}
