using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopDemo
{
    public class BaseThing
    {
        private int a = 1;
        private int b;

        public BaseThing()
        {
            // field inits
            // base()
            b = 2;
        }
    }

    public class SubThing : BaseThing
    {
        private int c = 3;
        private int d;

        public SubThing()
        {
            // field inits
            // base()
            d = 4;
        }
    }
}
