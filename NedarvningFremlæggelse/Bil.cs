using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NedarvningFremlæggelse
{
    public abstract class Bil
    {

        public int pris{ get; private set; }

        public Bil(int pris)
        {
            this.pris = pris;
        }

        public abstract int Afgift();
        //{
        //    return 1000;
        //}


    }
}
