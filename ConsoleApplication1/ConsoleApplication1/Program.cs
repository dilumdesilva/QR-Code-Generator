using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime dt = DateTime.Now;
            int xxxx = dt.Hour;
            string xx = dt.ToString();
            DateTime d = Convert.ToDateTime(xx);
            int xxxx1 = d.Hour;
        }
    }
}
