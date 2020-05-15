using grafico;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjVirus.pais
{
    class PaisesMoverIndicador : Pais
    {
        public string pais { get; set; }

        public PaisesMoverIndicador(string pais, Alteracoes alt, Cor cor) : base(alt, cor)
        {

            this.pais = pais;
        }

        public PaisesMoverIndicador(Alteracoes alt, Cor cor) : base(alt, cor)
        {
      
            this.pais = "Todos";
        }

        public static string escolherPais(string Pais)
        {
            switch (Pais)
            {
                case "Portugal":
                    return "P ";
                case "Italia":
                    return "I ";
                case "China":
                    return "C ";
                case "EUA":
                    return "A ";
                case "Espanha":
                    return "E ";
                case "Todos":
                    return "DG";
            }
            return Pais;
        }

        public override string ToString()
        {
            return escolherPais(pais);
        }
    }
}
