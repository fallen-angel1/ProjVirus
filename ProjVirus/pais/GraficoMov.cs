using grafico;
using ProjVirus.grafico;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public void porSimboloOuTirar(Grafico gOrig, Grafico gDestino)
        {
            Pais rem = alt.retirarPais(gOrig);

            alt.colocarIndicador(rem, gDestino);
        }

        public static int CasosRecuperados(string pais)
        {
            int totalCasosRecuperadosPt = Program.portugal.Where(item => item.casosRecuperados > 0).Sum(item => item.casosRecuperados);
            int totalCasosRecuperadosIt = Program.italia.Where(item => item.casosRecuperados > 0).Sum(item => item.casosRecuperados);
            int totalCasosRecuperadosEs = Program.espanha.Where(item => item.casosRecuperados > 0).Sum(item => item.casosRecuperados);
            int totalCasosRecuperadosCh = Program.china.Where(item => item.casosRecuperados > 0).Sum(item => item.casosRecuperados);
            int totalCasosRecuperadosEua = Program.EUA.Where(item => item.casosRecuperados > 0).Sum(item => item.casosRecuperados);
            int totalCasosRecuperadosTodosPaises = Program.paisesDados.Where(item => item.casosRecuperados > 0).Sum(item => item.casosRecuperados);

            switch (pais)
            {
                case "Portugal":
                    return totalCasosRecuperadosPt;
                case "Italia":
                    return totalCasosRecuperadosIt;
                case "China":
                    return totalCasosRecuperadosCh;
                case "Espanha":
                    return totalCasosRecuperadosEs;
                case "Eua":
                    return totalCasosRecuperadosEua;
                case "Todos":
                    return totalCasosRecuperadosTodosPaises;
            }
            return 0;
        }

        public static int VitimasMortais(string pais)
        {
            int totalVitimasMortaisPt = Program.portugal.Where(item => item.mortalidade > 0).Sum(item => item.mortalidade);
            int totalVitimasMortaisIt = Program.italia.Where(item => item.mortalidade > 0).Sum(item => item.mortalidade);
            int totalVitimasMortaisEs = Program.espanha.Where(item => item.mortalidade > 0).Sum(item => item.mortalidade);
            int totalVitimasMortaisCh = Program.china.Where(item => item.mortalidade > 0).Sum(item => item.mortalidade);
            int totalVitimasMortaisEua = Program.EUA.Where(item => item.mortalidade > 0).Sum(item => item.mortalidade);
            int totalVitimasMortaisTodosPaises = Program.paisesDados.Where(item => item.mortalidade > 0).Sum(item => item.mortalidade);

            switch (pais)
            {
                case "Portugal":
                    return totalVitimasMortaisPt;
                case "Italia":
                    return totalVitimasMortaisIt;
                case "China":
                    return totalVitimasMortaisCh;
                case "Espanha":
                    return totalVitimasMortaisEs;
                case "Eua":
                    return totalVitimasMortaisEua;
                case "Todos":
                    return totalVitimasMortaisTodosPaises;
            }
            return 0;
        }

        public static char colunaPosicaoPaisEscolhido(string paisEscolhido)
        {
            switch (paisEscolhido)
            {
                case "Todos":
                   return '1';
                case "Portugal":
                    return '2';
                case "Italia":
                    return '3';
                case "China":
                    return '4';
                case "Eua":
                    return '5';
                case "Espanha":
                    return '6';
            }
            return '0';
        }

        public void VirusDadosGerais(string paisEscolhido)
        {
            if (CasosRecuperados(paisEscolhido) > VitimasMortais(paisEscolhido))
            {
                PosicaoIndGraf orig = new PosicaoIndGraf(colunaPosicaoPaisEscolhido(paisEscolhido), 2);
                Grafico gOrig = orig.toGrafico();
                PosicaoIndGraf dest = new PosicaoIndGraf(colunaPosicaoPaisEscolhido(paisEscolhido), 1);
                Grafico gDestino = dest.toGrafico();

                porSimboloOuTirar(gOrig, gDestino);
                Console.ReadLine();
            }
            else if (VitimasMortais(paisEscolhido) > CasosRecuperados(paisEscolhido))
            {
                PosicaoIndGraf orig = new PosicaoIndGraf(colunaPosicaoPaisEscolhido(paisEscolhido), 2);
                Grafico gOrig = orig.toGrafico();
                PosicaoIndGraf dest = new PosicaoIndGraf(colunaPosicaoPaisEscolhido(paisEscolhido), 3);
                Grafico gDestino = dest.toGrafico();

                porSimboloOuTirar(gOrig, gDestino);
                Console.ReadLine();
            }
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
