namespace Nonogram
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
            this.comboBoxHeigth = new System.Windows.Forms.ComboBox();
            this.comboBoxWidth = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelSide = new System.Windows.Forms.Panel();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonFERIT = new System.Windows.Forms.Button();
            this.buttonSolve = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonGrid = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxHeigth
            // 
            this.comboBoxHeigth.FormattingEnabled = true;
            this.comboBoxHeigth.Location = new System.Drawing.Point(12, 12);
            this.comboBoxHeigth.Name = "comboBoxHeigth";
            this.comboBoxHeigth.Size = new System.Drawing.Size(37, 21);
            this.comboBoxHeigth.TabIndex = 0;
            // 
            // comboBoxWidth
            // 
            this.comboBoxWidth.FormattingEnabled = true;
            this.comboBoxWidth.Location = new System.Drawing.Point(112, 12);
            this.comboBoxWidth.Name = "comboBoxWidth";
            this.comboBoxWidth.Size = new System.Drawing.Size(35, 21);
            this.comboBoxWidth.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Širina";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Visina";
            // 
            // panelButtons
            // 
            this.panelButtons.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panelButtons.Location = new System.Drawing.Point(270, 220);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(720, 720);
            this.panelButtons.TabIndex = 4;
            // 
            // panelTop
            // 
            this.panelTop.Location = new System.Drawing.Point(270, 70);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(720, 140);
            this.panelTop.TabIndex = 5;
            // 
            // panelSide
            // 
            this.panelSide.Location = new System.Drawing.Point(120, 220);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(140, 720);
            this.panelSide.TabIndex = 6;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(185, 12);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 7;
            this.buttonStart.Text = "Picture";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonFERIT
            // 
            this.buttonFERIT.Location = new System.Drawing.Point(185, 41);
            this.buttonFERIT.Name = "buttonFERIT";
            this.buttonFERIT.Size = new System.Drawing.Size(75, 23);
            this.buttonFERIT.TabIndex = 8;
            this.buttonFERIT.Text = "FERIT";
            this.buttonFERIT.UseVisualStyleBackColor = true;
            this.buttonFERIT.Click += new System.EventHandler(this.buttonFERIT_Click);
            // 
            // buttonSolve
            // 
            this.buttonSolve.Location = new System.Drawing.Point(840, 12);
            this.buttonSolve.Name = "buttonSolve";
            this.buttonSolve.Size = new System.Drawing.Size(75, 23);
            this.buttonSolve.TabIndex = 10;
            this.buttonSolve.Text = "Solve";
            this.buttonSolve.UseVisualStyleBackColor = true;
            this.buttonSolve.Click += new System.EventHandler(this.buttonSolve_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(921, 12);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 11;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonGrid
            // 
            this.buttonGrid.Location = new System.Drawing.Point(270, 12);
            this.buttonGrid.Name = "buttonGrid";
            this.buttonGrid.Size = new System.Drawing.Size(75, 23);
            this.buttonGrid.TabIndex = 12;
            this.buttonGrid.Text = "Grid";
            this.buttonGrid.UseVisualStyleBackColor = true;
            this.buttonGrid.Click += new System.EventHandler(this.buttonGrid_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 961);
            this.Controls.Add(this.buttonGrid);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonSolve);
            this.Controls.Add(this.buttonFERIT);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.panelSide);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxWidth);
            this.Controls.Add(this.comboBoxHeigth);
            this.Name = "Form1";
            this.Text = "Nonogram Solver";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxHeigth;
        private System.Windows.Forms.ComboBox comboBoxWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonFERIT;
        private System.Windows.Forms.Button buttonSolve;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonGrid;
    }
}

