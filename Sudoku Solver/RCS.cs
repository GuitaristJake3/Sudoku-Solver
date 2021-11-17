using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;     //To cast each space as a NumericUpDown

namespace Sudoku_Solver
{
    class RCS
    {
        object[] spaces;    //An array of the 9 spaces in each row, column and square
        public RCS(object one, object two, object three, object four, object five, object six, object seven, object eight, object nine)
        {
            spaces = new object[] {one, two, three, four, five, six, seven, eight, nine};
        }

        public bool Validate(NumericUpDown current)
        {
            bool isValid = true;
            foreach(object s in spaces)
            {
                NumericUpDown space = s as NumericUpDown;                                   //If the space matches a value in the array
                if (current.Value == space.Value && space.Value != 0 && current != space)   //that is not the current space itself and that value is not zero

                {
                    Console.WriteLine("validation failed");
                    isValid = false;
                    break;
                }
            }
            if(isValid == true)
            {
                Console.WriteLine("validaton passed");
            }
            return isValid;
        }

        public object[] Spaces
        {
            get { return spaces; }
            set { spaces = value; }
        }
    }
}
