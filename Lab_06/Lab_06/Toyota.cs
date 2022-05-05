using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_06
{
    public class Toyota : Car
    {
        public new string Met()
        {
            return "Child";
        }
        public override string GetBrand()
        {
            return "toyota";
        }

        public override string GetColour()
        {
            return "white";
        }
    }
}
