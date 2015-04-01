using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace listaduplamente
{
    class List
    {
        private Element primeiro;
        public Element Primeiro
        {
            get
            {
                return primeiro;
            }
            set
            {
                primeiro = value;
            }
        }

        public Element Ultimo
        {
            get
            {
                return BuscaUltimo();
            }
        }

        public List()
        {

        }

        public void Adiciona(Element e)
        {
            if (Primeiro == null)
            {
                Primeiro = e;
            }
            else
            {
                Ultimo.Proximo = e;
            }
        }

        public Element BuscaUltimo()
        {
            Element current = Primeiro;
            while (current.Proximo != null)
            {
                current = current.Proximo;
            }
            return current;
        }

        public int Count
        {
            get
            {
                int count = 1;
                Element current = Primeiro;
                while (current != null)
                {
                    current = current.Proximo;
                    count++;
                }
                return count;
            }
        }

        public void ImprimeLista()
        {
            Element current = Primeiro;
            while (current != null)
            {
                Debug.WriteLine(current.AsString);
                current = current.Proximo;
            }
        }
    }
}
