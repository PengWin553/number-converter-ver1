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
    public partial class DecimalToBinary : Form
    {
        public DecimalToBinary()
        {
            InitializeComponent();
        }

        private void txtBoxDecimal_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxDecimal.Text == "")
            {
                txtBoxBinaryConverted.Clear();
                txtBoxSolution.Clear();
            }
            else
            {
                int decimalNum = int.Parse(txtBoxDecimal.Text);
                int decimalNum_forSolution = decimalNum;

                int[] bo = new int[1000];
                int i = 0;
                int j = i;

                while (decimalNum > 0)
                {
                    bo[i] = decimalNum % 2;
                    decimalNum = decimalNum / 2;
                    i++;
                }

                string output = "";
                for (j = i - 1; j >= 0; j--)
                {
                    output = output + bo[j].ToString();
                }

                txtBoxBinaryConverted.Text = output;

                int quo, rem;
                string solutionStrings = "";
                while (decimalNum_forSolution > 0)
                {
                    quo = decimalNum_forSolution / 2;
                    rem = decimalNum_forSolution % 2;
                    // printf("\nQuotient: %d/2 = %d\t\t\t|| Remainder = %d", decimalNum_forSolution, quo, rem);
                    // Console.Write($"\nQuotient = {quo}\t\t\t|| Remainder = {rem}");
                    solutionStrings = solutionStrings + decimalNum_forSolution + " / 2 = " + "\t\tQuotient = " + quo + "\t\tRemainder = " + rem + Environment.NewLine;
                    decimalNum_forSolution = quo;
                }

                txtBoxSolution.Text = solutionStrings + Environment.NewLine + "NOTE: Read the remainders upwards. ";
                
            }


        }

    }
}
