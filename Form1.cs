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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void loadForm(object Form)
        {
            if (this.panel2.Controls.Count > 0)
                this.panel2.Controls.RemoveAt(0);

            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(f);
            this.panel2.Tag = f;
            f.Show();
        }

        private void btnDtoB_Click(object sender, EventArgs e)
        {
            loadForm(new DecimalToBinary());
        }

        private void btnBtoD_Click(object sender, EventArgs e)
        {
            loadForm(new BinaryToDecimal());
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDtoH_Click(object sender, EventArgs e)
        {
            loadForm(new DecimalToHexadecimal());
        }

        private void btnHtoD_Click(object sender, EventArgs e)
        {
            loadForm(new HexadecimalToDecimal());
        }
    }
}
