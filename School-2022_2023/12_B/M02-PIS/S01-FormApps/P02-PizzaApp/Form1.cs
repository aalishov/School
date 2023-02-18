using Microsoft.EntityFrameworkCore.Metadata.Internal;
using P02_PizzaApp.Data;
using P02_PizzaApp.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace P02_PizzaApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Seeder seeder = new Seeder();
            seeder.Seed();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            using (AppDbContext context = new AppDbContext())
            {
                string[] pizzaNames = context.Pizzas.Select(x => x.Name).ToArray();
                string url = context.Pizzas.FirstOrDefault(x => x.Name == pizzaNames[0]).ImageUrl;
                comboBPizza.Items.AddRange(pizzaNames);
                comboBPizza.SelectedIndex = 0;
                pictureBox1.Load(url);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            string name = comboBPizza.Text;
            Pizza pizza = null;
            using (AppDbContext context = new AppDbContext())
            {
                pizza = context.Pizzas.FirstOrDefault(x => x.Name == name);
            }
            if (pizza != null)
            {
                order.Pizza = pizza;
                SetSize(order);
                SetPayment(order);
                SetExtras(order);
                using (AppDbContext context = new AppDbContext())
                {
                    context.Orders.Add(order);
                }
                CreateBill(order);
                MessageBox.Show("Please get your bill!");
                
            }
            else
            {
                MessageBox.Show("Please select pizza");
            }

            

        }

        private void SetSize(Order order)
        {
            if (rbSizeSmall.Checked)
            {
                order.Size = GetSizeByName(rbSizeSmall.Text);
            }
            else if (rbSizeBig.Checked)
            {
                order.Size = GetSizeByName(rbSizeBig.Text);
            }
            else if (rbSizeFamily.Checked)
            {
                order.Size = GetSizeByName(rbSizeFamily.Text);
            }
        }
        private void SetPayment(Order order)
        {
            if (rbPCash.Checked)
            {
                order.Paymant = GetPaymentByName(rbPCash.Text);
            }
            else if (rbPOnline.Checked)
            {
                order.Paymant = GetPaymentByName(rbPOnline.Text);
            }
        }
        private void SetExtras(Order order)
        {
            List<Extra> extras = new List<Extra>();
            if (cbEKetchup.Checked)
            {
                extras.Add(GetExtraByName(cbEKetchup.Text));
            }
            if (cbEMayo.Checked)
            {
                extras.Add(GetExtraByName(cbEMayo.Text));
            }
            if (cbEMustard.Checked)
            {
                extras.Add(GetExtraByName(cbEMustard.Text));
            }
            if (cbESoyS.Checked)
            {
                extras.Add(GetExtraByName(cbESoyS.Text));
            }
            if (cbEChili.Checked)
            {
                extras.Add(GetExtraByName(cbEChili.Text));
            }
            if (cbEGarlicS.Checked)
            {
                extras.Add(GetExtraByName(cbEGarlicS.Text));
            }
            order.Extras = extras;
        }
        private void comboBPizza_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (AppDbContext context = new AppDbContext())
            {
                string url = context.Pizzas.FirstOrDefault(x => x.Name == comboBPizza.Text).ImageUrl;
                pictureBox1.Load(url);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DatabaseForm form = new DatabaseForm();
            form.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void rbSizeBig_CheckedChanged(object sender, EventArgs e)
        {

        }
        private Data.Models.Size GetSizeByName(string name)
        {
            using (AppDbContext context = new AppDbContext())
            {
                return context.Sizes.FirstOrDefault(x => x.Width.ToLower() == name);
            }
        }
        private Paymant GetPaymentByName(string name)
        {
            using (AppDbContext context = new AppDbContext())
            {
                return context.Paymants.FirstOrDefault(x => x.PaymantMethod.ToLower() == name);
            }
        }
        private Extra GetExtraByName(string name)
        {
            using (AppDbContext context = new AppDbContext())
            {
                return context.Extras.FirstOrDefault(x => x.Name.ToLower() == name);
            }
        }
        private void CreateBill(Order order)
        {
            
            StringBuilder sb = new StringBuilder();
            decimal pizzaPrice = order.Pizza.Price * (order.Size.PricePerc / 100 + 1);
            decimal extrasPrice = order.Extras.Sum(x => x.Price);
            string extras = order.Extras.Any() ? String.Join(", ", order.Extras.Select(x => x.Name)) : "-";
            sb.AppendLine(new string('-', 50));
            sb.AppendLine("PIZZA APP");
            sb.AppendLine(new string('-', 50));
            sb.AppendLine($"Order date: {order.OrderDate.ToShortDateString()}");
            sb.AppendLine($"Pizza: {order.Pizza.Name}");
            sb.AppendLine($"Price of Pizza: {pizzaPrice:c2}");
            sb.AppendLine($"Size: {order.Size.Width}");
            sb.AppendLine($"Extras: {extras}");
            sb.AppendLine($"Price of extras: {extrasPrice:c2}");
            sb.AppendLine($"Total Price of the order: {pizzaPrice + extrasPrice:c2}");
            sb.AppendLine($"Payment: {order.Paymant.PaymantMethod}");
            sb.AppendLine(new string('-', 50));
            string fileName = $"order-{order.OrderDate.ToShortDateString()}{order.OrderDate.Hour}{order.OrderDate.Minute}{order.OrderDate.Second}{order.OrderDate.Millisecond}.txt";
            
            File.WriteAllText(fileName, sb.ToString());

            Process.Start("notepad.exe", fileName);
        }
    }
}
