using System;
using System.Collections.Generic;
using System.Drawing;           //To colour spaces for validation
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;     //To cast each space as a NumericUpDown

namespace Sudoku_Solver
{
    public class RCS
    {
        List<NumericUpDown> spaces;
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
            spaces = new List<NumericUpDown> {one, two, three, four, five, six, seven, eight, nine};
        }
        /// <summary>
        /// If a space value matches one in the RCS array that is not the current space or zero, validation fails
        /// </summary>
        /// <returns>True if validation passes, False if it fails</returns>
        public bool Validate()
        {
            bool isValid = true;
            foreach (NumericUpDown space in spaces)
            {
                foreach (NumericUpDown space2 in spaces)
                {
                    if (space.Value == space2.Value && space.Value != 0 && space.Equals(space2) == false)
                    {
                        isValid = false;
                        break;
                    }
                }
            }
            return isValid;
        }
        /// <summary>
        /// Colours spaces in the RCS white if validation has passed and red if it failed
        /// </summary>
        /// <param name="isValid">If validation passed for the RCS</param>
        /// <param name="invalRCS">Previously invalidated RCS</param>
        public void ColourSpaces(bool isValid, List<RCS> invalRCS)
        {
            if (isValid == true)
            {
                foreach (NumericUpDown space in spaces)
                {
                    if (invalRCS.Count > 0)
                    {
                        foreach (RCS rcs in invalRCS)
                        {
                            if (!rcs.Spaces.Contains(space))
                            {
                                space.BackColor = Color.White;
                            }
                            else
                            {
                                space.BackColor = Color.Red;
                                break;
                            }
                        }
                    }
                    else
                    {
                        space.BackColor = Color.White;
                    }
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
        public List<NumericUpDown> Spaces
        {
            get { return spaces; }
        }
    }
}
