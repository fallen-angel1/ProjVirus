using grafico;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjVirus.pais
{
    class PortugalInd : Pais
    {

        public PortugalInd(Alteracoes alt, Cor cor) : base(alt, cor)
        {
        }

        public override string ToString()
        {
            return "P ";
        }

    }
}
