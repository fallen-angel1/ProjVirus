using grafico;
using ProjVirus.pais;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjVirus.grafico
{
    public class PaisSeleccionado
    {
        private List<object> _paisSel = new List<object>();
        public void Add(string pais)
        {
            this._paisSel.Add(pais);
        }
        public string ListPaisSel()
        {
            string str = string.Empty;

            for (int i = 0; i < this._paisSel.Count; i++)
            {
                str += this._paisSel[i];
            }

            return str;
        }
    }

    public class PaisEscolhido : IBuilder
    {
        private PaisSeleccionado _paisSel = new PaisSeleccionado();

        public void SetPortugal()
        {
            this._paisSel.Add("P ");
        }

        public void SetEspanha()
        {
            this._paisSel.Add("E ");
        }

        public void SetChina()
        {
            this._paisSel.Add("C ");
        }

        public void SetEua()
        {
            this._paisSel.Add("A ");
        }

        public void setTodos()
        {
            this._paisSel.Add("DG");
        }

        public void setItalia()
        {
            this._paisSel.Add("I ");
        }

        public PaisSeleccionado GetPaisSeleccionado()
        {
            PaisSeleccionado resultado = this._paisSel;
            return resultado;
        }
    }
}
