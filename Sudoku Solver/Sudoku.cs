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
        List<NumericUpDown> r2;
        List<NumericUpDown> r3;
        List<NumericUpDown> r4;
        List<NumericUpDown> r5;
        List<NumericUpDown> r6;
        List<NumericUpDown> r7;
        List<NumericUpDown> r8;
        List<NumericUpDown> r9;
        public SudokuSolver()
        {
            InitializeComponent();
            List<NumericUpDown> r1 = new List<NumericUpDown> {
                r1c1, r1c2, r1c3, r1c4, r1c5, r1c6, r1c7, r1c8, r1c9
            }; 
        }

        private void Space_Enter(object sender, EventArgs e)
        {
            NumericUpDown space = sender as NumericUpDown;
            space.BackColor = Color.Yellow;
        }

        private void Space_Leave(object sender, EventArgs e)
        {
            NumericUpDown space = sender as NumericUpDown;
            space.BackColor = Color.White;
        }
    }
}
