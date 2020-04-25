using grafico;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjVirus.pais
{
    class ChinaInd : Pais
    {

        public ChinaInd(Alteracoes alt, Cor cor) : base(alt, cor)
        {
        }

        public override string ToString()
        {
            return "C ";
        }

    }
}
