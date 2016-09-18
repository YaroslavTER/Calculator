using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private bool operation_is_working = false;
        private string operation = null;
        private double value = 0;
        private int limit = 23;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            bool point_is_in_line = false;
            int counter = 0;
            while(counter < result.Text.Count())
            {
                if(result.Text[counter] == '.')
                {
                    point_is_in_line = true;
                    counter = result.Text.Count();
                }
                counter++;
            }
            if (result.Text == "0")
                result.Text = null;
            if (result.Text.Count() < limit && point_is_in_line == false)
                result.Text += ".";
        }
        
        private void operator_Click(object sender, EventArgs e)
        {
            Button button_operation = (Button)sender;
            operation = button_operation.Text;
            value = Convert.ToDouble(result.Text);
            operation_is_working = true;
            string auxiliary_line = Convert.ToString(value) + " " + operation;
            if(label.Text.Count() < limit)
                label.Text += auxiliary_line;
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (result.Text == "0" || operation_is_working == true)
                result.Clear();
            operation_is_working = false;
            Button button = (Button)sender;
            if(result.Text.Count() < limit)
                result.Text += button.Text;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            result.Text = null;
            result.Text = "0";
        }

        private void equal_Click(object sender, EventArgs e)
        {            
            switch(operation)
            {
                case "+":
                    {
                        operation_is_working = false;
                        result.Text = Convert.ToString(value + Convert.ToDouble(result.Text));
                        label.Text = null;
                        break;
                    }
                case "-":
                    {
                        operation_is_working = false;
                        result.Text = Convert.ToString(value - Convert.ToDouble(result.Text));
                        label.Text = null;
                        break;
                    }
                case "*":
                    {
                        operation_is_working = false;
                        result.Text = Convert.ToString(value * Convert.ToDouble(result.Text));
                        label.Text = null;
                        break;
                    }
                case "/":
                    {
                        operation_is_working = false;
                        result.Text = Convert.ToString(value / Convert.ToDouble(result.Text));
                        label.Text = null;
                        break;
                    }
            }
        }

        private void result_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lable(object sender, EventArgs e)
        {
        }
    }
}
