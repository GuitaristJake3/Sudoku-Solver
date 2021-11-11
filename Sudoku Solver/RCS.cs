using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku_Solver
{
    class RCS
    {
        decimal[] spaces;
        public RCS(decimal one, decimal two, decimal three, decimal four, decimal five, decimal six, decimal seven, decimal eight, decimal nine)
        {
            spaces = new decimal[] {one, two, three, four, five, six, seven, eight, nine};
        }

        public decimal[] Spaces
        {
            get { return spaces; }
            set { spaces = value; }
        }

    }
}
