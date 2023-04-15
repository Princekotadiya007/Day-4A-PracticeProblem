using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NlogDemo
{
    internal class Sum
    {
        Nlogs log = new Nlogs();
        public void DoSum(int a, int b)
        {
            if(a==0 || b == 0)
            {
                log.Logerror("a and b value are zero");
            }
            else
            {
                int c = a + b;
                log.Logdebug("Debug sucessfully");
                log.Loginfo("Adition of =" + a + "+" + b + "=" + c);
            }
        }
    }
}
