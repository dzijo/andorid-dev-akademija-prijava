namespace Pkmn
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.startButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.megaCount = new System.Windows.Forms.TextBox();
            this.OUCount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.newPlayer = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(356, 620);
            this.panel1.TabIndex = 0;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(293, 9);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 28);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "RNG";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(781, 9);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(83, 28);
            this.resetButton.TabIndex = 1;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(491, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(123, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // megaCount
            // 
            this.megaCount.Location = new System.Drawing.Point(60, 14);
            this.megaCount.Name = "megaCount";
            this.megaCount.Size = new System.Drawing.Size(30, 20);
            this.megaCount.TabIndex = 3;
            this.megaCount.Click += new System.EventHandler(this.megaCount_Click);
            this.megaCount.TextChanged += new System.EventHandler(this.megaCount_TextChanged);
            this.megaCount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.megaCount_KeyDown);
            // 
            // OUCount
            // 
            this.OUCount.Location = new System.Drawing.Point(138, 14);
            this.OUCount.Name = "OUCount";
            this.OUCount.Size = new System.Drawing.Size(30, 20);
            this.OUCount.TabIndex = 4;
            this.OUCount.Click += new System.EventHandler(this.OUCount_Click);
            this.OUCount.TextChanged += new System.EventHandler(this.OUCount_TextChanged);
            this.OUCount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OUCount_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mega:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Others:";
            // 
            // newPlayer
            // 
            this.newPlayer.Location = new System.Drawing.Point(406, 9);
            this.newPlayer.Name = "newPlayer";
            this.newPlayer.Size = new System.Drawing.Size(79, 28);
            this.newPlayer.TabIndex = 11;
            this.newPlayer.Text = "Novi igrač";
            this.newPlayer.UseVisualStyleBackColor = true;
            this.newPlayer.Click += new System.EventHandler(this.newPlayer_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(406, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(416, 620);
            this.panel2.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(403, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Trenutni igrač: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(487, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 711);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.newPlayer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OUCount);
            this.Controls.Add(this.megaCount);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Pokémon Draft";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox megaCount;
        private System.Windows.Forms.TextBox OUCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button newPlayer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

