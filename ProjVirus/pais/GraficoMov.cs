using grafico;
using ProjVirus.grafico;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjVirus.pais
{
    class GraficoMov
    {
        public Alteracoes alt { get; private set; }
        public bool GrafTerminar { get; private set; }
        private HashSet<Pais> pais;
        public Cor paisAtual { get; private set; }

        public GraficoMov()
        {
            alt = new Alteracoes(3, 6);
            GrafTerminar = false;
            paisAtual = Cor.Branco;
            pais = new HashSet<Pais>();
            colocarIndicadores();
        }

        public void colocarNovoInd(char coluna, int linha, Pais paises)
        {
            alt.colocarIndicador(paises, new PosicaoIndGraf(coluna, linha).toGrafico());
            pais.Add(paises);
        }

        public void melhoriaVirus(Grafico gOrig, Grafico gDestino)
        {
            Pais rem = alt.retirarPais(gOrig);

            alt.colocarIndicador(rem, gDestino);
        }

        public void piorVirus(Grafico gOrig, Grafico gDestino)
        {
            Pais rem = alt.retirarPais(gOrig);

            alt.colocarIndicador(rem, gDestino);
        }

        public void colocarIndicadores()
        {
            colocarNovoInd('1', 2, new PaisesDadosGerInd(alt, Cor.Branco));
            colocarNovoInd('2', 2, new PortugalInd(alt, Cor.Vermelho));
            colocarNovoInd('3', 2, new ItaliaInd(alt, Cor.Verde));
            colocarNovoInd('4', 2, new ChinaInd(alt, Cor.Laranja));
            colocarNovoInd('5', 2, new EUAInd(alt, Cor.Azul));
            colocarNovoInd('6', 2, new EspanhaInd(alt, Cor.Amarelo));
        }

    }


}
