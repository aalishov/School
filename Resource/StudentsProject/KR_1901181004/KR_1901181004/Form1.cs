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
            if (radioList.Checked && btnAdd.Text=="Добавяне")
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
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (radioList.Checked)
            {
                txtInput.Text = listBox1.Items[listBox1.SelectedIndex].ToString();
                txtInput.Focus();
                btnAdd.Text = "Актуализация на запис";
            }
        }
    }
}
