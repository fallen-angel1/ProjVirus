using System;
using System.Collections.Generic;
using System.Text;

namespace ProjVirus.pais
{
    class EUA
    {
        public int idadeMedia { get; set; }
        public int mortalidade { get; set; }
        public int casosRecuperados { get; set; }

        private int NumAleatoriosCasRec()
        {
            Random rd = new Random();
            int CasRec = rd.Next(18000, 25850);
            return CasRec;
        }

        public EUA(int idadeMedia, int mortalidade, int casosRecuperados)
        {
            this.idadeMedia = idadeMedia;
            this.mortalidade = mortalidade;
            this.casosRecuperados = casosRecuperados;
        }
        public EUA(int idadeMedia, int mortalidade)
        {
            this.idadeMedia = idadeMedia;
            this.mortalidade = mortalidade;
            this.casosRecuperados = NumAleatoriosCasRec();
        }

        public override string ToString()
        {
            return "Dados dos EUA-Idade Media: " + idadeMedia
                      + ", Mortalidade: " + mortalidade +
                     ", Casos Recuperados: " + casosRecuperados;
        }

    }
}
