using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Connect4
{
   public partial class TheBoard : Form
   {
      // Global variables
      bool playerTurn = true; // Black Coin = true : Red Coin = false
      string[,] theBoard = new string[6, 7];  // [rows, columns]
      int row = -1;
      int column = -1;
      int turnCounter = 0;

      DiagWindow diagWindow;
      bool viewArrayContents = false;
      bool viewPatternBuild = false;
      public TheBoard()
      {
         InitializeComponent();
      }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
         this.Close();
        }
      private Bitmap SetCoinImage()
      {
         return (playerTurn) ? Properties.Resources.BlackCoin : Properties.Resources.RedCoin;
      }
      private void GiveButtonUsedColor (Button button2Change)
      {
         button2Change.FlatAppearance.BorderColor = Color.Red;
      }
      private string PlayerValue()
      {
         return (playerTurn) ? "W" : "T";
      }
      private void UpdateArrayContents(int row2Use, int col2Use)
      {
         theBoard[row2Use, col2Use] = PlayerValue();
         // Show contents if array diagnostics are enabled.
         if (viewArrayContents)
         {
            diagWindow.ClearDisplay();
            diagWindow.DisplayArray(theBoard);
         }
      }
      private string GenerateRowPattern()
      {
         string pattern = "";
         for (int columnIndex = 0; columnIndex < theBoard.GetLength(1); columnIndex++)
         {
            pattern += theBoard[row, columnIndex];
         }
         // If the diagnostic window is set to using View Pattern, then display pattern.
         if (viewPatternBuild)
         {
            diagWindow.DisplayLine("Row Pattern: " + pattern);
         }
         return pattern;
      }
      private string GenerateColumnPattern()
      {
         string pattern = "";
         for (int RowIndex = 0; RowIndex < theBoard.GetLength(0); RowIndex++)
         {
            pattern += theBoard[RowIndex, column];
         }
         return pattern;
      }
      private string GenerateDiagonal1Pattern()
      {

         string partUpper = GenerateDiagonal1Upper(row, column);
         string partCenter = theBoard[row, column];
         string partLower = GenerateDiagonal1Lower(row, column);

         string pattern = partUpper + partCenter + partLower;

         if (viewPatternBuild)
         {
            diagWindow.DisplayLine(Environment.NewLine);
            diagWindow.DisplayLine("     Diagonal 1:");
            diagWindow.DisplayLine(" Diagonal Upper:" + partUpper);
            diagWindow.DisplayLine("Diagonal Center:" + partCenter);
            diagWindow.DisplayLine(" Diagonal Lower:" + partLower);
            diagWindow.DisplayLine("            All:" + pattern);
         }
         return pattern;
      }
      private string GenerateDiagonal1Upper(int row2Start, int column2Start)
      {

         string pattern = "";
         row2Start++;
         column2Start--;

         while (row2Start < theBoard.GetLength(0) && column2Start >= 0)
         {
            pattern += theBoard[row2Start, column2Start];

            row2Start++;
            column2Start--;
         }
         return pattern;
      }
      private string GenerateDiagonal1Lower(int row2Start, int column2Start)
      {

         string pattern = "";
         row2Start--;
         column2Start++;

         while (row2Start >= 0 && column2Start > theBoard.GetLength(1))
         {
            pattern = theBoard[row2Start, column2Start] + pattern;

            row2Start--;
            column2Start++;
         }
         return pattern;
      }
      private string GenerateDiagonal2Upper(int row2Start, int column2Start)
      {
         string pattern = "";
         row2Start++;
         column2Start++;

         while (row2Start < theBoard.GetLength(0) && column2Start < theBoard.GetLength(1))
         {
            pattern += theBoard[row2Start, column2Start];

            row2Start++;
            column2Start++;
         }
         return pattern;
      }
      private string GenerateDiagonal2Lower(int row2Start, int column2Start)
      {

         string pattern = "";
         row2Start--;
         column2Start--;

         while (row2Start >= 0 && column2Start >= 0)
         {
            pattern = theBoard[row2Start, column2Start] + pattern;

            row2Start--;
            column2Start--;
         }
         return pattern;
      }
      private string GenerateDiagonal2Pattern()
      {
         string partUpper = GenerateDiagonal2Upper(row, column);
         string partCenter = theBoard[row, column];
         string partLower = GenerateDiagonal2Lower(row, column);

         string pattern = partLower + partCenter + partUpper;

         if (viewPatternBuild)
         {
            diagWindow.DisplayLine(Environment.NewLine);
            diagWindow.DisplayLine("     Diagonal 2:");
            diagWindow.DisplayLine(" Diagonal Upper:" + partUpper);
            diagWindow.DisplayLine("Diagonal Center:" + partCenter);
            diagWindow.DisplayLine(" Diagonal Lower:" + partLower);
            diagWindow.DisplayLine("            All:" + pattern);


         }
         return pattern;
      }
      private bool CheckWinner()
      {
         string rowPattern = GenerateRowPattern();
         string columnPattern = GenerateColumnPattern();
         string diagonal1Pattern = GenerateDiagonal1Pattern();
         string diagonal2Pattern = GenerateDiagonal2Pattern();

         if (rowPattern.Contains("WWWW") || rowPattern.Contains("TTTT"))
         {
            return true;
         }
         else if (columnPattern.Contains("WWWW") || columnPattern.Contains("TTTT"))
         {
            return true;
         }
         else if (diagonal1Pattern.Contains("WWWW") || diagonal1Pattern.Contains("TTTT"))
         {
            return true;
         }
         else if (diagonal2Pattern.Contains("WWWW") || diagonal2Pattern.Contains("TTTT"))
         {
            return true;
         }
         else
            return false;
      }
      private int DropRow(int columnClicked)
      {
         int row = 0;
         for(row = 0; row < theBoard.GetLength(1); row++)
         {
            if(theBoard[row, columnClicked] == "-")
            {
               break;
            }
         }
         return row;
      }
      private int DropCoin(int column)
      {
         int rowForCoin = DropRow(column);
         string buttonName = "btn" + rowForCoin + column;

         Button buttonForCoin = (Button)Controls["gbxBoard"].Controls[buttonName];

         buttonForCoin.Image = SetCoinImage();
         GiveButtonUsedColor(buttonForCoin);

         return rowForCoin;
      }
      private void GameClick(object sender, EventArgs e)
      {
         Button ButtonClicked = (Button)sender;


         if (ButtonClicked.Image == null)
         {
            row = int.Parse(ButtonClicked.Name.Substring(3, 1));
            column = int.Parse(ButtonClicked.Name.Substring(4, 1));

            int rowWhereCoinIs = DropCoin(column);

            theBoard[rowWhereCoinIs, column] = PlayerValue();

            UpdateArrayContents(rowWhereCoinIs, column);

            if (CheckWinner())
            {
               //Annonce Winner
               ResetBoard("DISABLE");
            }
            else if (turnCounter == 28)
            {
               ResetBoard("DISABLE");
            }
            else
            {
               playerTurn = !playerTurn;
               turnCounter++;
            }
         }
      }
      private void ResetGame()
      {
         ResetBoard("Full");
         ClearTheBoardArray();
      }
      private void ClearTheBoardArray()
      {
         for (int row = 0; row < theBoard.GetLength(0); row++)
         {
            for (int col = 0; col < theBoard.GetLength(1); col++)
            {
               theBoard[row, col] = "-";
            }
         }
      }
      private void mnustrpReset_Click(object sender, EventArgs e)
      {
         if (txtPlayerOneName.Text.Length > 0 && txtPlayerTwoName.Text.Length > 0)
         {
            mnustrpReset.Text = "Reset Board";
            ResetGame();
         }
         else
            MessageBox.Show("Enter Player Name.");

      }
      private void ResetBoard(string typeOfReset)
      {
         typeOfReset = typeOfReset.ToUpper();

         gbxBoard.Enabled = true;

         foreach (Control buttonControl in Controls["gbxBoard"].Controls)
         {
            if (buttonControl is Button)
            {
               if (typeOfReset == "DISABLE")
               {
                  buttonControl.Enabled = false;
               }
               else
               {
                  buttonControl.Enabled = true;
                  ((Button)buttonControl).FlatAppearance.BorderColor = Color.Black;
                  ((Button)buttonControl).Image = null;
               }
            }
         }
      }
      private void Form1_Load(object sender, EventArgs e)
      {
         //Changes reset button to the text
         mnustrpReset.Text = "Begin Game";

      }
      private void mnustrpSubExaminePatternBuild_Click(object sender, EventArgs e)
      {
         viewPatternBuild = true;
         viewArrayContents = false;

         diagWindow.Text = "Examine Pattern Build";
         diagWindow.ClearDisplay();
         MessageBox.Show("Viewing pattern build has been enabled.");
      }
      private void EnableDiagnositics()
      {
         // Turn Diagnostics on in the program.
         mnustrpSubDiagEnable.Text = "Disable";

         mnustrpSubExamineArray.Enabled = true;
         mnustrpSubExaminePattern.Enabled = true;

         // Default to viewing the array
         viewArrayContents = true;
         //  MessageBox.Show("Viewing array contents has been enabled.");

         // Instantiate the diagnostic window, set location and display
         diagWindow = new DiagWindow();

         diagWindow.Text = "Examine Array Contents";

         diagWindow.StartPosition = FormStartPosition.Manual;
         diagWindow.Location = new Point(this.Location.X - 512, this.Location.Y);

         diagWindow.Show();

         // display the current contents of the array
         diagWindow.DisplayArray(theBoard);
      }
      private void DisableDiagnositics()
      {
         // Close and dispose the open diagnostics window
         diagWindow.Close();
         diagWindow.Dispose();

         // Disable all diagnostic features
         mnustrpSubDiagEnable.Text = "Enable";

         mnustrpSubExamineArray.Enabled = false;
         mnustrpSubExaminePattern.Enabled = false;

         viewArrayContents = false;
         viewPatternBuild = false;
      }
      private void mnustrpSubDiagEnable_Click(object sender, EventArgs e)
      {
         if (mnustrpSubDiagEnable.Text == "Enable")
         {
            EnableDiagnositics();
         }
         else
         {
            DisableDiagnositics();
         }
      }
   }
}
