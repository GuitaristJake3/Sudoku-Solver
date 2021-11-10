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
        public SudokuSolver()
        {
            InitializeComponent();
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
