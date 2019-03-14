using Pkmn;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pkmn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (megaCount.Text.Equals(""))
            {
                megaCount.Text = "0";
            }
            if (OUCount.Text.Equals(""))
            {
                OUCount.Text = "0";
            }
            textBox1.Select();
            label3.Hide();
        }

        int left = 10;
        int top = 10;

        List<Button> megasButtons = new List<Button>();
        List<Button> othersButtons = new List<Button>();
        List<TextBox> textBoxes = new List<TextBox>();
        List<Label> labels = new List<Label>();
        public void AddNewButton1(int top, int left, string text)
        {
            Button newPanelButton = new Button();
            panel1.Controls.Add(newPanelButton);
            newPanelButton.Click += new System.EventHandler(this.NewPanelButton_Click);
            newPanelButton.Left = left;
            newPanelButton.Top = top;
            newPanelButton.Text = text;
            newPanelButton.Width = 100;
            newPanelButton.BackColor = Color.DimGray;
            newPanelButton.ForeColor = default(Color);
            newPanelButton.UseVisualStyleBackColor = true;
            megasButtons.Add(newPanelButton);
        }
        public void AddNewButton2(int top, int left, string text)
        {
            Button newPanelButton = new Button();
            panel1.Controls.Add(newPanelButton);
            newPanelButton.Click += new System.EventHandler(this.NewPanelButton_Click);
            newPanelButton.Enabled = false;
            newPanelButton.Left = left;
            newPanelButton.Top = top;
            newPanelButton.Text = text;
            newPanelButton.Width = 100;
            newPanelButton.BackColor = Color.DimGray;
            newPanelButton.ForeColor = default(Color);
            newPanelButton.UseVisualStyleBackColor = true;
            othersButtons.Add(newPanelButton);
        }

        public void AddNewLabel1(int top, int left, string text)
        {
            Label newPanelLabel = new Label();
            newPanelLabel.Left = left;
            newPanelLabel.Top = top;
            newPanelLabel.Text = text;
            panel1.Controls.Add(newPanelLabel);
        }

        public void AddNewLabel2(int top, int left, string text)
        {
            Label newPanelLabel = new Label();
            newPanelLabel.Left = left;
            newPanelLabel.Top = top;
            newPanelLabel.Text = text;
            panel2.Controls.Add(newPanelLabel);
            labels.Add(newPanelLabel);
        }

        public void AddNewTextBox(int top, int left)
        {
            TextBox newTextBox = new TextBox();
            newTextBox.Left = left;
            newTextBox.Top = top;
            newTextBox.Width = 300;
            newTextBox.Height = 85;
            newTextBox.Multiline = true;
            newTextBox.ReadOnly = true;
            textBoxes.Add(newTextBox);
            panel2.Controls.Add(newTextBox);
        }

        public static Random rng = new Random();
        public static void Shuffle(List<int> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                int value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        int currentPlayer = 0, pkmnPicked = 0;
        bool flag = false, flag2 = true;
        void changePlayer()
        {
            if (currentPlayer >= textBoxes.Count() - 1 || currentPlayer == 0)
            {
                if (!flag2)
                {
                    flag2 = true;
                    return;
                }
                else
                {
                    flag = !flag;
                    flag2 = false;
                }
            }
            if (flag)
            {
                currentPlayer++;
            }
            else
            {
                currentPlayer--;
            }
        }
        private void NewPanelButton_Click(object sender, EventArgs e)
        {
            Button currentButton = (Button)sender;
            currentButton.Enabled = false;
            textBoxes[currentPlayer].Text += currentButton.Text + "\r\n";
            changePlayer();
            label4.Text = labels[currentPlayer].Text;
            pkmnPicked++;
            //if (pkmnPicked == textBoxes.Count())
            //{
            //    foreach (Button button in megasButtons)
            //    {
            //        button.Enabled = false;
            //    }
            //    foreach (Button button in othersButtons)
            //    {
            //        button.Enabled = true;
            //    }
            //}
            if (pkmnPicked == textBoxes.Count() * 6)
            {
                foreach (Button button in othersButtons)
                {
                    button.Enabled = false;
                }
                label4.Text = "";
                setClipboard();
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (megaCount.Text.Equals(""))
            {
                megaCount.Text = "0";
            }
            if (OUCount.Text.Equals(""))
            {
                OUCount.Text = "0";
            }
            int megasCount = int.Parse(megaCount.Text);
            int othersCount = int.Parse(OUCount.Text);
            if (labels.Count <= 2)
            {
                MessageBox.Show("Add more players", "Not enough players", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //if (megasCount < labels.Count + 1)
            //{
            //    MessageBox.Show("Add more megas", "Not enough megas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            if (othersCount < labels.Count * 5 + 2)
            {
                MessageBox.Show("Add more others", "Not enough others", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            top = 10;
            currentPlayer = 0;
            pkmnPicked = 0;
            flag = false;
            flag2 = true;
            List<int> playerOrder = Enumerable.Range(0, labels.Count()).ToList();
            Shuffle(playerOrder);
            List<Label> tempLabels = new List<Label>();
            for (int i = 0; i < labels.Count(); i++)
            {
                tempLabels.Add(new Label());
                tempLabels[i].Text = labels[playerOrder[i]].Text;
            }
            for (int i = 0; i < labels.Count(); i++)
            {
                labels[i].Text = tempLabels[i].Text;
            }
            tempLabels.Clear();
            AddNewLabel1(10, 40, "Megas:");
            AddNewLabel1(10, 140, "Other:");
            List<int> randomMegas = new List<int>(megasCount);
            List<int> randomOthers = new List<int>(othersCount);
            List<string> chosenMegas = new List<string>();
            List<string> chosenOthers = new List<string>();
            //for (int i = 0; i < megasCount; ++i)
            //{
            //    int curr = new int();
            //    do
            //    {
            //        curr = rng.Next(0, Lists.megas.Count);
            //    } while (randomMegas.Contains(curr));
            //    randomMegas.Add(curr);
            //    chosenMegas.Add(Lists.megas[randomMegas[i]]);
            //    //AddNewButton1(top += 25, left, Lists.megas[randomMegas[i]]);
            //}
            //chosenMegas.Sort();
            //for (int i = 0; i < megasCount; ++i)
            //{
            //    AddNewButton1(top += 25, left, chosenMegas[i]);
            //    if (i == 21)
            //    {
            //        left += 100;
            //    }
            //}
            left = 10;
            top = 10;
            for (int i = 0; i < othersCount; ++i)
            {
                int curr = new int();
                do
                {
                    curr = rng.Next(0, Lists.all.Count);
                } while (randomOthers.Contains(curr));
                randomOthers.Add(curr);
                chosenOthers.Add(Lists.all[randomOthers[i]]);
                //AddNewButton2(top += 25, left + 100, Lists.all[randomOthers[i]]);
            }
            chosenOthers.Sort();
            for (int i = 0; i < othersCount; ++i)
            {
                AddNewButton2(top += 25, left + 100, chosenOthers[i]);
                if (i == 21)
                {
                    left += 100;
                    top = 10;
                }
            }
            startButton.Enabled = false;
            newPlayer.Enabled = false;
            textBox1.Clear();
            textBox1.Enabled = false;
            label4.Text = labels[currentPlayer].Text;
            label3.Show();

            foreach (Button button in othersButtons)
            {
                button.Enabled = true;
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            startButton.Enabled = true;
            panel2.Controls.Clear();
            newPlayer.Enabled = true;
            textBoxes.Clear();
            labels.Clear();
            megasButtons.Clear();
            othersButtons.Clear();
            textBox1.Enabled = true;
            top = 10;
            left = 10;
            currentPlayer = 0;
            pkmnPicked = 0;
            label3.Hide();
            label4.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void megaCount_TextChanged(object sender, EventArgs e)
        {

        }

        private void megaCount_Click(object sender, EventArgs e)
        {
            megaCount.Text = "";
        }

        private void OUCount_TextChanged(object sender, EventArgs e)
        {

        }
        private void OUCount_Click(object sender, EventArgs e)
        {
            OUCount.Text = "";
        }

        private void megaCount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                OUCount.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void OUCount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                startButton.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                newPlayer.PerformClick();
                textBox1.Clear();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void newPlayer_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Enter a name", "No name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                AddNewLabel2(top, left, textBox1.Text);
                AddNewTextBox(top + 25, left);
                top += 130;
            }
        }

        private void setClipboard()
        {
            string t = "";
            for (int i = 0; i < labels.Count; ++i)
            {
                t += labels[i].Text + "\r\n" + textBoxes[i].Text.Replace("\r\n", ", ");
                t = t.Substring(0, t.Length - 2);
                t += "\r\n" + "\r\n";
            }
            Clipboard.SetText(t);
        }
    }
}
