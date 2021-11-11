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
            row1 = new RCS(r1c1.Value, r1c2.Value, r1c3.Value, r1c4.Value, r1c5.Value, r1c6.Value, r1c7.Value, r1c8.Value, r1c9.Value);
            row2 = new RCS(r2c1.Value, r2c2.Value, r2c3.Value, r2c4.Value, r2c5.Value, r2c6.Value, r2c7.Value, r2c8.Value, r2c9.Value);
        }

        private void Update_Grid()
        {
            row1.Spaces = { r1c1.Value, r1c2.Value, r1c3.Value, r1c4.Value, r1c5.Value, r1c6.Value, r1c7.Value, r1c8.Value, r1c9.Value};
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
        }
    }
}
