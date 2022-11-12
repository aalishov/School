using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KR_1901181004
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioList.Checked = true;
            radioAdd.Checked = true;
            btnEdit.Enabled = false;
            btnDel.Enabled = false;
        }

        private void radioAdd_CheckedChanged(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            btnEdit.Enabled = false;
            btnDel.Enabled = false;
        }

        private void radioDel_CheckedChanged(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDel.Enabled = true;
        }

        private void radioEdit_CheckedChanged(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            btnEdit.Enabled = true;
            btnDel.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (radioList.Checked && btnAdd.Text == "Добавяне")
            {
                bool f = false;
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    if (listBox1.Items[i].ToString() == txtInput.Text)
                    {
                        f = true;
                    }
                }
                if (!f)
                {
                    listBox1.Items.Add(txtInput.Text);
                }
                else
                {
                    MessageBox.Show("Елемента се дублира!",
                                      "Грешка при добавяне", 0, MessageBoxIcon.Error);
                }
                txtInput.Text = "";
                txtInput.Focus();
                //if (listBox1.Items.Count > 0) { btnClear.Enabled = true; }
            }
            else if (radioCombo.Checked && btnAdd.Text == "Добавяне")
            {
                bool f = false;
                for (int i = 0; i < comboBox1.Items.Count; i++)
                {
                    if (comboBox1.Items[i].ToString() == txtInput.Text)
                    {
                        f = true;
                    }
                }
                if (!f)
                {
                    comboBox1.Items.Add(txtInput.Text);
                }
                else
                {
                    MessageBox.Show("Елемента се дублира!",
                                      "Грешка при добавяне", 0, MessageBoxIcon.Error);
                }
                txtInput.Text = "";
                txtInput.Focus();
            }
            else if (radioList.Checked && btnAdd.Text == "Актуализация")
            {
                listBox1.Items[listBox1.SelectedIndex] = txtInput.Text;
                txtInput.Text = "";
                listBox1.SelectedIndex = -1;
                comboBox1.SelectedIndex = -1;
                btnAdd.Text = "Добавяне";
                btnAdd.Enabled = false;
                btnEdit.Enabled = true;
            }
            else if (radioCombo.Checked && btnAdd.Text == "Актуализация")
            {
                comboBox1.Items[comboBox1.SelectedIndex] = txtInput.Text;
                txtInput.Text = "";
                listBox1.SelectedIndex = -1;
                comboBox1.SelectedIndex = -1;
                btnAdd.Text = "Добавяне";
                btnAdd.Enabled = false;
                btnEdit.Enabled = true;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (radioList.Checked && listBox1.SelectedIndex >= 0)
            {
                txtInput.Text = listBox1.Items[listBox1.SelectedIndex].ToString();
                txtInput.Focus();
                btnAdd.Enabled = true;
                btnAdd.Text = "Актуализация";
                btnEdit.Enabled = false;
            }
            else if (radioCombo.Checked && comboBox1.SelectedIndex >= 0)
            {
                txtInput.Text = comboBox1.Items[comboBox1.SelectedIndex].ToString();
                txtInput.Focus();
                btnAdd.Enabled = true;
                btnAdd.Text = "Актуализация";
                btnEdit.Enabled = false;
            }
            else
            {
                MessageBox.Show("Не е избран запис!");
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (radioList.Checked && listBox1.SelectedIndex >= 0)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            else if (radioCombo.Checked && comboBox1.SelectedIndex >= 0)
            {
                comboBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void listBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (listBox1.SelectedIndex != -1 && e.KeyChar == (char)Keys.Delete)
            {
                btnDel_Click(sender, e);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
