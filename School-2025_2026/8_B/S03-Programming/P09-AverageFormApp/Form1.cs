namespace P09_AverageFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = "students.txt";
            int count2 = 0;
            int count3 = 0;
            int count4 = 0;
            int count5 = 0;
            int count6 = 0;

            StreamReader r = new StreamReader(path);
            string line = string.Empty;

            while (line != null)
            {
                line = r.ReadLine();
                if (line == "2") { count2++; }
                else if (line == "3") { count3++; }
                else if (line == "4") { count4++; }
                else if (line == "5") { count5++; }
                else if (line == "6") { count6++; }
            }

            label1.Text= $"Брой 2: {count2}";
            label2.Text= $"Брой 3: {count3}";
            label3.Text= $"Брой 4: {count4}";
            label4.Text= $"Брой 5: {count5}";
            label5.Text= $"Брой 6: {count6}";

            double sum=2*count2 + 3*count3 + 4*count4 + 5*count5 + 6*count6;
            double count = count2 + count3 + count4 + count5 + count6;
            double average = sum / count;
            label6.Text = $"Среден успех: {average:F2}";
        }
    }
}
