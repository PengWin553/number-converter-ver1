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
    public partial class HexadecimalToDecimal : Form
    {
        public HexadecimalToDecimal()
        {
            InitializeComponent();
        }

        private void txtBoxHex_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxHex.Text == "")
            {
                txtBoxDecCon.Clear();
                txtBoxSol.Clear();
            }
            else
            {
                string input = txtBoxHex.Text.ToUpper();
                char[] array = input.ToCharArray();
                
                Array.Reverse(array);

                string sol = "";
                string stringDum = "";
                int[] numbers = new int[array.Length];
                
                int dum = 0;
                int answer = 0;
                int pow = 0;
                

                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == 'A')
                    {
                        numbers[i] = 10;
                        stringDum = "A is converted to 10";
                        sol = sol + stringDum + Environment.NewLine;

                    }
                    else if (array[i] == 'B')
                    {
                        numbers[i] = 11;
                        stringDum = "B is converted to 11";
                        sol = sol + stringDum + Environment.NewLine;
                    }
                    else if (array[i] == 'C')
                    {
                        numbers[i] = 12;
                        stringDum = "C is converted to 12";
                        sol = sol + stringDum + Environment.NewLine;
                    }
                    else if (array[i] == 'D')
                    {
                        numbers[i] = 13;
                        stringDum = "D is converted to 13";
                        sol = sol + stringDum + Environment.NewLine;
                    }
                    else if (array[i] == 'E')
                    {
                        numbers[i] = 14;
                        stringDum = "E is converted to 14";
                        sol = sol + stringDum + Environment.NewLine;
                    }
                    else if (array[i] == 'F')
                    {
                        numbers[i] = 15;
                        stringDum = "F is converted to 15";
                        sol = sol + stringDum + Environment.NewLine;
                    }
                    else if(array[i] >= '0' && array[i] <= '9')
                    {
                        numbers[i] = array[i] - '0';
                    }

                    answer += numbers[i];
                }

                string newLine = Environment.NewLine;
                sol += Environment.NewLine;

                int result = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    dum = numbers[i] * Convert.ToInt32(Math.Pow(16, pow));
                    sol = sol + (numbers[i] + "(16)^" + pow + " = " + dum) + Environment.NewLine;
                    pow++;
                    result = result + dum;
                }

                txtBoxDecCon.Text = result.ToString();
                txtBoxSol.Text = sol;

                txtBoxSol.Text = sol + Environment.NewLine + "Add the results to get " + result.ToString();
            }

        }

        private void HexadecimalToDecimal_Load(object sender, EventArgs e)
        {

        }
    }
}
