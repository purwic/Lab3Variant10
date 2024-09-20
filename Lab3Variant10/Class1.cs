using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Variant10
{
    public class Class1
    {
        static public int method(int x)
        {
            if(10 <= x && x < 100)
            {
                return int.Parse($"{x.ToString()[0]}") * int.Parse($"{x.ToString()[0]}") * int.Parse($"{x.ToString()[1]}") * int.Parse($"{x.ToString()[1]}");
            }
            else
            {
                return -1;
            }
        }
    }
}
