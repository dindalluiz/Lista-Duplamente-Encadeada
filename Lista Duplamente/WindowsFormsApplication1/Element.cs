using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaduplamente
{
    class Element
    {
        #region Propriedades
        private int valor;
        private Element proximo;
        private Element anterior;
        #endregion

        #region Construtores
        public Element(int v)
        {
            Valor = v;
            Proximo = null;
            Anterior = null;
        }

        public Element(int v, Element p = null)
        {
            Valor = v;
            Proximo = p;
            Anterior = null;
        }

        public Element(int v, Element p = null, Element a = null)
        {
            Valor = v;
            Proximo = p;
            Anterior = a;
        }
        #endregion

        #region Get/Set
        public int Valor
        {
            get
            {
                return valor;
            }
            set
            {
                valor = value;
            }
        }

        public Element Proximo
        {
            get
            {
                return proximo;
            }
            set
            {
                proximo = value;
            }
        }

        public Element Anterior
        {
            get
            {
                return anterior;
            }
            set
            {
                anterior = value;
            }
        }
        #endregion

        #region Utilitários
        public String AsString
        {
            get
            {
                return "Valor: " + valor.ToString();
            }
        }
        #endregion
    }

}
