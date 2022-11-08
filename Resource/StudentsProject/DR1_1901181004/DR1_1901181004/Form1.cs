using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DR1_1901181004
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDel.Enabled = false;
            if (listBox1.Items.Count == 0) { btnClear.Enabled = false; }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text == "Добавяне на запис")
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
                if (listBox1.Items.Count > 0) { btnClear.Enabled = true; }
            }
            else
            {
                listBox1.Items[listBox1.SelectedIndex] = txtInput.Text;
                txtInput.Text = "";
                listBox1.SelectedIndex = -1;
                btnAdd.Text = "Добавяне на запис";
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtInput.Text = listBox1.Items[listBox1.SelectedIndex].ToString();
            txtInput.Focus();
            btnAdd.Text = "Актуализация на запис";
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            if (listBox1.Items.Count == 0) { btnClear.Enabled = false; }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Потвърждавате ли изчистването на всички записи в списъчната кутия?",
                           "Изтриване на данни",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Warning,
                           MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                listBox1.Items.Clear();
            }
            if (listBox1.Items.Count == 0) { btnClear.Enabled = false; }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            if (txtInput.Text.Length == 0) { btnAdd.Enabled = false; }
            else { btnAdd.Enabled = true; }
        }

        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ((char)Keys.Enter) && txtInput.Text != "")
            {
                btnAdd_Click(sender, e);
            }
        }

        private void txtInput_Click(object sender, EventArgs e)
        {
            if (txtInput.Text.Length == 0 && btnAdd.Text == "Добавяне на запис") { listBox1.SelectedIndex = -1; }
        }

        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (listBox1.SelectedIndex != -1 && e.KeyCode == Keys.Delete)
            {
                btnDel_Click(sender, e);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                btnEdit.Enabled = true;
                btnDel.Enabled = true;
            }
            else
            {
                btnEdit.Enabled = false;
                btnDel.Enabled = false;

            }
        }
    }
}
