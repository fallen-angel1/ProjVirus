using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjVirus.pais
{
    class PaisesDadosGer
    {
        public int idadeMedia { get; set; }
        public int mortalidade { get; set; }
        public int casosRecuperados { get; set; }

        private int CasosRecu()
        {
            int totalCaRePt = Program.portugal.Where(item => item.casosRecuperados > 0).Sum(item => item.casosRecuperados);
            int totalCaReIt = Program.italia.Where(item => item.casosRecuperados > 0).Sum(item => item.casosRecuperados);
            int totalCaEs = Program.espanha.Where(item => item.casosRecuperados > 0).Sum(item => item.casosRecuperados);
            int totalCaCh = Program.china.Where(item => item.casosRecuperados > 0).Sum(item => item.casosRecuperados);
            int totalCaEua = Program.EUA.Where(item => item.casosRecuperados > 0).Sum(item => item.casosRecuperados);

            int totalCr = totalCaRePt + totalCaReIt + totalCaEs + totalCaEua + totalCaCh;
            return totalCr;
        }

        private int IdadeMedia()
        {
            int totalIdadRePt = Program.portugal.Where(item => item.idadeMedia > 0).Sum(item => item.idadeMedia);
            int totalIdadReIt = Program.italia.Where(item => item.idadeMedia > 0).Sum(item => item.idadeMedia);
            int totalIdadReEs = Program.espanha.Where(item => item.idadeMedia > 0).Sum(item => item.idadeMedia);
            int totalIdadReCh = Program.china.Where(item => item.idadeMedia > 0).Sum(item => item.idadeMedia);
            int totalIdadReEua = Program.EUA.Where(item => item.idadeMedia > 0).Sum(item => item.idadeMedia);

            int totalIdade = (totalIdadRePt + totalIdadReIt + totalIdadReEs + totalIdadReCh + totalIdadReEua) / 5;
            return totalIdade;
        }


        public PaisesDadosGer(int mortalidade)
        {
            this.idadeMedia = IdadeMedia();
            this.mortalidade = mortalidade;
            this.casosRecuperados = CasosRecu();
        }


        public override string ToString()
        {
            return "Idade Media Global: " + idadeMedia
                + " anos, Mortalidade: " + mortalidade +
                ", Casos Recuperados: " + casosRecuperados;
        }
    }
}
