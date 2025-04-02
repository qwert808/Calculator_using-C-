using System;
using System.Diagnostics.Eventing.Reader;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Calculator
{
    public partial class frmCalculator : Form
    {
        public frmCalculator()
        {
            InitializeComponent();
        }

        bool operatorClicked = false;
        bool decimalClicked = false;
        string Calresult;
        decimal num1;
        decimal num2;
        string op;
        decimal result;

        private void btnOne_Click(object sender, EventArgs e)
        {
            if (operatorClicked == false)
            {
                txtScreen.Text += "1";
            }
            else
            {
                txtScreen.Clear();
                txtScreen.Text += "1";
                operatorClicked=false;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtScreen.Clear(); 
            num1 = 0;
            num2 = 0;
            op = "0";
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            if (operatorClicked == false)
            {
                txtScreen.Text += "2";
            }
            else
            {
                txtScreen.Clear();
                txtScreen.Text += "2";
                operatorClicked = false;
            }
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            if (operatorClicked == false)
            {
                txtScreen.Text += "3";
            }
            else
            {
                txtScreen.Clear();
                txtScreen.Text += "3";
                operatorClicked = false;
            } 
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            if (operatorClicked == false)
            {
                txtScreen.Text += "4";
            }
            else
            {
                txtScreen.Clear();
                txtScreen.Text += "4";
                operatorClicked = false;
            }
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            if (operatorClicked == false)
            {
                txtScreen.Text += "5";
            }
            else
            {
                txtScreen.Clear();
                txtScreen.Text += "5";
                operatorClicked = false;
            }
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            if (operatorClicked == false)
            {
                txtScreen.Text += "6";
            }
            else
            {
                txtScreen.Clear();
                txtScreen.Text += "6";
                operatorClicked = false;
            }
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            if (operatorClicked == false)
            {
                txtScreen.Text += "7";
            }
            else
            {
                txtScreen.Clear();
                txtScreen.Text += "7";
                operatorClicked = false;
            }
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            if (operatorClicked == false)
            {
                txtScreen.Text += "8";
            }
            else
            {
                txtScreen.Clear();
                txtScreen.Text += "8";
                operatorClicked = false;
            }
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            if (operatorClicked == false)
            {
                txtScreen.Text += "9";
            }
            else
            {
                txtScreen.Clear();
                txtScreen.Text += "9";
                operatorClicked = false;
            }
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            if (operatorClicked == false && decimalClicked == false)
            {
                    txtScreen.Text += ".";
                    decimalClicked = true; 
            }
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            if (operatorClicked == false)
            {
                txtScreen.Text += "0";
            }
            else
            {
                txtScreen.Clear();
                txtScreen.Text += "0";
                operatorClicked = false;
            }
        }

        private void txtScreen_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPercentage_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text.Length == 0)
            {
                MessageBox.Show("Operator can not be entered first", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                op = "%";
                operatorClicked = true;
                decimalClicked = false;
                num1 = Decimal.Parse(txtScreen.Text);
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text.Length == 0)
            {
                MessageBox.Show("Operator can not be entered first", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                op = "/";
                operatorClicked = true;
                decimalClicked = false;
                num1 = Decimal.Parse(txtScreen.Text);
            }
            
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text.Length == 0)
            {
                MessageBox.Show("Operator can not be entered first", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                op = "*";
                operatorClicked = true;
                decimalClicked = false;
                num1 = Decimal.Parse(txtScreen.Text);
            } 
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text.Length == 0)
            {
                MessageBox.Show("Operator can not be entered first","Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                op = "-";
                operatorClicked = true;
                decimalClicked = false;
                num1 = Decimal.Parse(txtScreen.Text);
            }
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text.Length == 0)
            {
                MessageBox.Show("Operator can not be entered first", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                op = "+";
                operatorClicked = true;
                decimalClicked = false;
                num1 = Decimal.Parse(txtScreen.Text);
            }
        }

        private void btnEqualsTo_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text.Length == 0)
            {
                MessageBox.Show("Operator can not be entered first", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                if (op == "+")
                {
                    num2 = Decimal.Parse(txtScreen.Text);
                    result = num1 + num2;
                    Calresult = result.ToString();
                }
                else if (op == "-")
                {
                    num2 = Decimal.Parse(txtScreen.Text);
                    result = num1 - num2;
                    Calresult = result.ToString();
                }
                else if (op == "/")
                {
                    num2 = Decimal.Parse(txtScreen.Text);
                    if (num2 == 0)
                    {
                        MessageBox.Show("Can not divide by Zero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        result = num1 / num2;
                        Calresult = result.ToString();
                    }
                }
                else if (op == "*")
                {
                    num2 = Decimal.Parse(txtScreen.Text);
                    result = num1 * num2;
                    Calresult = result.ToString();
                }
                else if (op == "%")
                {
                    num2 = Decimal.Parse(txtScreen.Text);
                    result = num1 / 100;
                    Calresult = result.ToString();
                }
                else
                {
                    Calresult = txtScreen.Text;
                }
                operatorClicked = true;
                decimalClicked = false;
                txtScreen.Text = Calresult;
            }
        }
        private void txtScreen_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            int b = Convert.ToInt32(c);
            if ((b < 58 && b > 47) || (b == 08))
            {
                Text = txtScreen.Text;
            }
            else if (b == 46 && decimalClicked == false) 
            {
                Text = txtScreen.Text;
                decimalClicked = true;
            }
            
            else
            {
                var result = MessageBox.Show("Invalid Input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                if (result == DialogResult.OK)
                {
                    e.KeyChar = ' ';
                }
            }
        }
    }
}
