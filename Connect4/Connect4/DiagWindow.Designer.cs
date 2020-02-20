namespace Connect4
{
   partial class DiagWindow
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.txtDisplay = new System.Windows.Forms.TextBox();
         this.SuspendLayout();
         // 
         // txtDisplay
         // 
         this.txtDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
         this.txtDisplay.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtDisplay.Location = new System.Drawing.Point(0, 0);
         this.txtDisplay.Multiline = true;
         this.txtDisplay.Name = "txtDisplay";
         this.txtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
         this.txtDisplay.Size = new System.Drawing.Size(510, 450);
         this.txtDisplay.TabIndex = 0;
         // 
         // DiagWindow
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(510, 450);
         this.Controls.Add(this.txtDisplay);
         this.Name = "DiagWindow";
         this.Text = "Diag Form";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

        #endregion

        private System.Windows.Forms.TextBox txtDisplay;
    }
}