using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_vendas.Class
{
    /*
     * Padrão de projeto - Template Method
     * Esta classe é um esqueleto (passos/templates) que as subclasses devem seguir: https://www.thiengo.com.br/padrao-de-projeto-template-method-metodo-template
     */
    public abstract class Relatorio
    {
        /* 
         * TEMPLATE METHOD - todos os metodos dentro listados, serão exatamente a ordem
         * em que serão executados
         */
        public void relatorio()
        {
            mostrarLista();
        }

        /*
         * Implementação dos métodos do template, caso os metodos sejam
         * distintos entre uma classe e outra, colocar como abstract, pois assim
         * sera implementado na propria classe dando um override
         */
        public abstract List<ListViewItem> mostrarLista();
    }
}
