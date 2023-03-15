using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P00_DemoForm
{
    public partial class Form1 : Form
    {
        private int currentImage = 0;
        private List<string> images = new List<string>()

        {
        "https://th.bing.com/th/id/OIP.eLJwcWf2Y5B1VGdmCtlR2wHaHn?w=178&h=183&c=7&r=0&o=5&dpr=1.4&pid=1.7",
        "https://th.bing.com/th/id/OIP.hVBmKrvyrT2HbbOvZqxz1wHaGL?w=219&h=183&c=7&r=0&o=5&dpr=1.4&pid=1.7",
        "https://th.bing.com/th/id/OIP.Bi3rNxZmDD06WGwcTJbewAHaFj?w=256&h=192&c=7&r=0&o=5&dpr=1.4&pid=1.7"


        };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Load(images[currentImage]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (currentImage > 0)
            {
                currentImage--;
            }
            LoadImage();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (currentImage < images.Count - 1)
            {
                currentImage++;
            }
            LoadImage();

        }

        private void LoadImage()
        {
            try
            {
                pictureBox1.Load(images[currentImage]);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid image");
                currentImage = 0;
                pictureBox1.Load(images[currentImage]);
            }
        }
    }
}
