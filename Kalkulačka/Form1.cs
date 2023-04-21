using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulačka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string operation;
        string number;

        private void button1_Click(object sender, EventArgs e)
        {
            number = number + "1";
            setlabel(number.ToString());
        }
        private void button2_Click(object sender, EventArgs e)
        {
            number = number + "2";
            setlabel(number.ToString());
        }
        private void button3_Click(object sender, EventArgs e)
        {
            number = number + "3";
            setlabel(number.ToString());
        }
        private void button4_Click(object sender, EventArgs e)
        {
            number = number + "4";
            setlabel(number.ToString());
        }
        private void button5_Click(object sender, EventArgs e)
        {
            number = number + "5";
            setlabel(number.ToString());
        }
        private void button6_Click(object sender, EventArgs e)
        {
            number = number + "6";
            setlabel(number.ToString());
        }
        private void button7_Click(object sender, EventArgs e)
        {
            number = number + "7";
            setlabel(number.ToString());
        }
        private void button8_Click(object sender, EventArgs e)
        {
            number = number + "8";
            setlabel(number.ToString());
        }
        private void button9_Click(object sender, EventArgs e)
        {
            number = number + "9";
            setlabel(number.ToString());
        }
        private void button0_Click(object sender, EventArgs e)
        {
            number = number + "0";
            setlabel(number.ToString());
        }

        private void button14_Click(object sender, EventArgs e)
        {
            operation = operation + number + "+";
            number = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            operation = operation + number + "-";
            number = "";
        }
        private void button12_Click(object sender, EventArgs e)
        {
            operation = operation + number + "*";
            number = "";
        }
        private void button11_Click(object sender, EventArgs e)
        {
            operation = operation + number + "/";
            number = "";
        }
        private void button15_Click(object sender, EventArgs e)
        {
            operation = "";
            number = "";
            setlabel(operation.ToString());
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                operation = operation + number;
                DataTable dt = new DataTable();
                var result = dt.Compute(operation, "");
                setlabel(result.ToString());
                number = "";
                operation = "(" + operation + ")";
            }
            catch(Exception ex)
            {
                setlabel("Chybí operand");
                operation = "";
                number = "";
            }
            
        }
        void setlabel(string label)
        {
            label2.Text = label;
        }

    }
}
