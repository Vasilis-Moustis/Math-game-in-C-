using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final_2
{
    public partial class Calculator : Form
    {
      
        int n1;
        int n2;
        int number_length;
        string yournumber;
        Boolean No = false;
		int function = 0;

        public Calculator()
        {
            InitializeComponent();
        }

        private void number1button_Click(object sender, EventArgs e)
        {
            if (textBoxResult.Text == "0")
            {
                textBoxResult.Clear();
            }
            if (!No)
            {  
                textBoxResult.Text = textBoxResult.Text + "1";
                No = true;
            }
            else
            {
                textBoxResult.Text = textBoxResult.Text + "1";
                No = false;
            }
        }

        private void number2button_Click(object sender, EventArgs e)
        {
            if (textBoxResult.Text == "0")
            {
                textBoxResult.Clear();
            }
            if (!No)
            {
                textBoxResult.Text = textBoxResult.Text + "2";
                No = true;
            }
            else
            {
                textBoxResult.Text = textBoxResult.Text + "2";
                No = false;
            }
        }

        private void plusbutton_Click(object sender, EventArgs e)
        {
            No = true;
            n1 = int.Parse(textBoxResult.Text);
            textBoxResult.Text = "";
            label1.Text = n1 + "+";
			function = 1;
        }

        private void number3button_Click(object sender, EventArgs e)
        {
            if (textBoxResult.Text == "0")
            {
                textBoxResult.Clear();
            }
            if (!No)
            {
                textBoxResult.Text = textBoxResult.Text + "3";
                No = true;
            }
            else
            {
                textBoxResult.Text = textBoxResult.Text + "3";
                No = false;
            }
        }

        private void number4button_Click(object sender, EventArgs e)
        {
            if (textBoxResult.Text == "0")
            {
                textBoxResult.Clear();
            }
            if (!No)
            {
                textBoxResult.Text = textBoxResult.Text + "4";
                No = true;
            }
            else
            {
                textBoxResult.Text = textBoxResult.Text + "4";
                No = false;
            }
        }

        private void number5button_Click(object sender, EventArgs e)
        {
            if (textBoxResult.Text == "0")
            {
                textBoxResult.Clear();
            }
            if (!No)
            {
                textBoxResult.Text = textBoxResult.Text + "5";
                No = true;
            }
            else
            {
                textBoxResult.Text = textBoxResult.Text + "5";
                No = false;
            }
        }

        private void number6button_Click(object sender, EventArgs e)
        {
            if (textBoxResult.Text == "0")
            {
                textBoxResult.Clear();
            }
            if (!No)
            {
                textBoxResult.Text = textBoxResult.Text + "6";
                No = true;
            }
            else
            {
                textBoxResult.Text = textBoxResult.Text + "6";
                No = false;
            }
        }

        private void number7button_Click(object sender, EventArgs e)
        {
            if (textBoxResult.Text == "0")
            {
                textBoxResult.Clear();
            }
            if (!No)
            {
                textBoxResult.Text = textBoxResult.Text + "7";
                No = true;
            }
            else
            {
                textBoxResult.Text = textBoxResult.Text + "7";
                No = false;
            }
        }

        private void number8button_Click(object sender, EventArgs e)
        {
            if (textBoxResult.Text == "0")
            {
                textBoxResult.Clear();
            }
            if (!No)
            {
                textBoxResult.Text = textBoxResult.Text + "8";
                No = true;
            }
            else
            {
                textBoxResult.Text = textBoxResult.Text + "8";
                No = false;
            }
        }

        private void number9button_Click(object sender, EventArgs e)
        {
            if (textBoxResult.Text == "0")
            {
                textBoxResult.Clear(); 
            }
            if (!No)
            {
                textBoxResult.Text = textBoxResult.Text + "9";
                No = true;
            }
            else
            {
                textBoxResult.Text = textBoxResult.Text + "9";
                No = false;
            }

        }

        private void nullbutton_Click(object sender, EventArgs e)
        {
            if (textBoxResult.Text == "0")
            {
                textBoxResult.Clear();
            }
            if (!No)
            {
                textBoxResult.Text = textBoxResult.Text + "0";
                No = true;
            }
            else
            {
                textBoxResult.Text = textBoxResult.Text + "0";
                No = false;
            }
			
        }

        private void ACbutton_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "0";
            label1.Text = "";
            n1 = 0;
            n2 = 0;
        }

        private void subtractionbutton_Click(object sender, EventArgs e) 
        {
            No = true;
            n1 = int.Parse(textBoxResult.Text);
            textBoxResult.Text = "";
            label1.Text = n1 + "-";
			function = 2;
        }

        private void multiplicationbutton_Click(object sender, EventArgs e)
        {
            No = true;
            n1 = int.Parse(textBoxResult.Text);
            textBoxResult.Text = "";
            label1.Text = n1 + "*";
			function = 3;
        }

        private void divisionbutton_Click(object sender, EventArgs e)
        {
            No = true;
            n1 = int.Parse(textBoxResult.Text);
            textBoxResult.Text = "";
            label1.Text = n1 + "/";
			function = 4;
        }

        private void equalitybutton_Click(object sender, EventArgs e) 
        {
            try
            {
                No = false;
                n2 = Int32.Parse(textBoxResult.Text);
                textBoxResult.Text = "";
                if (function == 1)
                {
                    label1.Text = (n1 + n2).ToString();
                }
                else if (function == 2)
                {
                    label1.Text = (n1 - n2).ToString();
                }
                else if (function == 3)
                {
                    label1.Text = (n1 * n2).ToString();
                }
                else
                {
                    if (n2 != 0)
                    {
                        label1.Text = (n1 / n2).ToString();
                    }
                    else
                    {
                        MessageBox.Show("Division by zero!!!!");
                    }
                }
                n1 = 0;
                n2 = 0;
                function = 0;
            }
            catch(Exception)
            {
                MessageBox.Show("Try again with two numbers please");
            }

        }

        private void button2_Click(object sender, EventArgs e) //backspace
        {
            yournumber = textBoxResult.Text;
            number_length = textBoxResult.TextLength;
            textBoxResult.Text = "";
            for(int i = 0; i < number_length - 1; i++)
            {
                textBoxResult.Text = textBoxResult.Text + yournumber[i];
            }
        }

    }
}
