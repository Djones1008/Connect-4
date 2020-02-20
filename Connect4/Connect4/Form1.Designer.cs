namespace Connect4
{
   partial class Form1
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
         this.mnustrpControls = new System.Windows.Forms.MenuStrip();
         this.mnustrpReset = new System.Windows.Forms.ToolStripMenuItem();
         this.mnustrpDiag = new System.Windows.Forms.ToolStripMenuItem();
         this.mnustrpSubDiagEnable = new System.Windows.Forms.ToolStripMenuItem();
         this.mnustrpExit = new System.Windows.Forms.ToolStripMenuItem();
         this.btn50 = new System.Windows.Forms.Button();
         this.btn40 = new System.Windows.Forms.Button();
         this.btn30 = new System.Windows.Forms.Button();
         this.btn20 = new System.Windows.Forms.Button();
         this.btn10 = new System.Windows.Forms.Button();
         this.gbxBoard = new System.Windows.Forms.GroupBox();
         this.btn06 = new System.Windows.Forms.Button();
         this.btn16 = new System.Windows.Forms.Button();
         this.btn26 = new System.Windows.Forms.Button();
         this.btn36 = new System.Windows.Forms.Button();
         this.btn46 = new System.Windows.Forms.Button();
         this.btn56 = new System.Windows.Forms.Button();
         this.btn05 = new System.Windows.Forms.Button();
         this.btn15 = new System.Windows.Forms.Button();
         this.btn25 = new System.Windows.Forms.Button();
         this.btn35 = new System.Windows.Forms.Button();
         this.btn45 = new System.Windows.Forms.Button();
         this.btn55 = new System.Windows.Forms.Button();
         this.btn04 = new System.Windows.Forms.Button();
         this.btn14 = new System.Windows.Forms.Button();
         this.btn24 = new System.Windows.Forms.Button();
         this.btn34 = new System.Windows.Forms.Button();
         this.btn44 = new System.Windows.Forms.Button();
         this.btn54 = new System.Windows.Forms.Button();
         this.btn03 = new System.Windows.Forms.Button();
         this.btn13 = new System.Windows.Forms.Button();
         this.btn23 = new System.Windows.Forms.Button();
         this.btn33 = new System.Windows.Forms.Button();
         this.btn43 = new System.Windows.Forms.Button();
         this.btn53 = new System.Windows.Forms.Button();
         this.btn02 = new System.Windows.Forms.Button();
         this.btn12 = new System.Windows.Forms.Button();
         this.btn22 = new System.Windows.Forms.Button();
         this.btn32 = new System.Windows.Forms.Button();
         this.btn42 = new System.Windows.Forms.Button();
         this.btn52 = new System.Windows.Forms.Button();
         this.btn01 = new System.Windows.Forms.Button();
         this.btn11 = new System.Windows.Forms.Button();
         this.btn21 = new System.Windows.Forms.Button();
         this.btn31 = new System.Windows.Forms.Button();
         this.btn41 = new System.Windows.Forms.Button();
         this.btn51 = new System.Windows.Forms.Button();
         this.btn00 = new System.Windows.Forms.Button();
         this.txtPlayerOneName = new System.Windows.Forms.TextBox();
         this.txtPlayerTwoName = new System.Windows.Forms.TextBox();
         this.lblPlayerOne = new System.Windows.Forms.Label();
         this.lblPlayerTwo = new System.Windows.Forms.Label();
         this.mnustrpSubExamineArray = new System.Windows.Forms.ToolStripMenuItem();
         this.mnustrpSubExaminePattern = new System.Windows.Forms.ToolStripMenuItem();
         this.mnustrpControls.SuspendLayout();
         this.gbxBoard.SuspendLayout();
         this.SuspendLayout();
         // 
         // mnustrpControls
         // 
         this.mnustrpControls.BackColor = System.Drawing.Color.DarkSeaGreen;
         this.mnustrpControls.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnustrpReset,
            this.mnustrpDiag,
            this.mnustrpExit});
         this.mnustrpControls.Location = new System.Drawing.Point(0, 0);
         this.mnustrpControls.Name = "mnustrpControls";
         this.mnustrpControls.Size = new System.Drawing.Size(686, 24);
         this.mnustrpControls.TabIndex = 0;
         this.mnustrpControls.Text = "menuStrip1";
         // 
         // mnustrpReset
         // 
         this.mnustrpReset.Name = "mnustrpReset";
         this.mnustrpReset.Size = new System.Drawing.Size(47, 20);
         this.mnustrpReset.Text = "Reset";
         this.mnustrpReset.Click += new System.EventHandler(this.mnustrpReset_Click);
         // 
         // mnustrpDiag
         // 
         this.mnustrpDiag.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnustrpSubDiagEnable,
            this.mnustrpSubExamineArray,
            this.mnustrpSubExaminePattern});
         this.mnustrpDiag.Name = "mnustrpDiag";
         this.mnustrpDiag.Size = new System.Drawing.Size(43, 20);
         this.mnustrpDiag.Text = "Diag";
         // 
         // mnustrpSubDiagEnable
         // 
         this.mnustrpSubDiagEnable.Name = "mnustrpSubDiagEnable";
         this.mnustrpSubDiagEnable.Size = new System.Drawing.Size(180, 22);
         this.mnustrpSubDiagEnable.Text = "Enable";
         this.mnustrpSubDiagEnable.Click += new System.EventHandler(this.mnustrpSubDiagEnable_Click);
         // 
         // mnustrpExit
         // 
         this.mnustrpExit.Name = "mnustrpExit";
         this.mnustrpExit.Size = new System.Drawing.Size(37, 20);
         this.mnustrpExit.Text = "Exit";
         this.mnustrpExit.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
         // 
         // btn50
         // 
         this.btn50.BackColor = System.Drawing.Color.DarkSeaGreen;
         this.btn50.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btn50.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btn50.Location = new System.Drawing.Point(6, 35);
         this.btn50.Name = "btn50";
         this.btn50.Size = new System.Drawing.Size(50, 50);
         this.btn50.TabIndex = 1;
         this.btn50.UseVisualStyleBackColor = false;
         this.btn50.Click += new System.EventHandler(this.GameClick);
         // 
         // btn40
         // 
         this.btn40.BackColor = System.Drawing.Color.DarkSeaGreen;
         this.btn40.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btn40.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btn40.Location = new System.Drawing.Point(6, 91);
         this.btn40.Name = "btn40";
         this.btn40.Size = new System.Drawing.Size(50, 50);
         this.btn40.TabIndex = 2;
         this.btn40.UseVisualStyleBackColor = false;
         this.btn40.Click += new System.EventHandler(this.GameClick);
         // 
         // btn30
         // 
         this.btn30.BackColor = System.Drawing.Color.DarkSeaGreen;
         this.btn30.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btn30.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btn30.Location = new System.Drawing.Point(6, 147);
         this.btn30.Name = "btn30";
         this.btn30.Size = new System.Drawing.Size(50, 50);
         this.btn30.TabIndex = 3;
         this.btn30.UseVisualStyleBackColor = false;
         this.btn30.Click += new System.EventHandler(this.GameClick);
         // 
         // btn20
         // 
         this.btn20.BackColor = System.Drawing.Color.DarkSeaGreen;
         this.btn20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btn20.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btn20.Location = new System.Drawing.Point(6, 203);
         this.btn20.Name = "btn20";
         this.btn20.Size = new System.Drawing.Size(50, 50);
         this.btn20.TabIndex = 4;
         this.btn20.UseVisualStyleBackColor = false;
         this.btn20.Click += new System.EventHandler(this.GameClick);
         // 
         // btn10
         // 
         this.btn10.BackColor = System.Drawing.Color.DarkSeaGreen;
         this.btn10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btn10.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btn10.Location = new System.Drawing.Point(6, 259);
         this.btn10.Name = "btn10";
         this.btn10.Size = new System.Drawing.Size(50, 50);
         this.btn10.TabIndex = 5;
         this.btn10.UseVisualStyleBackColor = false;
         this.btn10.Click += new System.EventHandler(this.GameClick);
         // 
         // gbxBoard
         // 
         this.gbxBoard.Controls.Add(this.btn06);
         this.gbxBoard.Controls.Add(this.btn16);
         this.gbxBoard.Controls.Add(this.btn26);
         this.gbxBoard.Controls.Add(this.btn36);
         this.gbxBoard.Controls.Add(this.btn46);
         this.gbxBoard.Controls.Add(this.btn56);
         this.gbxBoard.Controls.Add(this.btn05);
         this.gbxBoard.Controls.Add(this.btn15);
         this.gbxBoard.Controls.Add(this.btn25);
         this.gbxBoard.Controls.Add(this.btn35);
         this.gbxBoard.Controls.Add(this.btn45);
         this.gbxBoard.Controls.Add(this.btn55);
         this.gbxBoard.Controls.Add(this.btn04);
         this.gbxBoard.Controls.Add(this.btn14);
         this.gbxBoard.Controls.Add(this.btn24);
         this.gbxBoard.Controls.Add(this.btn34);
         this.gbxBoard.Controls.Add(this.btn44);
         this.gbxBoard.Controls.Add(this.btn54);
         this.gbxBoard.Controls.Add(this.btn03);
         this.gbxBoard.Controls.Add(this.btn13);
         this.gbxBoard.Controls.Add(this.btn23);
         this.gbxBoard.Controls.Add(this.btn33);
         this.gbxBoard.Controls.Add(this.btn43);
         this.gbxBoard.Controls.Add(this.btn53);
         this.gbxBoard.Controls.Add(this.btn02);
         this.gbxBoard.Controls.Add(this.btn12);
         this.gbxBoard.Controls.Add(this.btn22);
         this.gbxBoard.Controls.Add(this.btn32);
         this.gbxBoard.Controls.Add(this.btn42);
         this.gbxBoard.Controls.Add(this.btn52);
         this.gbxBoard.Controls.Add(this.btn01);
         this.gbxBoard.Controls.Add(this.btn11);
         this.gbxBoard.Controls.Add(this.btn21);
         this.gbxBoard.Controls.Add(this.btn31);
         this.gbxBoard.Controls.Add(this.btn41);
         this.gbxBoard.Controls.Add(this.btn51);
         this.gbxBoard.Controls.Add(this.btn00);
         this.gbxBoard.Controls.Add(this.btn10);
         this.gbxBoard.Controls.Add(this.btn20);
         this.gbxBoard.Controls.Add(this.btn30);
         this.gbxBoard.Controls.Add(this.btn40);
         this.gbxBoard.Controls.Add(this.btn50);
         this.gbxBoard.Enabled = false;
         this.gbxBoard.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.gbxBoard.ForeColor = System.Drawing.Color.Black;
         this.gbxBoard.Location = new System.Drawing.Point(12, 27);
         this.gbxBoard.Name = "gbxBoard";
         this.gbxBoard.Size = new System.Drawing.Size(399, 372);
         this.gbxBoard.TabIndex = 2;
         this.gbxBoard.TabStop = false;
         this.gbxBoard.Text = "Game Board";
         // 
         // btn06
         // 
         this.btn06.BackColor = System.Drawing.Color.DarkSeaGreen;
         this.btn06.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btn06.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btn06.Location = new System.Drawing.Point(342, 315);
         this.btn06.Name = "btn06";
         this.btn06.Size = new System.Drawing.Size(50, 50);
         this.btn06.TabIndex = 42;
         this.btn06.UseVisualStyleBackColor = false;
         this.btn06.Click += new System.EventHandler(this.GameClick);
         // 
         // btn16
         // 
         this.btn16.BackColor = System.Drawing.Color.DarkSeaGreen;
         this.btn16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btn16.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btn16.Location = new System.Drawing.Point(342, 259);
         this.btn16.Name = "btn16";
         this.btn16.Size = new System.Drawing.Size(50, 50);
         this.btn16.TabIndex = 41;
         this.btn16.UseVisualStyleBackColor = false;
         this.btn16.Click += new System.EventHandler(this.GameClick);
         // 
         // btn26
         // 
         this.btn26.BackColor = System.Drawing.Color.DarkSeaGreen;
         this.btn26.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btn26.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btn26.Location = new System.Drawing.Point(342, 203);
         this.btn26.Name = "btn26";
         this.btn26.Size = new System.Drawing.Size(50, 50);
         this.btn26.TabIndex = 40;
         this.btn26.UseVisualStyleBackColor = false;
         this.btn26.Click += new System.EventHandler(this.GameClick);
         // 
         // btn36
         // 
         this.btn36.BackColor = System.Drawing.Color.DarkSeaGreen;
         this.btn36.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btn36.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btn36.Location = new System.Drawing.Point(342, 147);
         this.btn36.Name = "btn36";
         this.btn36.Size = new System.Drawing.Size(50, 50);
         this.btn36.TabIndex = 39;
         this.btn36.UseVisualStyleBackColor = false;
         this.btn36.Click += new System.EventHandler(this.GameClick);
         // 
         // btn46
         // 
         this.btn46.BackColor = System.Drawing.Color.DarkSeaGreen;
         this.btn46.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btn46.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btn46.Location = new System.Drawing.Point(342, 91);
         this.btn46.Name = "btn46";
         this.btn46.Size = new System.Drawing.Size(50, 50);
         this.btn46.TabIndex = 38;
         this.btn46.UseVisualStyleBackColor = false;
         this.btn46.Click += new System.EventHandler(this.GameClick);
         // 
         // btn56
         // 
         this.btn56.BackColor = System.Drawing.Color.DarkSeaGreen;
         this.btn56.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btn56.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btn56.Location = new System.Drawing.Point(342, 35);
         this.btn56.Name = "btn56";
         this.btn56.Size = new System.Drawing.Size(50, 50);
         this.btn56.TabIndex = 37;
         this.btn56.UseVisualStyleBackColor = false;
         this.btn56.Click += new System.EventHandler(this.GameClick);
         // 
         // btn05
         // 
         this.btn05.BackColor = System.Drawing.Color.DarkSeaGreen;
         this.btn05.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btn05.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btn05.Location = new System.Drawing.Point(286, 315);
         this.btn05.Name = "btn05";
         this.btn05.Size = new System.Drawing.Size(50, 50);
         this.btn05.TabIndex = 36;
         this.btn05.UseVisualStyleBackColor = false;
         this.btn05.Click += new System.EventHandler(this.GameClick);
         // 
         // btn15
         // 
         this.btn15.BackColor = System.Drawing.Color.DarkSeaGreen;
         this.btn15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btn15.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btn15.Location = new System.Drawing.Point(286, 259);
         this.btn15.Name = "btn15";
         this.btn15.Size = new System.Drawing.Size(50, 50);
         this.btn15.TabIndex = 35;
         this.btn15.UseVisualStyleBackColor = false;
         this.btn15.Click += new System.EventHandler(this.GameClick);
         // 
         // btn25
         // 
         this.btn25.BackColor = System.Drawing.Color.DarkSeaGreen;
         this.btn25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btn25.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btn25.Location = new System.Drawing.Point(286, 203);
         this.btn25.Name = "btn25";
         this.btn25.Size = new System.Drawing.Size(50, 50);
         this.btn25.TabIndex = 34;
         this.btn25.UseVisualStyleBackColor = false;
         this.btn25.Click += new System.EventHandler(this.GameClick);
         // 
         // btn35
         // 
         this.btn35.BackColor = System.Drawing.Color.DarkSeaGreen;
         this.btn35.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btn35.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btn35.Location = new System.Drawing.Point(286, 147);
         this.btn35.Name = "btn35";
         this.btn35.Size = new System.Drawing.Size(50, 50);
         this.btn35.TabIndex = 33;
         this.btn35.UseVisualStyleBackColor = false;
         this.btn35.Click += new System.EventHandler(this.GameClick);
         // 
         // btn45
         // 
         this.btn45.BackColor = System.Drawing.Color.DarkSeaGreen;
         this.btn45.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btn45.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btn45.Location = new System.Drawing.Point(286, 91);
         this.btn45.Name = "btn45";
         this.btn45.Size = new System.Drawing.Size(50, 50);
         this.btn45.TabIndex = 32;
         this.btn45.UseVisualStyleBackColor = false;
         this.btn45.Click += new System.EventHandler(this.GameClick);
         // 
         // btn55
         // 
         this.btn55.BackColor = System.Drawing.Color.DarkSeaGreen;
         this.btn55.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btn55.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btn55.Location = new System.Drawing.Point(286, 35);
         this.btn55.Name = "btn55";
         this.btn55.Size = new System.Drawing.Size(50, 50);
         this.btn55.TabIndex = 31;
         this.btn55.UseVisualStyleBackColor = false;
         this.btn55.Click += new System.EventHandler(this.GameClick);
         // 
         // btn04
         // 
         this.btn04.BackColor = System.Drawing.Color.DarkSeaGreen;
         this.btn04.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btn04.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btn04.Location = new System.Drawing.Point(230, 315);
         this.btn04.Name = "btn04";
         this.btn04.Size = new System.Drawing.Size(50, 50);
         this.btn04.TabIndex = 30;
         this.btn04.UseVisualStyleBackColor = false;
         this.btn04.Click += new System.EventHandler(this.GameClick);
         // 
         // btn14
         // 
         this.btn14.BackColor = System.Drawing.Color.DarkSeaGreen;
         this.btn14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btn14.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btn14.Location = new System.Drawing.Point(230, 259);
         this.btn14.Name = "btn14";
         this.btn14.Size = new System.Drawing.Size(50, 50);
         this.btn14.TabIndex = 29;
         this.btn14.UseVisualStyleBackColor = false;
         this.btn14.Click += new System.EventHandler(this.GameClick);
         // 
         // btn24
         // 
         this.btn24.BackColor = System.Drawing.Color.DarkSeaGreen;
         this.btn24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btn24.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btn24.Location = new System.Drawing.Point(230, 203);
         this.btn24.Name = "btn24";
         this.btn24.Size = new System.Drawing.Size(50, 50);
         this.btn24.TabIndex = 28;
         this.btn24.UseVisualStyleBackColor = false;
         this.btn24.Click += new System.EventHandler(this.GameClick);
         // 
         // btn34
         // 
         this.btn34.BackColor = System.Drawing.Color.DarkSeaGreen;
         this.btn34.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btn34.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btn34.Location = new System.Drawing.Point(230, 147);
         this.btn34.Name = "btn34";
         this.btn34.Size = new System.Drawing.Size(50, 50);
         this.btn34.TabIndex = 27;
         this.btn34.UseVisualStyleBackColor = false;
         this.btn34.Click += new System.EventHandler(this.GameClick);
         // 
         // btn44
         // 
         this.btn44.BackColor = System.Drawing.Color.DarkSeaGreen;
         this.btn44.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btn44.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btn44.Location = new System.Drawing.Point(230, 91);
         this.btn44.Name = "btn44";
         this.btn44.Size = new System.Drawing.Size(50, 50);
         this.btn44.TabIndex = 26;
         this.btn44.UseVisualStyleBackColor = false;
         this.btn44.Click += new System.EventHandler(this.GameClick);
         // 
         // btn54
         // 
         this.btn54.BackColor = System.Drawing.Color.DarkSeaGreen;
         this.btn54.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btn54.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btn54.Location = new System.Drawing.Point(230, 35);
         this.btn54.Name = "btn54";
         this.btn54.Size = new System.Drawing.Size(50, 50);
         this.btn54.TabIndex = 25;
         this.btn54.UseVisualStyleBackColor = false;
         this.btn54.Click += new System.EventHandler(this.GameClick);
         // 
         // btn03
         // 
         this.btn03.BackColor = System.Drawing.Color.DarkSeaGreen;
         this.btn03.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btn03.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btn03.Location = new System.Drawing.Point(174, 315);
         this.btn03.Name = "btn03";
         this.btn03.Size = new System.Drawing.Size(50, 50);
         this.btn03.TabIndex = 24;
         this.btn03.UseVisualStyleBackColor = false;
         this.btn03.Click += new System.EventHandler(this.GameClick);
         // 
         // btn13
         // 
         this.btn13.BackColor = System.Drawing.Color.DarkSeaGreen;
         this.btn13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btn13.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btn13.Location = new System.Drawing.Point(174, 259);
         this.btn13.Name = "btn13";
         this.btn13.Size = new System.Drawing.Size(50, 50);
         this.btn13.TabIndex = 23;
         this.btn13.UseVisualStyleBackColor = false;
         this.btn13.Click += new System.EventHandler(this.GameClick);
         // 
         // btn23
         // 
         this.btn23.BackColor = System.Drawing.Color.DarkSeaGreen;
         this.btn23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btn23.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btn23.Location = new System.Drawing.Point(174, 203);
         this.btn23.Name = "btn23";
         this.btn23.Size = new System.Drawing.Size(50, 50);
         this.btn23.TabIndex = 22;
         this.btn23.UseVisualStyleBackColor = false;
         this.btn23.Click += new System.EventHandler(this.GameClick);
         // 
         // btn33
         // 
         this.btn33.BackColor = System.Drawing.Color.DarkSeaGreen;
         this.btn33.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btn33.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btn33.Location = new System.Drawing.Point(174, 147);
         this.btn33.Name = "btn33";
         this.btn33.Size = new System.Drawing.Size(50, 50);
         this.btn33.TabIndex = 21;
         this.btn33.UseVisualStyleBackColor = false;
         this.btn33.Click += new System.EventHandler(this.GameClick);
         // 
         // btn43
         // 
         this.btn43.BackColor = System.Drawing.Color.DarkSeaGreen;
         this.btn43.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btn43.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btn43.Location = new System.Drawing.Point(174, 91);
         this.btn43.Name = "btn43";
         this.btn43.Size = new System.Drawing.Size(50, 50);
         this.btn43.TabIndex = 20;
         this.btn43.UseVisualStyleBackColor = false;
         this.btn43.Click += new System.EventHandler(this.GameClick);
         // 
         // btn53
         // 
         this.btn53.BackColor = System.Drawing.Color.DarkSeaGreen;
         this.btn53.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btn53.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btn53.Location = new System.Drawing.Point(174, 35);
         this.btn53.Name = "btn53";
         this.btn53.Size = new System.Drawing.Size(50, 50);
         this.btn53.TabIndex = 19;
         this.btn53.UseVisualStyleBackColor = false;
         this.btn53.Click += new System.EventHandler(this.GameClick);
         // 
         // btn02
         // 
         this.btn02.BackColor = System.Drawing.Color.DarkSeaGreen;
         this.btn02.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btn02.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btn02.Location = new System.Drawing.Point(118, 315);
         this.btn02.Name = "btn02";
         this.btn02.Size = new System.Drawing.Size(50, 50);
         this.btn02.TabIndex = 18;
         this.btn02.UseVisualStyleBackColor = false;
         this.btn02.Click += new System.EventHandler(this.GameClick);
         // 
         // btn12
         // 
         this.btn12.BackColor = System.Drawing.Color.DarkSeaGreen;
         this.btn12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btn12.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btn12.Location = new System.Drawing.Point(118, 259);
         this.btn12.Name = "btn12";
         this.btn12.Size = new System.Drawing.Size(50, 50);
         this.btn12.TabIndex = 17;
         this.btn12.UseVisualStyleBackColor = false;
         this.btn12.Click += new System.EventHandler(this.GameClick);
         // 
         // btn22
         // 
         this.btn22.BackColor = System.Drawing.Color.DarkSeaGreen;
         this.btn22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btn22.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btn22.Location = new System.Drawing.Point(118, 203);
         this.btn22.Name = "btn22";
         this.btn22.Size = new System.Drawing.Size(50, 50);
         this.btn22.TabIndex = 16;
         this.btn22.UseVisualStyleBackColor = false;
         this.btn22.Click += new System.EventHandler(this.GameClick);
         // 
         // btn32
         // 
         this.btn32.BackColor = System.Drawing.Color.DarkSeaGreen;
         this.btn32.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btn32.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btn32.Location = new System.Drawing.Point(118, 147);
         this.btn32.Name = "btn32";
         this.btn32.Size = new System.Drawing.Size(50, 50);
         this.btn32.TabIndex = 15;
         this.btn32.UseVisualStyleBackColor = false;
         this.btn32.Click += new System.EventHandler(this.GameClick);
         // 
         // btn42
         // 
         this.btn42.BackColor = System.Drawing.Color.DarkSeaGreen;
         this.btn42.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btn42.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btn42.Location = new System.Drawing.Point(118, 91);
         this.btn42.Name = "btn42";
         this.btn42.Size = new System.Drawing.Size(50, 50);
         this.btn42.TabIndex = 14;
         this.btn42.UseVisualStyleBackColor = false;
         this.btn42.Click += new System.EventHandler(this.GameClick);
         // 
         // btn52
         // 
         this.btn52.BackColor = System.Drawing.Color.DarkSeaGreen;
         this.btn52.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btn52.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btn52.Location = new System.Drawing.Point(118, 35);
         this.btn52.Name = "btn52";
         this.btn52.Size = new System.Drawing.Size(50, 50);
         this.btn52.TabIndex = 13;
         this.btn52.UseVisualStyleBackColor = false;
         this.btn52.Click += new System.EventHandler(this.GameClick);
         // 
         // btn01
         // 
         this.btn01.BackColor = System.Drawing.Color.DarkSeaGreen;
         this.btn01.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btn01.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btn01.Location = new System.Drawing.Point(62, 315);
         this.btn01.Name = "btn01";
         this.btn01.Size = new System.Drawing.Size(50, 50);
         this.btn01.TabIndex = 12;
         this.btn01.UseVisualStyleBackColor = false;
         this.btn01.Click += new System.EventHandler(this.GameClick);
         // 
         // btn11
         // 
         this.btn11.BackColor = System.Drawing.Color.DarkSeaGreen;
         this.btn11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btn11.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btn11.Location = new System.Drawing.Point(62, 259);
         this.btn11.Name = "btn11";
         this.btn11.Size = new System.Drawing.Size(50, 50);
         this.btn11.TabIndex = 11;
         this.btn11.UseVisualStyleBackColor = false;
         this.btn11.Click += new System.EventHandler(this.GameClick);
         // 
         // btn21
         // 
         this.btn21.BackColor = System.Drawing.Color.DarkSeaGreen;
         this.btn21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btn21.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btn21.Location = new System.Drawing.Point(62, 203);
         this.btn21.Name = "btn21";
         this.btn21.Size = new System.Drawing.Size(50, 50);
         this.btn21.TabIndex = 10;
         this.btn21.UseVisualStyleBackColor = false;
         this.btn21.Click += new System.EventHandler(this.GameClick);
         // 
         // btn31
         // 
         this.btn31.BackColor = System.Drawing.Color.DarkSeaGreen;
         this.btn31.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btn31.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btn31.Location = new System.Drawing.Point(62, 147);
         this.btn31.Name = "btn31";
         this.btn31.Size = new System.Drawing.Size(50, 50);
         this.btn31.TabIndex = 9;
         this.btn31.UseVisualStyleBackColor = false;
         this.btn31.Click += new System.EventHandler(this.GameClick);
         // 
         // btn41
         // 
         this.btn41.BackColor = System.Drawing.Color.DarkSeaGreen;
         this.btn41.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btn41.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btn41.Location = new System.Drawing.Point(62, 91);
         this.btn41.Name = "btn41";
         this.btn41.Size = new System.Drawing.Size(50, 50);
         this.btn41.TabIndex = 8;
         this.btn41.UseVisualStyleBackColor = false;
         this.btn41.Click += new System.EventHandler(this.GameClick);
         // 
         // btn51
         // 
         this.btn51.BackColor = System.Drawing.Color.DarkSeaGreen;
         this.btn51.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btn51.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btn51.Location = new System.Drawing.Point(62, 35);
         this.btn51.Name = "btn51";
         this.btn51.Size = new System.Drawing.Size(50, 50);
         this.btn51.TabIndex = 7;
         this.btn51.UseVisualStyleBackColor = false;
         this.btn51.Click += new System.EventHandler(this.GameClick);
         // 
         // btn00
         // 
         this.btn00.BackColor = System.Drawing.Color.DarkSeaGreen;
         this.btn00.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btn00.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btn00.Location = new System.Drawing.Point(6, 315);
         this.btn00.Name = "btn00";
         this.btn00.Size = new System.Drawing.Size(50, 50);
         this.btn00.TabIndex = 6;
         this.btn00.UseVisualStyleBackColor = false;
         this.btn00.Click += new System.EventHandler(this.GameClick);
         // 
         // txtPlayerOneName
         // 
         this.txtPlayerOneName.Location = new System.Drawing.Point(549, 77);
         this.txtPlayerOneName.Name = "txtPlayerOneName";
         this.txtPlayerOneName.Size = new System.Drawing.Size(100, 20);
         this.txtPlayerOneName.TabIndex = 3;
         // 
         // txtPlayerTwoName
         // 
         this.txtPlayerTwoName.Location = new System.Drawing.Point(549, 150);
         this.txtPlayerTwoName.Name = "txtPlayerTwoName";
         this.txtPlayerTwoName.Size = new System.Drawing.Size(100, 20);
         this.txtPlayerTwoName.TabIndex = 4;
         // 
         // lblPlayerOne
         // 
         this.lblPlayerOne.AutoSize = true;
         this.lblPlayerOne.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblPlayerOne.Location = new System.Drawing.Point(442, 74);
         this.lblPlayerOne.Name = "lblPlayerOne";
         this.lblPlayerOne.Size = new System.Drawing.Size(79, 21);
         this.lblPlayerOne.TabIndex = 5;
         this.lblPlayerOne.Text = "Player 1:";
         // 
         // lblPlayerTwo
         // 
         this.lblPlayerTwo.AutoSize = true;
         this.lblPlayerTwo.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblPlayerTwo.Location = new System.Drawing.Point(442, 147);
         this.lblPlayerTwo.Name = "lblPlayerTwo";
         this.lblPlayerTwo.Size = new System.Drawing.Size(79, 21);
         this.lblPlayerTwo.TabIndex = 6;
         this.lblPlayerTwo.Text = "Player 2:";
         // 
         // mnustrpSubExamineArray
         // 
         this.mnustrpSubExamineArray.Enabled = false;
         this.mnustrpSubExamineArray.Name = "mnustrpSubExamineArray";
         this.mnustrpSubExamineArray.Size = new System.Drawing.Size(180, 22);
         this.mnustrpSubExamineArray.Text = "Examine Array";
         // 
         // mnustrpSubExaminePattern
         // 
         this.mnustrpSubExaminePattern.Enabled = false;
         this.mnustrpSubExaminePattern.Name = "mnustrpSubExaminePattern";
         this.mnustrpSubExaminePattern.Size = new System.Drawing.Size(180, 22);
         this.mnustrpSubExaminePattern.Text = "Examine Pattern";
         this.mnustrpSubExaminePattern.Click += new System.EventHandler(this.mnustrpSubExaminePatternBuild_Click);
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.DimGray;
         this.ClientSize = new System.Drawing.Size(686, 422);
         this.Controls.Add(this.lblPlayerTwo);
         this.Controls.Add(this.lblPlayerOne);
         this.Controls.Add(this.txtPlayerTwoName);
         this.Controls.Add(this.txtPlayerOneName);
         this.Controls.Add(this.gbxBoard);
         this.Controls.Add(this.mnustrpControls);
         this.MainMenuStrip = this.mnustrpControls;
         this.Name = "Form1";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Form1";
         this.Load += new System.EventHandler(this.Form1_Load);
         this.mnustrpControls.ResumeLayout(false);
         this.mnustrpControls.PerformLayout();
         this.gbxBoard.ResumeLayout(false);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

        #endregion

        private System.Windows.Forms.MenuStrip mnustrpControls;
        private System.Windows.Forms.ToolStripMenuItem mnustrpReset;
        private System.Windows.Forms.ToolStripMenuItem mnustrpDiag;
        private System.Windows.Forms.ToolStripMenuItem mnustrpSubDiagEnable;
        private System.Windows.Forms.ToolStripMenuItem mnustrpExit;
        private System.Windows.Forms.Button btn50;
        private System.Windows.Forms.Button btn40;
        private System.Windows.Forms.Button btn30;
        private System.Windows.Forms.Button btn20;
        private System.Windows.Forms.Button btn10;
        private System.Windows.Forms.GroupBox gbxBoard;
        private System.Windows.Forms.Button btn06;
        private System.Windows.Forms.Button btn16;
        private System.Windows.Forms.Button btn26;
        private System.Windows.Forms.Button btn36;
        private System.Windows.Forms.Button btn46;
        private System.Windows.Forms.Button btn56;
        private System.Windows.Forms.Button btn05;
        private System.Windows.Forms.Button btn15;
        private System.Windows.Forms.Button btn25;
        private System.Windows.Forms.Button btn35;
        private System.Windows.Forms.Button btn45;
        private System.Windows.Forms.Button btn55;
        private System.Windows.Forms.Button btn04;
        private System.Windows.Forms.Button btn14;
        private System.Windows.Forms.Button btn24;
        private System.Windows.Forms.Button btn34;
        private System.Windows.Forms.Button btn44;
        private System.Windows.Forms.Button btn54;
        private System.Windows.Forms.Button btn03;
        private System.Windows.Forms.Button btn13;
        private System.Windows.Forms.Button btn23;
        private System.Windows.Forms.Button btn33;
        private System.Windows.Forms.Button btn43;
        private System.Windows.Forms.Button btn53;
        private System.Windows.Forms.Button btn02;
        private System.Windows.Forms.Button btn12;
        private System.Windows.Forms.Button btn22;
        private System.Windows.Forms.Button btn32;
        private System.Windows.Forms.Button btn42;
        private System.Windows.Forms.Button btn52;
        private System.Windows.Forms.Button btn01;
        private System.Windows.Forms.Button btn11;
        private System.Windows.Forms.Button btn21;
        private System.Windows.Forms.Button btn31;
        private System.Windows.Forms.Button btn41;
        private System.Windows.Forms.Button btn51;
        private System.Windows.Forms.Button btn00;
        private System.Windows.Forms.TextBox txtPlayerOneName;
        private System.Windows.Forms.TextBox txtPlayerTwoName;
        private System.Windows.Forms.Label lblPlayerOne;
        private System.Windows.Forms.Label lblPlayerTwo;
      private System.Windows.Forms.ToolStripMenuItem mnustrpSubExamineArray;
      private System.Windows.Forms.ToolStripMenuItem mnustrpSubExaminePattern;
   }
}

