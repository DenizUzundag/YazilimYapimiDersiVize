using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdevIslemm1
{
   public  class Toplama:IOperant
    {
        public int islem(int x, int y)
        {
            int a = x + y;
            if (a <= x || a <= y)
            {
                return 0;
            }
            else
            {
                return a;
            }
        }

        public String sembol()
        {
            return "+";
        }
    }
}
