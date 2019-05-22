using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                double firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
                double secondNumber = Convert.ToDouble(secondNumberTextBox.Text);
                double result = firstNumber + secondNumber;
                resultTextBox.Text = result.ToString();
            }
            catch(Exception r)
            {
                MessageBox.Show(r.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SubtractButton_Click(object sender, EventArgs e)
        {
            try
            {
                double firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
                double secondNumber = Convert.ToDouble(secondNumberTextBox.Text);
                double result = firstNumber - secondNumber;
                resultTextBox.Text = result.ToString();
            }
            catch (Exception r)
            {
                MessageBox.Show(r.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            try
            {
                double firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
                double secondNumber = Convert.ToDouble(secondNumberTextBox.Text);
                double result = firstNumber * secondNumber;
                resultTextBox.Text = result.ToString();
            }
            catch (Exception r)
            {
                MessageBox.Show(r.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            try
            {
                double firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
                double secondNumber = Convert.ToDouble(secondNumberTextBox.Text);
                double result = firstNumber / secondNumber;
                resultTextBox.Text = result.ToString();
            }
            catch (Exception r)
            {
                MessageBox.Show(r.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            firstNumberTextBox.Text = "";
            secondNumberTextBox.Text = "";
            resultTextBox.Text = "";
        }
    }
}
