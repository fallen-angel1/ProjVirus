using grafico;
using ProjVirus.grafico;
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
            var builder = new PaisEscolhido();
            builder.setTodos();
            this.pais = builder.GetPaisSeleccionado().ListPaisSel();
        }

        public override string ToString()
        {
            return pais;
        }
    }
}
