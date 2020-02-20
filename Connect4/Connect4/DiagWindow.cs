using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connect4
{
   public partial class DiagWindow : Form
   {
      public DiagWindow()
      {
         InitializeComponent();
      }
      public void DisplayLine(string dataToPrint)
      {
         txtDisplay.Text += dataToPrint + Environment.NewLine;
      }
      public void ClearDisplay()
      {
         txtDisplay.Text = "";
      }
      /// <summary>
      /// Properly formats te array when displays on the screen
      /// </summary>
      /// <param name="element">refers to things in the display</param>
      /// <returns>Formatted output</returns>
      private string DisplayElement(string element)
      {
         return " " + element + " |";
      }
      /// <summary>
      /// Displays the array onto the scrren
      /// </summary>
      /// <param name="boardArrayToDisplay"> the array</param>
      public void DisplayArray(string[,] boardArrayToDisplay)
      {
         string tableLine = "       +---+---+---+---+---+---+---+" + Environment.NewLine;
         string arrayContents = tableLine;

         for (int row = boardArrayToDisplay.GetLength(0) - 1; row >= 0; row--)
         {
            arrayContents += "Row " + row + ": |";

            for (int column = 0; column < boardArrayToDisplay.GetLength(1); column++)
            {
               arrayContents += DisplayElement(boardArrayToDisplay[row, column]);
            }

            arrayContents += Environment.NewLine;
            arrayContents += tableLine;
         }

         arrayContents += "         0   1   2   3   4   5   6 " + Environment.NewLine;
         arrayContents += "        col col col col col col col";

         txtDisplay.Text = arrayContents;
         txtDisplay.Select(0, 0);
      }
   }
}
