using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nonogram
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            label1.Left = (this.ClientSize.Width - label1.Width) / 2;
            textBox1.Left = (this.ClientSize.Width - textBox1.Width) / 2;
            buttonNext.Left = (this.ClientSize.Width - buttonNext.Width) / 2;
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DialogResult = DialogResult.OK;
            }
        }
    }
}
