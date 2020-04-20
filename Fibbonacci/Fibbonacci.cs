using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibbonacci
{
    class Fibbonacci
    {
        public int GetFibbonacci(int index)
        {
            if (index == 0) return 0;
            if (index == 1) return 1;
            return GetFibbonacci(index-1) + GetFibbonacci(index-2);
        }
    }
}
