using P02_EfOneToMany.Data;
using P02_EfOneToMany.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P04_EfOneToManyFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AppService service = new AppService(new AppDbContext());
            textBox1.Text = service.GetModelsInfo();
        }
    }
}
