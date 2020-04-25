using grafico;
using ProjVirus.grafico;
using System;
using System.Collections.Generic;
using System.Text;

namespace grafico
{
    abstract class Pais
    {
        public Grafico grafico { get; set; }
        public Cor cor { get; protected set; }
        public Alteracoes alt { get; protected set; }
        public int qtMovimentos { get; protected set; }
       

        public Pais(Alteracoes alt, Cor cor)
        {
            this.grafico = null;
            this.alt = alt;
            this.cor = cor;
        }
    }
}
