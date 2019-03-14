namespace DnD_Fight_Assist
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxPlayers = new System.Windows.Forms.ComboBox();
            this.buttonPlayerSelect = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBoxMonsters = new System.Windows.Forms.ComboBox();
            this.buttonMonsterSelect = new System.Windows.Forms.Button();
            this.textBoxAtkRoll = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDmgRoll = new System.Windows.Forms.TextBox();
            this.textBoxSaveRoll = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.textBoxRoll = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.comboBoxAdvantage = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBoxPlayers);
            this.panel1.Controls.Add(this.buttonPlayerSelect);
            this.panel1.Location = new System.Drawing.Point(39, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 499);
            this.panel1.TabIndex = 0;
            // 
            // comboBoxPlayers
            // 
            this.comboBoxPlayers.FormattingEnabled = true;
            this.comboBoxPlayers.Location = new System.Drawing.Point(162, 22);
            this.comboBoxPlayers.Name = "comboBoxPlayers";
            this.comboBoxPlayers.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPlayers.TabIndex = 1;
            // 
            // buttonPlayerSelect
            // 
            this.buttonPlayerSelect.Location = new System.Drawing.Point(23, 20);
            this.buttonPlayerSelect.Name = "buttonPlayerSelect";
            this.buttonPlayerSelect.Size = new System.Drawing.Size(110, 23);
            this.buttonPlayerSelect.TabIndex = 0;
            this.buttonPlayerSelect.Text = "Select Player";
            this.buttonPlayerSelect.UseVisualStyleBackColor = true;
            this.buttonPlayerSelect.Click += new System.EventHandler(this.buttonPlayerSelect_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.comboBoxMonsters);
            this.panel2.Controls.Add(this.buttonMonsterSelect);
            this.panel2.Location = new System.Drawing.Point(614, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(367, 499);
            this.panel2.TabIndex = 1;
            // 
            // comboBoxMonsters
            // 
            this.comboBoxMonsters.FormattingEnabled = true;
            this.comboBoxMonsters.Location = new System.Drawing.Point(182, 22);
            this.comboBoxMonsters.Name = "comboBoxMonsters";
            this.comboBoxMonsters.Size = new System.Drawing.Size(163, 21);
            this.comboBoxMonsters.TabIndex = 1;
            // 
            // buttonMonsterSelect
            // 
            this.buttonMonsterSelect.Location = new System.Drawing.Point(23, 20);
            this.buttonMonsterSelect.Name = "buttonMonsterSelect";
            this.buttonMonsterSelect.Size = new System.Drawing.Size(126, 23);
            this.buttonMonsterSelect.TabIndex = 0;
            this.buttonMonsterSelect.Text = "Select Monster";
            this.buttonMonsterSelect.UseVisualStyleBackColor = true;
            this.buttonMonsterSelect.Click += new System.EventHandler(this.buttonMonsterSelect_Click);
            // 
            // textBoxAtkRoll
            // 
            this.textBoxAtkRoll.Location = new System.Drawing.Point(484, 19);
            this.textBoxAtkRoll.Name = "textBoxAtkRoll";
            this.textBoxAtkRoll.ReadOnly = true;
            this.textBoxAtkRoll.Size = new System.Drawing.Size(90, 20);
            this.textBoxAtkRoll.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(421, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Attack roll:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(412, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Damage roll:";
            // 
            // textBoxDmgRoll
            // 
            this.textBoxDmgRoll.Location = new System.Drawing.Point(484, 45);
            this.textBoxDmgRoll.Name = "textBoxDmgRoll";
            this.textBoxDmgRoll.ReadOnly = true;
            this.textBoxDmgRoll.Size = new System.Drawing.Size(90, 20);
            this.textBoxDmgRoll.TabIndex = 5;
            // 
            // textBoxSaveRoll
            // 
            this.textBoxSaveRoll.Location = new System.Drawing.Point(484, 71);
            this.textBoxSaveRoll.Name = "textBoxSaveRoll";
            this.textBoxSaveRoll.ReadOnly = true;
            this.textBoxSaveRoll.Size = new System.Drawing.Size(90, 20);
            this.textBoxSaveRoll.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(427, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Save roll:";
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(901, 15);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(80, 26);
            this.buttonReset.TabIndex = 8;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // textBoxRoll
            // 
            this.textBoxRoll.Font = new System.Drawing.Font("Microsoft Sans Serif", 120F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRoll.Location = new System.Drawing.Point(408, 235);
            this.textBoxRoll.Multiline = true;
            this.textBoxRoll.Name = "textBoxRoll";
            this.textBoxRoll.Size = new System.Drawing.Size(200, 200);
            this.textBoxRoll.TabIndex = 9;
            this.textBoxRoll.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // comboBoxAdvantage
            // 
            this.comboBoxAdvantage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAdvantage.FormattingEnabled = true;
            this.comboBoxAdvantage.Items.AddRange(new object[] {
            "Disadvantage",
            "Neutral",
            "Advantage"});
            this.comboBoxAdvantage.Location = new System.Drawing.Point(453, 111);
            this.comboBoxAdvantage.Name = "comboBoxAdvantage";
            this.comboBoxAdvantage.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAdvantage.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 647);
            this.Controls.Add(this.comboBoxAdvantage);
            this.Controls.Add(this.textBoxRoll);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.textBoxSaveRoll);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxDmgRoll);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxAtkRoll);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " D&F Fight Helper";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxAtkRoll;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxDmgRoll;
        private System.Windows.Forms.TextBox textBoxSaveRoll;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxMonsters;
        private System.Windows.Forms.Button buttonMonsterSelect;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.ComboBox comboBoxPlayers;
        private System.Windows.Forms.Button buttonPlayerSelect;
        private System.Windows.Forms.TextBox textBoxRoll;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ComboBox comboBoxAdvantage;
    }
}

