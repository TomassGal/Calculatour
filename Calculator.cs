using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculatour
{
    public partial class Calculator : Form
    {
        double num1 = 0;
        double num2 = 0;
        string operation = null;
        public Calculator()
        {
            InitializeComponent();
            StartCalculator();
        }
        
        private void StartCalculator()
        {
            this.BackColor = Color.DarkMagenta;
            string buttonName = null;
            Button button = null;
            for(int i = 0; i < 10; i++)
            {
                buttonName = "button" + i;
                button = (Button)this.Controls[buttonName];
                button.Text = i.ToString();
            }
            
        }

        private void button0_Click(object sender, EventArgs e)
        {
            ;
            Button button = (Button)sender;
            if (Display.Text == "0")
            {
                Display.Text = button.Text;
            }
            else
            {
                Display.Text += button.Text;
            }
        }

        private void buttonDecimal_Click(object sender, EventArgs e)
        {

            if (Display.Text.Contains("."))
            {

            }
            else
            {
                if(Display.Text == string.Empty )
                {
                    Display.Text += "0.";
                }
                else
                {
                    Display.Text += ".";
                }
                
            }
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string s = Display.Text;
            if (s.Length > 1)
            {
                s = s.Substring(0, s.Length - 1);
            }
            else
            {
                s = "";
            }

            Display.Text = s;
            if(Display.Text == "-")
            {
                Display.Text = String.Empty;
            }
        }

        private void buttonSign_Click(object sender, EventArgs e)
        {

            
            try
            {
                string s = Display.Text;
                double ss = Convert.ToDouble(s);
                
                
                
                    ss *= -1;
                    Display.Text = ss.ToString();

                
                
                
            }
            catch
            {
                MessageBox.Show("Cant make blank to negative");
            }
            
        }

        private void Oparation_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = Convert.ToDouble(Display.Text);
                
                Button buttin = (Button)sender;
                operation = buttin.Text;
                Display.Text += buttin.Text;
            }
            catch
            {
                MessageBox.Show("Cant be blank");
            }
            
        }

        private void ButtonEuq_Click(object sender, EventArgs e)
        {
            try
            {
                num2 = Convert.ToDouble(Display.Text);
                if (operation == "+")
                {
                    Display.Text = (num1 + num2).ToString();
                }
                if (operation == "-")
                {
                    Display.Text = (num1 - num2).ToString();
                }
                if (operation == "x")
                {
                    Display.Text = (num1 * num2).ToString();
                }
                if (operation == ":")
                {
                    Display.Text = (num1 / num2).ToString();
                }
            }
            catch
            {
                MessageBox.Show("Invalid numbers");
            }
            
            
            
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            
        }
    }
}
