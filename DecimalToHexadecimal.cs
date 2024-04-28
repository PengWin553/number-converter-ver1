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
    public partial class DecimalToHexadecimal : Form
    {
        public DecimalToHexadecimal()
        {
            InitializeComponent();
        }

        private void txtBoxDecimal_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxDecimal.Text == "")
            {
                txtBoxHexadecimalConverted.Clear();
                txtBoxSolution.Clear();
            }
            else
            {
                double dec = double.Parse(txtBoxDecimal.Text);

                double dum = dec;
                double num = dec;
                double rem;

                string resultString = "";

                // double semiFinalresult = 0;
                // string result = "";

                string output = "";
                

                for(int i = 0; num > 0; i++)
                {
                    num = num / 16;
                    rem = num % 1;
                    num = Math.Floor(num);

                    // resultString = resultString + dum + "/16" + "\tResult = " + num + "\t\tRemainder = " + rem + Environment.NewLine;
                    resultString = resultString + dum + "/16" + "\tQuo = " + num + "\tRem = " + rem + "\tRem(Digit) = " + rem + " * 16" + "\tResults to = " + rem*16 + Environment.NewLine;
                    dum = Math.Floor(dum/16);

                    rem = rem * 16;

                    //output = output + rem.ToString();

                    if(rem == 10)
                    {
                        output = output + "A";
                    }
                    else if (rem == 11)
                    {
                        output = output + "B";
                    }
                    else if (rem == 12)
                    {
                        output = output + "C";
                    }
                    else if (rem == 13)
                    {
                        output = output + "D";
                    }
                    else if (rem == 14)
                    {
                        output = output + "E";
                    }
                    else if (rem == 15)
                    {
                        output = output + "F";
                    }
                    else
                    {
                        output = output + rem.ToString();
                    }

                   

                }

                char[] finalResult = output.ToCharArray();
                Array.Reverse(finalResult);
                string reversedFinalResult = new string(finalResult);
                txtBoxSolution.Text = resultString;
                txtBoxHexadecimalConverted.Text = reversedFinalResult.ToString();




               // txtBoxSolution.Text = Math.Floor(dec).ToString();






            }
        }
    }
}
