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
        ListDindal[] alo = new ListDindal[200];

        public Form1()
        {
            int sec = System.DateTime.Now.Second;

            InitializeComponent();
            alo[0] = new ListDindal(1,null, null);

            for (int i = 1; i < alo.Length; i++)
            {
                alo[i] = new ListDindal(i+(2*sec), (i == 0) ? null : alo[i-1], null);
            }

            for (int i = 1; i < alo.Length;i++ )
            {
                alo[i-1].next = alo[i];
            }

            alo[alo.Length-1].next = alo[0];
            alo[0].prev = alo[alo.Length - 1];


            Console.WriteLine("Prev: "+alo[0].prev.value);

            Console.WriteLine("Next: "+alo[alo.Length-1].value);
        }
    }
}
