using RandomGenerator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;

namespace NumberGenerator
{
    public partial class Form1 : Form
    {
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();

            grpBxSelection.Visible = false;

            #region Checked Box Stuff
            var items = checkedListBox1.Items.Count;
            for (int i = 0; i < items; i++)
            {
                checkedListBox1.SetItemChecked(i, true);
            }

            checkedListBox1.SetItemChecked(2, false);
            checkedListBox1.SetItemChecked(3, false);
            #endregion

            rdBtnGuid.Checked = true;
            txtQty.Text = RandomGenerator.Properties.Settings.Default.Quantity;
            txtCharLength.Text = RandomGenerator.Properties.Settings.Default.CharacterQuantity;


            var lengthNullChecked = string.IsNullOrEmpty(txtQty.Text) ? "0" : txtQty.Text;
            int length = int.Parse(lengthNullChecked);
            string value = string.Join("\n", Enumerable.Range(1, length).Select(_ => Guid.NewGuid().ToString()));
            richTextBox1.Text = value;
        }

        private void rdBtnString_CheckedChanged(object sender, EventArgs e)
        {
            checkedListBox1.Show();
            grpBxSelection.Visible = true;
            grpBxChars.Visible = true;

            richTextBox1.Text = "";
            var lengthNullChecked = string.IsNullOrEmpty(txtQty.Text) ? "0" : txtQty.Text;
            var numNullChecked = string.IsNullOrEmpty(txtCharLength.Text) ? "0" : txtCharLength.Text;

            int length = int.Parse(lengthNullChecked);
            int characterCount = int.Parse(numNullChecked);

            if (rdBtnString.Checked || rdBtnNumber.Checked)
            {
                var value = string.Join("\n", Enumerable.Range(0, length)
                                                        .Select(_ => GenerateRandomString(characterCount)));
                richTextBox1.Text = value;
            }
            else
            {
                richTextBox1.Text = string.Empty;
            }
        }

        private void rdBtnNumber_CheckedChanged(object sender, EventArgs e)
        {
            checkedListBox1.Hide();
            grpBxSelection.Visible = false;
            grpBxChars.Visible = true;

            richTextBox1.Text = "";
            var lengthNullChecked = string.IsNullOrEmpty(txtQty.Text) ? "0" : txtQty.Text;
            var numNullChecked = string.IsNullOrEmpty(txtCharLength.Text) ? "0" : txtCharLength.Text;

            int length = int.Parse(lengthNullChecked);
            int characterCount = int.Parse(numNullChecked);

            if (rdBtnString.Checked || rdBtnNumber.Checked)
            {
                var value = string.Join("\n", Enumerable.Range(0, length)
                                                        .Select(_ => GenerateRandomString(characterCount)));
                richTextBox1.Text = value;
            }
            else
            {
                richTextBox1.Text = string.Empty;
            }
        }

        private void rdBtnGuid_CheckedChanged(object sender, EventArgs e)
        {
            checkedListBox1.Hide();
            grpBxSelection.Visible = false;
            grpBxChars.Visible = false;

            richTextBox1.Text = "";
            var lengthNullChecked = string.IsNullOrEmpty(txtQty.Text) ? "0" : txtQty.Text;
            var numNullChecked = string.IsNullOrEmpty(txtCharLength.Text) ? "0" : txtCharLength.Text;

            int length = int.Parse(lengthNullChecked);

            if (rdBtnGuid.Checked)
            {
                string value = string.Join("\n", Enumerable.Range(1, length).Select(_ => Guid.NewGuid().ToString()));
                richTextBox1.Text = value;
            }
            else
            {
                richTextBox1.Text = string.Empty;
            }
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            var lengthNullChecked = string.IsNullOrEmpty(txtQty.Text) ? "0" : txtQty.Text;
            var numNullChecked = string.IsNullOrEmpty(txtCharLength.Text) ? "0" : txtCharLength.Text;

            int length = int.Parse(lengthNullChecked);
            int characterCount = int.Parse(numNullChecked);

            if (rdBtnGuid.Checked)
            {
                string value = string.Join("\n", Enumerable.Range(1, length).Select(_ => Guid.NewGuid().ToString()));
                richTextBox1.Text = value;
            }
            else if (rdBtnString.Checked || rdBtnNumber.Checked)
            {
                var value = string.Join("\n", Enumerable.Range(0, length)
                                                        .Select(_ => GenerateRandomString(characterCount)));
                richTextBox1.Text = value;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public string GenerateRandomString(int length)
        {
            string chars = "";

            if (rdBtnNumber.Checked)
            {
                chars += "1234567890";
            }
            else
            {
                var scenarios = GetScenarios();

                if (scenarios.Contains("SMALL"))
                {
                    chars += "abcdefghijklmnopqrstuvwxyz";
                }
                if (scenarios.Contains("CAPITAL"))
                {
                    chars += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                }
                if (scenarios.Contains("NUMBERS"))
                {
                    chars += "1234567890";
                }
                if (scenarios.Contains("SPECIAL"))
                {
                    chars += "!@#$%^&*()_+{}[]|\\:;\"'<>,.?/";
                }
            }

            return new string(Enumerable.Repeat(0, length) // Repeat 0 instead of chars
                               .Select(_ => chars[random.Next(chars.Length)])
                               .ToArray());
        }

        private string GetScenarios()
        {
            var scenarios = new List<string>
            {
                "STR"
            };
            var inputList = checkedListBox1.CheckedItems;
            if (inputList.Count > 0)
            {
                if (inputList.Contains("Small Letters"))
                {
                    scenarios.Add("SMALL");
                }
                if (inputList.Contains("Capital Letters"))
                {
                    scenarios.Add("CAPITAL");
                }
                if (inputList.Contains("Numbers"))
                {
                    scenarios.Add("NUMBERS");
                }
                if (inputList.Contains("Special Characters"))
                {
                    scenarios.Add("SPECIAL");
                }
                return string.Join("_", scenarios);
            }
            else
            {
                scenarios.Add("CAPITAL");
                return string.Join("_", scenarios);
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var lengthNullChecked = string.IsNullOrEmpty(txtQty.Text) ? "0" : txtQty.Text;
            int length = int.Parse(lengthNullChecked);
            var numNullChecked = string.IsNullOrEmpty(txtCharLength.Text) ? "0" : txtCharLength.Text;
            int characterCount = int.Parse(numNullChecked);

            if (checkedListBox1.CheckedItems.Count == 0)
            {
                MessageBox.Show("Please select a Combination", "ERROR", MessageBoxButtons.OK);
                checkedListBox1.SetItemChecked(0, true);
                var value = string.Join("\n", Enumerable.Range(0, length)
                                        .Select(_ => GenerateRandomString(characterCount)));
                richTextBox1.Text = value;

                return;
            }
            richTextBox1.Text = "";


            if (rdBtnString.Checked || rdBtnNumber.Checked)
            {
                var value = string.Join("\n", Enumerable.Range(0, length)
                                                        .Select(_ => GenerateRandomString(characterCount)));
                richTextBox1.Text = value;
            }
            else
            {
                richTextBox1.Text = "";
            }
        }

        private void txtCharLength_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            int length = int.Parse(txtQty.Text);
            var num = string.IsNullOrEmpty(txtCharLength.Text) ? "0" : txtCharLength.Text;
            int characterCount = int.Parse(num);

            if (rdBtnString.Checked || rdBtnNumber.Checked)
            {
                var value = string.Join("\n", Enumerable.Range(0, length)
                                                        .Select(_ => GenerateRandomString(characterCount)));
                richTextBox1.Text = value;
            }
            else
            {
                richTextBox1.Text = string.Empty;
            }
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            var lengthNullChecked = string.IsNullOrEmpty(txtQty.Text) ? "0" : txtQty.Text;
            var numNullChecked = string.IsNullOrEmpty(txtCharLength.Text) ? "0" : txtCharLength.Text;

            int length = int.Parse(lengthNullChecked);
            int characterCount = int.Parse(numNullChecked);

            if (rdBtnGuid.Checked)
            {
                string value = string.Join("\n", Enumerable.Range(1, length).Select(_ => Guid.NewGuid().ToString()));
                richTextBox1.Text = value;
            }
            else if (rdBtnString.Checked || rdBtnNumber.Checked)
            {
                var value = string.Join("\n", Enumerable.Range(0, length)
                                                        .Select(_ => GenerateRandomString(characterCount)));
                richTextBox1.Text = value;
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Email: ddpro123@outlook.com \n \n Version: 1.1", "Made By Danny!", MessageBoxButtons.OK);
        }

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var pref = new Preferenes();
            pref.ShowDialog();
        }
        public void Reload()
        {
            txtQty.Text = RandomGenerator.Properties.Settings.Default.Quantity;
            txtCharLength.Text = RandomGenerator.Properties.Settings.Default.CharacterQuantity;

            Refresh();
            Invalidate();
        }
    }
}
