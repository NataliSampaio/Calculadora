using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
public class operacoes
    {
        public Soma Soma { get; set; }
        public Divisao Divisao { get; set; }
        public Subtracao Subtracao { get; set; }
        public Multiplicacao Multiplicacao { get; set; }

        public operacoes()
        {
            this.Soma = new Soma(); 
            this.Divisao = new Divisao();   
            this.Subtracao = new Subtracao();   
            this.Multiplicacao = new Multiplicacao();
        }


    }
}
