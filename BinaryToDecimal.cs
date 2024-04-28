using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DecimalToBinary_BinaryToDecimal
{
    public partial class BinaryToDecimal : Form
    {
        public BinaryToDecimal()
        {
            InitializeComponent();
        }

        private void txtBoxBinary_TextChanged(object sender, EventArgs e)
        {
            //FIRST SOLUTION
            //if (txtBoxBinary.Text == "")
            //    txtBoxDecimalConverted.Clear();
            //else
            //{
            //    int dec = 0, temp, i, inc = 0, binary;

            //    binary = int.Parse(txtBoxBinary.Text);
            //    temp = binary;

            //    while (temp != 0)
            //    {
            //        i = temp % 10;
            //        dec = (int)(i * Math.Pow(2, inc)) + dec;
            //        temp = temp / 10;
            //        inc++;
            //    }

            //    txtBoxDecimalConverted.Text = dec.ToString();
            //}

            if (txtBoxBinary.Text == "")
            {
                txtBoxDecimalConverted.Clear();
                txtBoxSolution.Clear();
            }
            else
            {
                int num = int.Parse(txtBoxBinary.Text);
                int pow = 0;
                int dum;
                int result = 0;
                string stringResult = "";

                int[] numbers = num.ToString().ToCharArray().Select(c => Convert.ToInt32(c.ToString())).ToArray();
                Array.Reverse(numbers);

                for (int i = 0; i < numbers.Length; i++)
                {
                    dum = numbers[i] * Convert.ToInt32(Math.Pow(2, pow));
                    stringResult = stringResult + (numbers[i] + "(2)^" + pow + " = " + dum) + Environment.NewLine;
                    pow++;
                    result = result + dum;
                }

                txtBoxDecimalConverted.Text = result.ToString();
                //  Console.WriteLine($"Binary {num} = Decimal {result}");

                txtBoxSolution.Text = stringResult + Environment.NewLine + "Add the results to get " + result.ToString();
            }

        }

        private void BinaryToDecimal_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxDecimalConverted_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxSolution_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
