using NumberGenerator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomGenerator
{
    public partial class Preferenes : Form
    {
        public Preferenes()
        {
            InitializeComponent();
            txtBoxQty.Text = Properties.Settings.Default.Quantity;
            txtBoxCharacters.Text = Properties.Settings.Default.CharacterQuantity;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Quantity = txtBoxQty.Text;
            Properties.Settings.Default.CharacterQuantity = txtBoxCharacters.Text;
            Properties.Settings.Default.Save();

            MessageBox.Show("Settings are Saved!", "Success");

            Form1 form1 = new Form1();
            form1.Reload();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
