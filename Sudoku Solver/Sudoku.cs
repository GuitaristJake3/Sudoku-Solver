using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku_Solver
{
    public partial class SudokuSolver : Form
    {
        RCS row1, row2, row3, row4, row5, row6, row7, row8, row9;
        public SudokuSolver()
        {
            InitializeComponent();
            row1 = new RCS(r1c1, r1c2, r1c3, r1c4, r1c5, r1c6, r1c7, r1c8, r1c9);
            row2 = new RCS(r2c1, r2c2, r2c3, r2c4, r2c5, r2c6, r2c7, r2c8, r2c9);
        }

        private void Space_Enter(object sender, EventArgs e)    //Each space turns yellow when control gained
        {
            NumericUpDown space = sender as NumericUpDown;
            space.BackColor = Color.Yellow;
        }

        private void Space_Leave(object sender, EventArgs e)    //Each space turns white when control lost
        {
            NumericUpDown space = sender as NumericUpDown;
            space.BackColor = Color.White;
            row1.Validate(space);
        }
    }
}
