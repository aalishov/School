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

namespace Pharmacy.Web
{
    public partial class Form1 : Form
    {
        private Dictionary<string, Medicine> medicines;
        public Form1()
        {
            InitializeComponent();
            medicines = new Dictionary<string, Medicine>();
            LoadMedicines();
            LoadPharmacy();
        }

        private void addMedicine_Click(object sender, EventArgs e)
        {
            AddMedicineForm medicine = new AddMedicineForm();
            medicine.Show();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            LoadMedicines();
            LoadPharmacy();
        }

        private void LoadMedicines()
        {
            string path = @"D:\GIT\School\School-2020_2021\11B_Solutions\03-Module Algorithms\S03-OOP\Pharmacy.Web\medicine.txt";

            medicines.Clear();
            using (StreamReader reader = new StreamReader(path))
            {
                while (!reader.EndOfStream)
                {
                    string[] result = reader.ReadLine().Split('-').ToArray();
                    Medicine medicine = new Medicine(result[0], double.Parse(result[1]));
                    medicines.Add(result[0], medicine);
                }
            }
            listBox1.Items.Clear();
            foreach (var m in medicines)
            {
                listBox1.Items.Add(m.Value.ToString());
            }
        }

        private void LoadPharmacy()
        {
            string path = @"D:\GIT\School\School-2020_2021\11B_Solutions\03-Module Algorithms\S03-OOP\Pharmacy.Web\pharmacy.txt";

            listBox2.Items.Clear();
            using (StreamReader reader= new StreamReader(path))
            {
                while (!reader.EndOfStream)
                {
                    string result = reader.ReadLine();
                    if (result[0] == '@')
                    {
                        listBox2.Items.Add(result.TrimStart('@'));
                    }
                }
            }
        }

        private void addPharmacyButton_Click(object sender, EventArgs e)
        {
            AddPharmacyForm pharmacy= new AddPharmacyForm();
            pharmacy.Show();
        }
    }
}
