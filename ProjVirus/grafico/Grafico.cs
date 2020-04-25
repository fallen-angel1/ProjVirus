using System;
using System.Collections.Generic;
using System.Text;

namespace grafico
{
    class Grafico
    {
        public int linha { get; set; }
        public int coluna { get; set; }

        public Grafico(int linha, int coluna)
        {
            this.linha = linha;
            this.coluna = coluna;
        }

        public void definirValores(int linha, int coluna)
        {
            this.linha = linha;
            this.coluna = coluna;
        }

        public override string ToString()
        {
            return linha
                + ", "
                + coluna;
        }
    }
}
