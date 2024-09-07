using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lect2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)

        {
            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("Please enter number 1");
                textBox1.Focus();

            }
            else if (textBox2.Text.Trim() == "")
            {
                MessageBox.Show("Please enter number 2");
                textBox2.Focus();
            }
            else
            {
                //الادخال مع العمليات 
                double number1 = Convert.ToDouble(textBox1.Text);
                double number2 = Convert.ToDouble(textBox2.Text);
                double result = number1 + number2;
                textBox3.BackColor = Color.Cyan;
                string sum = result.ToString();
                textBox3.Text = sum;
               
                
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only numbers, backspace, negative sign, and decimal point
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8) && e.KeyChar != 45 && e.KeyChar != 46)
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Same validation for textBox2 as in textBox1
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8) && e.KeyChar != 45 && e.KeyChar != 46)
            {
                e.Handled = true;
            }
        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text!=""&& textBox2.Text!="")
            {
                button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = true;
            }
            else
            {
                button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = false;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                button1.Enabled = button2.Enabled= button3.Enabled= button4.Enabled = true;
            }
            else
            {
                button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("Please enter number 1");
                textBox1.Focus();

            }
            else if (textBox2.Text.Trim() == "")
            {
                MessageBox.Show("Please enter number 2");
                textBox2.Focus();
            }
            else
            {
                //الادخال مع العمليات 
                double number1 = Convert.ToDouble(textBox1.Text);
                double number2 = Convert.ToDouble(textBox2.Text);
                double result = number1 - number2;
                string sum = result.ToString();
                textBox3.BackColor = Color.Cyan;
                textBox3.Text = sum;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("Please enter number 1");
                textBox1.Focus();

            }
            else if (textBox2.Text.Trim() == "")
            {
                MessageBox.Show("Please enter number 2");
                textBox2.Focus();
            }
            else
            {
                //الادخال مع العمليات 
                double number1 = Convert.ToDouble(textBox1.Text);
                double number2 = Convert.ToDouble(textBox2.Text);
                double result = number1 * number2;
                string sum = result.ToString();
                textBox3.BackColor = Color.Cyan;
                textBox3.Text = sum;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("Please enter number 1");
                textBox1.Focus();

            }
            else if (textBox2.Text.Trim() == "")
            {
                MessageBox.Show("Please enter number 2");
                textBox2.Focus();
            }
            else
            {
                
                    //الادخال مع العمليات 
                    double number1 = Convert.ToDouble(textBox1.Text);
                    double number2 = Convert.ToDouble(textBox2.Text);
                if (number2!=0)
                {
                    double result = number1 / number2;
                    string sum = result.ToString();
                    textBox3.BackColor = Color.Cyan;
                    textBox3.Text = sum;

                }
                else
                {
                    MessageBox.Show("Erorr Divnation by zero ?");
                    textBox2.Focus();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // تصفير المربعات 
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox1.Focus();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do You Want To Exit ? ", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
