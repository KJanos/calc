using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class Form1 : Form
    {
        TextBox lastSelectedTb;
        public Form1()
        {
            InitializeComponent();
            var tbxs = this.Controls.OfType<TextBox>();
            foreach (var tb in tbxs)
            {
                tb.GotFocus += new EventHandler(tb_GotFocus);
            }
            
        }

        void tb_GotFocus(object sender, EventArgs e)
        {
            lastSelectedTb = (TextBox)sender;
        }




        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        public void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = Convert.ToDouble(textBox1.Text);
                double num2 = Convert.ToDouble(textBox2.Text);
                double res = num1 + num2;
                textBox3.Text = ("" + res);
            }
            catch (FormatException)
            {
                MessageBox.Show("Невірно введені дані");
            }
             

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = Convert.ToDouble(textBox1.Text);
                double num2 = Convert.ToDouble(textBox2.Text);
                double res = num1 - num2;
                textBox3.Text = ("" + res);
            }
            catch (FormatException)
            {
                MessageBox.Show("Невірно введені дані");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = Convert.ToDouble(textBox1.Text);
                double num2 = Convert.ToDouble(textBox2.Text);
                double res = num1 * num2;
                textBox3.Text = ("" + res);
            }
            catch (FormatException)
            {
                MessageBox.Show("Невірно введені дані");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = Convert.ToDouble(textBox1.Text);
                double num2 = Convert.ToDouble(textBox2.Text);
                double res = num1 / num2;
                if (double.IsInfinity(res)) MessageBox.Show("Ділення на нуль неможливо");
                else textBox3.Text = ("" + res);
            }
            catch (FormatException)
            {
                MessageBox.Show("Невірно введені дані");
            }

            //try
            //    {
            //        double res = num1 / num2;
            //        textBox3.Text = ("" + res);

            //    }
            //    catch (DivideByZeroException ex)
            //    {

            //        MessageBox.Show("Ділення на нуль неможливо");
            //    }

        }

        private void B0_Click(object sender, EventArgs e)
        {
            if (lastSelectedTb != null)
            {
                lastSelectedTb.Text += "0";
            }
        }

        private void B1_Click(object sender, EventArgs e)
        {
            if (lastSelectedTb != null)
            {
                lastSelectedTb.Text += "1";
            }
        }

        private void B2_Click(object sender, EventArgs e)
        {
            if (lastSelectedTb != null)
            {
                lastSelectedTb.Text += "2";
            }
        }

        private void B3_Click(object sender, EventArgs e)
        {
            if (lastSelectedTb != null)
            {
                lastSelectedTb.Text += "3";
            }
        }

        private void B4_Click(object sender, EventArgs e)
        {
            if (lastSelectedTb != null)
            {
                lastSelectedTb.Text += "4";
            }
        }

        private void B5_Click(object sender, EventArgs e)
        {
            if (lastSelectedTb != null)
            {
                lastSelectedTb.Text += "5";
            }
        }

        private void B6_Click(object sender, EventArgs e)
        {
            if (lastSelectedTb != null)
            {
                lastSelectedTb.Text += "6";
            }
        }

        private void B7_Click(object sender, EventArgs e)
        {
            if (lastSelectedTb != null)
            {
                lastSelectedTb.Text += "7";
            }
        }

        private void B8_Click(object sender, EventArgs e)
        {
            if (lastSelectedTb != null)
            {
                lastSelectedTb.Text += "8";
            }
        }

        private void B9_Click(object sender, EventArgs e)
        {
            if (lastSelectedTb != null)
            {
                lastSelectedTb.Text += "9";
            }
        }

        private void Btochka_Click(object sender, EventArgs e)
        {
            if (lastSelectedTb != null)
            {
                lastSelectedTb.Text += ",";
            }
        }

        private void CE_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

        }
    }
}
