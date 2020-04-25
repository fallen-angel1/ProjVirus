using grafico;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjVirus.pais
{
    class EspanhaInd : Pais
    {

        public EspanhaInd(Alteracoes alt, Cor cor) : base(alt, cor)
        {
        }

        public override string ToString()
        {
            return "E ";
        }

    }
}
