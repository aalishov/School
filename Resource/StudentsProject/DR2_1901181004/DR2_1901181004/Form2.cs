using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DR2_1901181004
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioEdit.Checked && listBox1.SelectedIndex != -1)
            {
                groupBox1.Visible = true;
                listBox2.Enabled = false;
                txtEdit.Text = listBox1.Items[listBox1.SelectedIndex].ToString();
            }
        }
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioEdit.Checked && listBox2.SelectedIndex != -1)
            {
                groupBox1.Visible = true;
                listBox1.Enabled = false;
                txtEdit.Text = listBox2.Items[listBox2.SelectedIndex].ToString();
            }
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                listBox1.Items[listBox1.SelectedIndex] = txtEdit.Text;
                listBox1.SelectedIndex = -1;
            }
            else if (listBox2.SelectedIndex != -1)
            {
                listBox2.Items[listBox2.SelectedIndex] = txtEdit.Text;
                listBox2.SelectedIndex = -1;
            }
            txtEdit.Text = "";
            listBox2.Enabled = true;
            groupBox1.Visible = false;
            listBox1.Enabled = true;
            radioEdit.Enabled = true;
            radioDelete.Enabled = true;
            radioSearch.Enabled = true;
        }

        private void txtEdit_TextChanged(object sender, EventArgs e)
        {
            if (txtEdit.Text.Length == 0) { btnOk.Enabled = false; }
            else { btnOk.Enabled = true; }
        }

        private void radioEdit_CheckedChanged(object sender, EventArgs e)
        {
            if (radioEdit.Checked)
            {
                listBox1.SelectedIndex = -1;
                listBox2.SelectedIndex = -1;
                groupBox2.Visible = false;
                radioSearch.Enabled = false;
                radioDelete.Enabled = false;
            }
        }

        private void radioSearch_CheckedChanged(object sender, EventArgs e)
        {
            if (radioSearch.Checked)
            {
                listBox1.SelectedIndex = -1;
                listBox2.SelectedIndex = -1;
                groupBox2.Visible = true;
            }
        }

        private void btnNewSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            checkBoxList1.Checked = false;
            checkBoxList2.Checked = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string message = "";
            bool isFound = false;
            if (!checkBoxList1.Checked&&!checkBoxList2.Checked)
            {
                MessageBox.Show("Изберете списъчна кутия");
            }
            else
            {
                if (checkBoxList1.Checked)
                {
                    for (int i = 0; i < listBox1.Items.Count; i++)
                    {
                        if (listBox1.Items[i].ToString() == txtSearch.Text)
                        {
                            message += "Елементът е намерен в първата списъчна кутия!";
                            isFound = true;
                        }
                    }
                }
                if (checkBoxList2.Checked)
                {
                    for (int i = 0; i < listBox2.Items.Count; i++)
                    {
                        if (listBox2.Items[i].ToString() == txtSearch.Text)
                        {
                            message += "Елементът е намерен във втората списъчна кутия!";
                            isFound = true;
                        }
                    }
                }

                if (!isFound)
                {
                    message = "Елементът не е намерен";
                }
                MessageBox.Show(message);
            }
        }
    }
}
