using System;
using System.Collections.Generic;
using System.Drawing;           //To colour spaces for validation
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;     //To cast each space as a NumericUpDown

namespace Sudoku_Solver
{
    class RCS
    {
        NumericUpDown[] spaces;
        /// <summary>
        /// Constructs a row, column or square using the nine spaces that it contains
        /// </summary>
        /// <param name="one">First space</param>
        /// <param name="two">Second space</param>
        /// <param name="three">Third space</param>
        /// <param name="four">Fourth space</param>
        /// <param name="five">Fifth space</param>
        /// <param name="six">Sixth space</param>
        /// <param name="seven">Seventh space</param>
        /// <param name="eight">Eigth space</param>
        /// <param name="nine">Ninth space</param>
        public RCS(NumericUpDown one, NumericUpDown two, NumericUpDown three, 
            NumericUpDown four, NumericUpDown five, NumericUpDown six, 
            NumericUpDown seven, NumericUpDown eight, NumericUpDown nine)
        {
            spaces = new NumericUpDown[] {one, two, three, four, five, six, seven, eight, nine};
        }
        /// <summary>
        /// If the space matches one in the RCS array that is not the current space or zero, validation fails
        /// </summary>
        /// <param name="current">The space with focus</param>
        /// <returns>True if validation passes, False if it fails</returns>
        internal bool Validate(NumericUpDown current)
        {
            bool isValid = true;
            foreach (NumericUpDown space in spaces)
            {
                if (current.Value == space.Value && space.Value != 0 && current.Equals(space) == false)
                {
                    isValid = false;
                    break;
                }
            }
            return isValid;
        }
        /// <summary>
        /// Colours spaces in the RCS white if validation has passed and red if it failed
        /// </summary>
        /// <param name="isValid">If validation passed for the RCS</param>
        internal void ColourSpaces(bool isValid)
        {
            if (isValid == true)
            {
                foreach (NumericUpDown space in spaces)
                {
                    space.BackColor = Color.White;
                }
            }
            else
            {
                foreach (NumericUpDown space in spaces)
                {
                    space.BackColor = Color.Red;
                }
            }
        }
        /// <summary>
        /// Makes the spaces in each RCS instance accessible
        /// </summary>
        public NumericUpDown[] Spaces
        {
            get { return spaces; }
        }
    }
}
