using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NCalc;


namespace CalculatorAppV2
{
    public partial class Calculator : Form
    {
        bool equalsPressed = false;
        public Calculator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (equalsPressed == true)
            {
                txtDisplay.Clear();
                equalsPressed = false;
            }
            txtDisplay.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (equalsPressed == true)
            {
                txtDisplay.Clear();
                equalsPressed = false;
            }
            txtDisplay.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (equalsPressed == true)
            {
                txtDisplay.Clear();
                equalsPressed = false;
            }
            txtDisplay.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (equalsPressed == true)
            {
                txtDisplay.Clear();
                equalsPressed = false;
            }
            txtDisplay.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (equalsPressed == true)
            {
                txtDisplay.Clear();
                equalsPressed = false;
            }
            txtDisplay.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (equalsPressed == true)
            {
                txtDisplay.Clear();
                equalsPressed = false;
            }
            txtDisplay.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (equalsPressed == true)
            {
                txtDisplay.Clear();
                equalsPressed = false;
            }
            txtDisplay.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (equalsPressed == true)
            {
                txtDisplay.Clear();
                equalsPressed = false;
            }
            txtDisplay.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (equalsPressed == true)
            {
                txtDisplay.Clear();
                equalsPressed = false;
            }
            txtDisplay.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (equalsPressed == true)
            {
                txtDisplay.Clear();
                equalsPressed = false;
            }
            txtDisplay.Text += "0";
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            if (equalsPressed == true)
            {
                txtDisplay.Clear();
                equalsPressed = false;
            }
            txtDisplay.Text += "+";
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            equalsPressed = true;
            string expression = txtDisplay.Text;

            if (string.IsNullOrWhiteSpace(expression))
            {
                MessageBox.Show("Expressions can't be empty");
                return;
            }

            Expression exp = new Expression(expression);
            
            try
            {
                object result = exp.Evaluate();
                txtDisplay.Text = result.ToString();
            }
            catch (EvaluationException)
            {
                txtDisplay.Clear();
                MessageBox.Show("Invalid Expression");
            }
        }
           
        private void buttonMinus_Click(object sender, EventArgs e)
        {
            if (equalsPressed == true)
            {
                txtDisplay.Clear();
                equalsPressed = false;
            }
            txtDisplay.Text += "-";
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            if (equalsPressed == true)
            {
                txtDisplay.Clear();
                equalsPressed = false;
            }
            txtDisplay.Text += "*";
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            if (equalsPressed == true)
            {
                txtDisplay.Clear();
                equalsPressed = false;
            }
            txtDisplay.Text += "/";
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (equalsPressed == true)
            {
                txtDisplay.Clear();
                equalsPressed = false;
            }
            
            StringBuilder textBoxContents = new StringBuilder();
            textBoxContents.Append(txtDisplay.Text);
            
            if(textBoxContents.Length > 0)
            {
                textBoxContents.Remove(textBoxContents.Length - 1, 1);
                txtDisplay.Text = textBoxContents.ToString();
            }

        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            if (equalsPressed == true)
            {
                txtDisplay.Clear();
                equalsPressed = false;
            }
            txtDisplay.Text += ".";
        }

        private void buttonPercent_Click(object sender, EventArgs e)
        {
            if (equalsPressed == true)
            {
                txtDisplay.Clear();
                equalsPressed = false;
            }
            txtDisplay.Text += "/100";
        }

        private void buttonExponent_Click(object sender, EventArgs e)
        {
            if (equalsPressed == true)
            {
                txtDisplay.Clear();
                equalsPressed = false;
            }
            txtDisplay.Text += "Pow";
        }

        private void buttonOpenBracket_Click(object sender, EventArgs e)
        {
            if (equalsPressed == true)
            {
                txtDisplay.Clear();
                equalsPressed = false;
            }
            txtDisplay.Text += "(";
        }

        private void buttonCloseBracket_Click(object sender, EventArgs e)
        {
            if (equalsPressed == true)
            {
                txtDisplay.Clear();
                equalsPressed = false;
            }
            txtDisplay.Text += ")";
        }

        private void buttonComma_Click(object sender, EventArgs e)
        {
            if (equalsPressed == true)
            {
                txtDisplay.Clear();
                equalsPressed = false;
            }
            txtDisplay.Text += ",";
        }

        private void buttonLog_Click(object sender, EventArgs e)
        {
            if (equalsPressed == true)
            {
                txtDisplay.Clear();
                equalsPressed = false;
            }
            txtDisplay.Text += "Log10";
        }

        private void buttonSin_Click(object sender, EventArgs e)
        {
            if (equalsPressed == true)
            {
                txtDisplay.Clear();
                equalsPressed = false;
            }
            txtDisplay.Text += "Sin";
        }

        private void buttonCos_Click(object sender, EventArgs e)
        {
            if (equalsPressed == true)
            {
                txtDisplay.Clear();
                equalsPressed = false;
            }
            txtDisplay.Text += "Cos";
        }

        private void buttonTan_Click(object sender, EventArgs e)
        {
            if (equalsPressed == true)
            {
                txtDisplay.Clear();
                equalsPressed = false;
            }
            txtDisplay.Text += "Tan";
        }

        private void buttonDeg_Click(object sender, EventArgs e)
        {
            if (equalsPressed == true)
            {
                txtDisplay.Clear();
                equalsPressed = false;
            }
            txtDisplay.Text += "*(3.141592653589793238462/180)";
        }
    }
}
