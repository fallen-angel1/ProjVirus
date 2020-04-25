using grafico;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjVirus.pais
{
    class PaisesDadosGerInd : Pais
    {
        public PaisesDadosGerInd(Alteracoes alt, Cor cor) : base(alt, cor)
        {

        }

        public override string ToString()
        {
            return "DG";
        }

        private bool podeMover(Grafico pos)
        {
            Pais p = alt.pais(pos);
            return p == null || p.cor != cor;
        }

     
    }
}
