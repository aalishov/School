using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace P05_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] questions = null;
        string[] answers = null;
        int numQuestions = 0;
        int currentQuestion = 0;
        int points = 10;
        int time = 0;
        StreamWriter writer = new StreamWriter("results.txt", true);

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader r1 = new StreamReader("questions.txt");
            questions = new string[100];
            string line = ".", q = "";
            numQuestions = 0;
            while (line != null)
            {
                q = "";
                line = ".";
                while (line != "" && line != null)
                {
                    line = r1.ReadLine();
                    q = q + line + "\n";
                }
                numQuestions++;
                questions[numQuestions] = q;
            }
            r1.Close();
            currentQuestion = 1;
            richTextBox1.Text = questions[currentQuestion];
            label5.Text = (numQuestions - currentQuestion).ToString();
            writer.WriteLine("№\tТвоят отговор\tВерен отговор");
            label3.Text = "Въпрос " + currentQuestion;
            time = numQuestions * 10; //времето в секунди
            StreamReader r2 = new StreamReader("answers.txt");
            answers = new string[100];
            for (int i = 1; i <= numQuestions; i++)
            {
                line = r2.ReadLine();
                answers[i] = line;
            }
            r2.Close();

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time--;
            label2.Text = time / 60 + " мин. " + time % 60 + " сек.";
            if (time == 0)
            {
                timer1.Stop();
                button1.Text = "Край на теста";
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
                radioButton3.Enabled = false;
                radioButton4.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Виж резултата си")
            {
                button1.Enabled = false;
                StreamReader r = new StreamReader("results.txt");
                richTextBox1.Text = r.ReadToEnd();
                r.Close();
                return;
            }
            if (button1.Text == "Край на теста")
            {
                timer1.Stop();
                label4.Text = "Брой точки:";
                label5.Text = points.ToString();
                writer.Close();
                button1.Text = "Виж резултата си";
                return;
            }
            if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked)
            {
                MessageBox.Show("Маркирай отговор!");
                return;
            }
            string ans = "";
            if (radioButton1.Checked) { ans = "a"; }
            if (radioButton2.Checked) { ans = "б"; }
            if (radioButton3.Checked) { ans = "в"; }
            if (radioButton4.Checked) { ans = "г"; }
            if (radioButton1.Checked && answers[currentQuestion] == "а") { points++; }
            if (radioButton2.Checked && answers[currentQuestion] == "б")
            { points++; }
            if (radioButton3.Checked && answers[currentQuestion] == "в")
            { points++; }
            if (radioButton4.Checked && answers[currentQuestion] == "г")
            { points++; }
            writer.WriteLine("{2}\t{0}\t\t\t{1}", ans, answers[currentQuestion],
            currentQuestion);
            if (currentQuestion == numQuestions)
            {
                button1.Text = "Край на теста";
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
                radioButton3.Enabled = false;
                radioButton4.Enabled = false;
                return;
            }
            currentQuestion++;
            richTextBox1.Text = questions[currentQuestion];
            label3.Text = "Въпрос " + currentQuestion;
            label5.Text = (numQuestions - currentQuestion).ToString();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
        }
    }
}
