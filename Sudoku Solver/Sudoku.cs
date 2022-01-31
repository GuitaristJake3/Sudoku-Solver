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
        RCS row1, row2, row3, row4, row5, row6, row7, row8, row9,
            col1, col2, col3, col4, col5, col6, col7, col8, col9,
            sqa1, sqa2, sqa3, sqa4, sqa5, sqa6, sqa7, sqa8, sqa9;
        List<RCS> grid;
        List<RCS> invalRCS;
        public SudokuSolver()
        {
            InitializeComponent();
            row1 = new RCS(r1c1, r1c2, r1c3, r1c4, r1c5, r1c6, r1c7, r1c8, r1c9);
            row2 = new RCS(r2c1, r2c2, r2c3, r2c4, r2c5, r2c6, r2c7, r2c8, r2c9);
            row3 = new RCS(r3c1, r3c2, r3c3, r3c4, r3c5, r3c6, r3c7, r3c8, r3c9);
            row4 = new RCS(r4c1, r4c2, r4c3, r4c4, r4c5, r4c6, r4c7, r4c8, r4c9);
            row5 = new RCS(r5c1, r5c2, r5c3, r5c4, r5c5, r5c6, r5c7, r5c8, r5c9);
            row6 = new RCS(r6c1, r6c2, r6c3, r6c4, r6c5, r6c6, r6c7, r6c8, r6c9);
            row7 = new RCS(r7c1, r7c2, r7c3, r7c4, r7c5, r7c6, r7c7, r7c8, r7c9);
            row8 = new RCS(r8c1, r8c2, r8c3, r8c4, r8c5, r8c6, r8c7, r8c8, r8c9);
            row9 = new RCS(r9c1, r9c2, r9c3, r9c4, r9c5, r9c6, r9c7, r9c8, r9c9);
            col1 = new RCS(r1c1, r2c1, r3c1, r4c1, r5c1, r6c1, r7c1, r8c1, r9c1);
            col2 = new RCS(r1c2, r2c2, r3c2, r4c2, r5c2, r6c2, r7c2, r8c2, r9c2);
            col3 = new RCS(r1c3, r2c3, r3c3, r4c3, r5c3, r6c3, r7c3, r8c3, r9c3);
            col4 = new RCS(r1c4, r2c4, r3c4, r4c4, r5c4, r6c4, r7c4, r8c4, r9c4);
            col5 = new RCS(r1c5, r2c5, r3c5, r4c5, r5c5, r6c5, r7c5, r8c5, r9c5);
            col6 = new RCS(r1c6, r2c6, r3c6, r4c6, r5c6, r6c6, r7c6, r8c6, r9c6);
            col7 = new RCS(r1c7, r2c7, r3c7, r4c7, r5c7, r6c7, r7c7, r8c7, r9c7);
            col8 = new RCS(r1c8, r2c8, r3c8, r4c8, r5c8, r6c8, r7c8, r8c8, r9c8);
            col9 = new RCS(r1c9, r2c9, r3c9, r4c9, r5c9, r6c9, r7c9, r8c9, r9c9);
            sqa1 = new RCS(r1c1, r1c2, r1c3, r2c1, r2c2, r2c3, r3c1, r3c2, r3c3);
            sqa2 = new RCS(r1c4, r1c5, r1c6, r2c4, r2c5, r2c6, r3c4, r3c5, r3c6);
            sqa3 = new RCS(r1c7, r1c8, r1c9, r2c7, r2c8, r2c9, r3c7, r3c8, r3c9);
            sqa4 = new RCS(r4c1, r4c2, r4c3, r5c1, r5c2, r5c3, r6c1, r6c2, r6c3);
            sqa5 = new RCS(r4c4, r4c5, r4c6, r5c4, r5c5, r5c6, r6c4, r6c5, r6c6);
            sqa6 = new RCS(r4c7, r4c8, r4c9, r5c7, r5c8, r5c9, r6c7, r6c8, r6c9);
            sqa7 = new RCS(r7c1, r7c2, r7c3, r8c1, r8c2, r8c3, r9c1, r9c2, r9c3);
            sqa8 = new RCS(r7c4, r7c5, r7c6, r8c4, r8c5, r8c6, r9c4, r9c5, r9c6);
            sqa9 = new RCS(r7c7, r7c8, r7c9, r8c7, r8c8, r8c9, r9c7, r9c8, r9c9);
            grid = new List<RCS> { row1, row2, row3, row4, row5, row6, row7, row8, row9,
            col1, col2, col3, col4, col5, col6, col7, col8, col9,
            sqa1, sqa2, sqa3, sqa4, sqa5, sqa6, sqa7, sqa8, sqa9 };
            invalRCS = new List<RCS>();
        }
        /// <summary>
        /// Finds the row, column and square the selected space is in to call the appropriate Validate methods 
        /// </summary>
        /// <param name="current">The space with focus</param>
        /// <returns>A list of 3 RCS arrays to validate</returns>
        public List<RCS> SelectRCS(NumericUpDown current)
        {
            List<RCS> selectedRCS = new List<RCS>();
            foreach (RCS rcs in grid)
            {
                if (rcs.Spaces.Contains(current))
                {
                    selectedRCS.Add(rcs);
                }
            }
            return selectedRCS;
        }
        /// <summary>
        /// Each space turns yellow when focus gained
        /// </summary>
        /// <param name="sender">The space gaining focus</param>
        /// <param name="e">Empty</param>
        private void Space_Enter(object sender, EventArgs e)
        {
            NumericUpDown space = sender as NumericUpDown;
            space.BackColor = Color.Yellow;
        }
        /// <summary>
        /// Calls validation methods for each RCS the space losing focus is in and changes colours accordingly
        /// </summary>
        /// <param name="sender">The space losing focus</param>
        /// <param name="e">Empty</param>
        private void Space_Leave(object sender, EventArgs e)
        {
            NumericUpDown space = sender as NumericUpDown;
            foreach (RCS rcs in SelectRCS(space))
            {
                if (rcs.Validate(space) == true)
                {
                    bool alreadyInvalid;
                    if (invalRCS.Contains(rcs))
                    {
                        alreadyInvalid = true;
                    }
                    else
                    {
                        alreadyInvalid = false;
                    }
                    if (alreadyInvalid == false)
                    {
                        invalRCS.Remove(rcs);
                    }
                }
                else
                {
                    invalRCS.Add(rcs);
                }
                rcs.ColourSpaces(rcs.Validate(space), invalRCS);
            }
        }
    }
}
