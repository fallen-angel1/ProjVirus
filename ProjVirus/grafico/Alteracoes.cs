using grafico;
using ProjVirus.grafico;
using System;
using System.Collections.Generic;
using System.Text;

namespace grafico
{
     class Alteracoes
    {
        public int linhas { get; set; }
        public int colunas { get; set; }
        private Pais[,] paises;

        public Alteracoes(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            paises = new Pais[linhas, colunas];
        }

        public Pais pais(int linha, int coluna)
        {
            return paises[linha, coluna];
        }

        public Pais pais(Grafico pos)
        {
            return paises[pos.linha, pos.coluna];
        }

        public void colocarIndicador(Pais p, Grafico graf)
        {
            paises[graf.linha, graf.coluna] = p;
            p.grafico = graf;
        }

        public Pais retirarPais(Grafico pos)
        {
            if (pais(pos) == null)
            {
                return null;
            }
            Pais aux = pais(pos);
            aux.grafico = null;
            paises[pos.linha, pos.coluna] = null;
            return aux;
        }

        public bool graficoValida(Grafico pos)
        {
            if (pos.linha < 0 || pos.linha >= linhas || pos.coluna < 0 || pos.coluna >= colunas)
            {
                return false;
            }
            return true;
        }

        public void validarGrafico(Grafico pos)
        {
            if (!graficoValida(pos))
            {
                throw new GraficoException("Posição inválida!");
            }
        }
    }
}
