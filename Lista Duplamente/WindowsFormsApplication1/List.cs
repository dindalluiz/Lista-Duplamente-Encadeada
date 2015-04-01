using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaduplamente
{
    public class ListDindal
    {
        public int value;
        public ListDindal prev, next;

        public ListDindal(int v, ListDindal p, ListDindal n)
        {
            value = v;
            prev = p;
            next = n;
        }
    }
}
