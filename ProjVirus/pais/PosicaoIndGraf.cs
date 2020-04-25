using grafico;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjVirus.pais
{
    class PosicaoIndGraf
    {
        public char coluna { get; set; } 
        public int linha { get; set; }  

        public PosicaoIndGraf(char coluna, int linha)
        {
            this.coluna = coluna;
            this.linha = linha;
        }

        public Grafico toGrafico()
        {
            return new Grafico(3 - linha, coluna - '1');
        }

        public override string ToString()
        {
            return "" + coluna + linha;
        }
    }
}
