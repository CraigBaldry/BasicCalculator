// 
// Author: Craig Baldry M203210 
// Create Date: 1/08/18
// Version Control: 1.0
//
using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class CalculatorForm : Form
    {
        //Initialize form
        public CalculatorForm()
        {
            InitializeComponent();
        }

        public double inputA = 0;                           //When using arithmetic this will be the first value to use
        public double inputB = 0;                           //When using arithmetic this will be the second value to use
        public double output = 0;                           //Used to display the output to user      

        public bool isPlusButtonClicked = false;            //Check if user click plus
        public bool isMinusButtonClicked = false;           //Check if user clicked minus
        public bool isDivideButtonClicked = false;          //Check if user clicked divide
        public bool isMultiplyButtonClicked = false;        //Check if user clicked multiply

        //Generic button event for All the number buttons and deciamls
        private void InputBtn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string outText = btn.Text;
            
            UpdateDisplay(outText);
        }

        //Updates the display
        private void UpdateDisplay(string update, Boolean replace = false)
        {
            if (txtDisplay.Text == "0" || replace)
            {
                txtDisplay.Text = update;
            }
            else
            {
                txtDisplay.Text += update;
            }
        }

        //Clears Displayed Text
        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
        }

        //This adds
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                inputA += double.Parse(txtDisplay.Text);
                txtDisplay.Clear();

                isPlusButtonClicked = true;
                isMinusButtonClicked = false;
                isDivideButtonClicked = false;
                isMultiplyButtonClicked = false;

            }
            catch (Exception)
            {
                
            }
        }

        //This minus
        private void BtnMinus_Click(object sender, EventArgs e)
        {
            try
            {
                inputA += double.Parse(txtDisplay.Text);
                txtDisplay.Clear();

                isPlusButtonClicked = false;
                isMinusButtonClicked = true;
                isDivideButtonClicked = false;
                isMultiplyButtonClicked = false;

            }
            catch (Exception)
            {

            }
        }

        //This Divides
        private void BtnDivide_Click(object sender, EventArgs e)
        {
            try
            {
                inputA += double.Parse(txtDisplay.Text);
                txtDisplay.Clear();

                isPlusButtonClicked = false;
                isMinusButtonClicked = false;
                isDivideButtonClicked = true;
                isMultiplyButtonClicked = false;
            }
            catch (Exception)
            {

            }
            
        }

        //This Multiplys
        private void BtnMultiply_Click(object sender, EventArgs e)
        {
            try
            {
                inputA += double.Parse(txtDisplay.Text);
                txtDisplay.Clear();

                isPlusButtonClicked = false;
                isMinusButtonClicked = false;
                isDivideButtonClicked = false;
                isMultiplyButtonClicked = true;
            }
            catch (Exception)
            {

            }
            
        }

        //This computes the two values
        private void BtnEqual_Click(object sender, EventArgs e)
        {
            try
            {
                inputB = double.Parse(txtDisplay.Text);

                if (isPlusButtonClicked == true)
                {
                    output = MathLibaries.Arithmetic.Add(inputA, inputB);
                }
                else if (isMinusButtonClicked == true)
                {
                    output = MathLibaries.Arithmetic.Sub(inputA, inputB);
                }
                else if (isDivideButtonClicked == true)
                {
                    if (!inputB.Equals("0"))
                    {
                        output = MathLibaries.Arithmetic.Div(inputA, inputB);
                    }
                    else
                    {
                        MessageBox.Show("Can't Divide by 0");
                        txtDisplay.Text = "0";
                    }

                }
                else if (isMultiplyButtonClicked == true)
                {
                    output = MathLibaries.Arithmetic.Mult(inputA, inputB);
                }

                txtDisplay.Text = output.ToString();
                inputA = 0;
                inputB = 0;
            }
            catch (Exception)
            {

            }
            
        }

        //Sqaures the input
        private void BtnSQRT_Click(object sender, EventArgs e)
        {
            try
            {
                output = MathLibaries.Algebraic.Square(double.Parse(txtDisplay.Text));
                txtDisplay.Text = output.ToString();
            }
            catch (Exception)
            {

            }
        }

        //Cubes the input
        private void BtnCube_Click(object sender, EventArgs e)
        {
            try
            {
                output = MathLibaries.Algebraic.Cube(double.Parse(txtDisplay.Text));
                txtDisplay.Text = output.ToString();

            }
            catch (Exception)
            {

            }
        }

        //Inverses the input
        private void BtnInverse_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtDisplay.Text.Equals("0"))
                {
                    output = MathLibaries.Algebraic.Inverse(double.Parse(txtDisplay.Text));
                    txtDisplay.Text = output.ToString();
                }
                else
                {
                    MessageBox.Show("Can't Divide by 0");
                    txtDisplay.Text = "0";
                }
            }
            catch (Exception)
            {

            }
        }

        //Finds the Tangent using the input
        private void BtnTan_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDisplay.Text.Equals("90"))
                {
                    MessageBox.Show("Invalid input cant be 90");
                    txtDisplay.Text = "0";
                }
                else
                {
                    output = MathLibaries.Trigonometric.Tan(double.Parse(txtDisplay.Text));
                    txtDisplay.Text = output.ToString();
                }
            }
            catch (Exception)
            {

            }
        }

        //Finds the sin of input
        private void BtnSin_Click(object sender, EventArgs e)
        {
            try
            {
                output = MathLibaries.Trigonometric.Sine(double.Parse(txtDisplay.Text));
                txtDisplay.Text = output.ToString();

            }
            catch (Exception)
            {

            }
        }

        //Finds the cos of input
        private void BtnCos_Click(object sender, EventArgs e)
        {
            try
            {
                output = MathLibaries.Trigonometric.Cos(double.Parse(txtDisplay.Text));
                txtDisplay.Text = output.ToString();

            }
            catch (Exception)
            {

            }
        }

        //Terminates application
        private void QuitMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Really Quit?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        //Clears the txt field
        private void ClearMenuItem_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";            
        }

        //Only allows numeric values, ".", backspace and "-" for negative values 
        private void TxtDisplay_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46 && ch != 45)
            {
                e.Handled = true;
            }
        }
    }
}
