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
        private string Descr;
        private string Marca;
        private string qntde;
        private string ValUnit;


        public Produto(string descr, string marca, string qntde, string valunit)
        {
            this.Descr = descr;
            this.Marca = marca;
            this.Qntde = qntde;
            this.ValUnit = valunit;
        }

        public Produto(int id, string descr, string marca, string qntde, string valunit)
        {
            this.id = id;
            this.Descr = descr;
            this.marca = marca;
            this.Qntde = qntde;
            this.ValUnit = valunit;
        }

        public Produto() { }

        public string descr { get => Descr; set => Descr = value; }
        public string marca { get => marca; set => marca = value; }
        public string Qntde { get => Qntde; set => Qntde = value; }
        public string Valunit { get => Valunit; set => Valunit = value; }
        public int Id { get => id; set => id = value; }
        public bool validar()
        {
            return this.id != null && this.Descr != "" && this.marca != "" && this.qntde != "" && this.Valunit != "";
        }
    }
}
