using grafico;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjVirus.pais
{
    class Italia
    {
        public int idadeMedia { get; set; }
        public int mortalidade { get; set; }
        public int casosRecuperados { get; set; }

        private int NumAleatoriosCasRec()
        {
            Random rd = new Random();
            int CasRec = rd.Next(17000, 21850);
            return CasRec;
        }

        public Italia(int idadeMedia, int mortalidade, int casosRecuperados)
        {
            this.idadeMedia = idadeMedia;
            this.mortalidade = mortalidade;
            this.casosRecuperados = casosRecuperados;
        }

        public Italia(int idadeMedia, int mortalidade)
        {
            this.idadeMedia = idadeMedia;
            this.mortalidade = mortalidade;
            this.casosRecuperados = NumAleatoriosCasRec();
        }

        public override string ToString()
        {
            return "Dados de Italia-Idade Media: " + idadeMedia
                + ", Mortalidade: " + mortalidade + 
                ", Casos Recuperados: " + casosRecuperados;
            //return "I";
        }
    }
}
