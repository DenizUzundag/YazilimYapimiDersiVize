using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdevIslemm1
{
   public class Bolme:IOperant
    {
        public int islem(int x, int y)
        {
            if (x < y)
            {
                int t = x;
                x = y;
                y = x;

            }
            if (x % y == 0)
            {
                return x / y;
            }
            else
            {
                return 0;
            }
        }

        public String sembol()
        {

            return "/";
        }
    }
}
