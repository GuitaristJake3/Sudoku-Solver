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

        private void r1c1_Enter(object sender, EventArgs e)
        {
            r1c1.BackColor = Color.Yellow;
        }

        private void r1c1_Leave(object sender, EventArgs e)
        {
            r1c1.BackColor = Color.White;
        }
    }
}
