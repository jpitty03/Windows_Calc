using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_Calc
{
    public partial class Form1 : Form
    {
        Double value = 0;
        string operation = "";
        bool operation_pressed = false;

        public Form1()
        {
            InitializeComponent();
        }


        private void button_Click(object sender, EventArgs e)
        {
            if ((result.Text == "0")||(operation_pressed))
                result.Clear();

            Button b = (Button)sender;
            result.Text = result.Text + b.Text;
        }

        private void clear_all_Click(object sender, EventArgs e)
        {
            result.Text = "0";
        }

        private void operater_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = Double.Parse(result.Text);
            operation_pressed = true;

        }

        private void equals_Click(object sender, EventArgs e)
        {
            switch(operation)
            {
                case "+":
                    result.Text = (value + Double.Parse(result.Text)).ToString();
                    break;
                case "-":
                    result.Text = (value - Double.Parse(result.Text)).ToString();
                    break;
                case "*":
                    result.Text = (value * Double.Parse(result.Text)).ToString();
                    break;
                case "/":
                    result.Text = (value / Double.Parse(result.Text)).ToString();
                    break;
                case "√":
                    result.Text = Math.Sqrt(value).ToString();
                    break;
                case "1/x":
                    result.Text = (1 / value).ToString();
                    break;
                case "x²":
                    result.Text = (value * value).ToString();
                    break;
            } //end switch
            operation_pressed = false;
        }

        private void percent_click(object sender, EventArgs e)
        {
            result.Text = (Double.Parse(result.Text) * .01).ToString();


        }
    }
}
