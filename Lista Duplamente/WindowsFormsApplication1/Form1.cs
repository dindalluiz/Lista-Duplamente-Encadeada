using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listaduplamente
{
    public partial class Form1 : Form
    {
        private List lista;

        public Form1()
        {
            InitializeComponent();
        }

        private void CarregarPrograma(object sender, EventArgs e)
        {
            lista = new List();
        }

        private void InicializarLista(object sender, EventArgs e)
        {
            Element Element = new Element(lista.Count);
            lista.Adiciona(Element);
        }

        private void AdicionaElemento(object sender, EventArgs e)
        {
            Random r = new Random();
            Element Element = new Element(lista.Count);
            lista.Adiciona(new Element(r.Next(1, 100) + (2 * DateTime.Now.Second)));
        }

        private void ExibirLista(object sender, EventArgs e)
        {
            lista.ImprimeLista();
        }
    }
}
