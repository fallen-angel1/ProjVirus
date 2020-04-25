using System;
using System.Collections.Generic;
using System.Text;

namespace ProjVirus.pais
{
    class Portugal
    {
        public int idadeMedia { get; set; }
        public int mortalidade { get; set; }
        public int casosRecuperados { get; set; }

     
        public Portugal(int idadeMedia, int mortalidade, int casosRecuperados)
        {
            this.idadeMedia = idadeMedia;
            this.mortalidade = mortalidade;
            this.casosRecuperados = casosRecuperados;
        }

        private int NumAleatoriosMort()
        {
            Random rd = new Random();
            int mortPor = rd.Next(200, 450);
            return mortPor;
        }

        private int NumAleatoriosCasRec()
        {
            Random rd = new Random();
            int CasRec = rd.Next(100, 850);
            return CasRec;
        }

        public Portugal(int idadeMedia)
        {
            this.idadeMedia = idadeMedia;
            this.mortalidade = NumAleatoriosMort();
            this.casosRecuperados = NumAleatoriosCasRec();
        }

        public override string ToString()
        {
            return "Dados de Portugal-Idade Media: " + idadeMedia
                      + ", Mortalidade: " + mortalidade +
                     ", Casos Recuperados: " + casosRecuperados;
        }

    }
}
