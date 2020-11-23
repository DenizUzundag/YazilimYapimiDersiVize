using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdevIslemm1
{
   public class Cıkarma:IOperant
    {
        public int islem(int x, int y)
        {
            if (x < y)
            {
                return y - x;
            }
            else
            {
                return x - y;
            }
        }

        public String sembol()
        {
            return "-";
        }
    }
}
