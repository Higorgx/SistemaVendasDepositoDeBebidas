using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_vendas.Modelos
{
    class Rastreio
    {
        public int idrastreio { get; set; }
        public string codigorastreio { get; set; }
        public string desc { get; set; }
        public int idvenda { get; set; }

        public bool validar()
        {
            return this.codigorastreio != ""
                && this.desc != "" && this.idvenda >= 0;
        }
    }
}
