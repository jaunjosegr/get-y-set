using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace get_y_set
{
    internal class Clasemul
    {
        private int n1;
        private int n2;

        public Clasemul()
        {

        }
        
        public int N1
        {
            get { return n1; }
            set { n1 = value; }
        }
        public int N2
        {
            get { return n2; }
            set { n2 = value; }
        }

        public int mul() 
        { 
            return n1 * n2;
        }
    }
}
