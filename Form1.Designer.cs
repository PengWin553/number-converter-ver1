
namespace DecimalToBinary_BinaryToDecimal
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDtoH = new System.Windows.Forms.Button();
            this.btnBtoD = new System.Windows.Forms.Button();
            this.btnDtoB = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnHtoD = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.btnHtoD);
            this.panel1.Controls.Add(this.btnDtoH);
            this.panel1.Controls.Add(this.btnBtoD);
            this.panel1.Controls.Add(this.btnDtoB);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 0;
            // 
            // btnDtoH
            // 
            this.btnDtoH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDtoH.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnDtoH.FlatAppearance.BorderSize = 2;
            this.btnDtoH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDtoH.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDtoH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDtoH.Location = new System.Drawing.Point(8, 127);
            this.btnDtoH.Name = "btnDtoH";
            this.btnDtoH.Size = new System.Drawing.Size(185, 57);
            this.btnDtoH.TabIndex = 2;
            this.btnDtoH.Text = "Decimal to Hexadecimal";
            this.btnDtoH.UseVisualStyleBackColor = false;
            this.btnDtoH.Click += new System.EventHandler(this.btnDtoH_Click);
            // 
            // btnBtoD
            // 
            this.btnBtoD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBtoD.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnBtoD.FlatAppearance.BorderSize = 2;
            this.btnBtoD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBtoD.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBtoD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBtoD.Location = new System.Drawing.Point(6, 66);
            this.btnBtoD.Name = "btnBtoD";
            this.btnBtoD.Size = new System.Drawing.Size(185, 54);
            this.btnBtoD.TabIndex = 1;
            this.btnBtoD.Text = "Binary to Decimal";
            this.btnBtoD.UseVisualStyleBackColor = false;
            this.btnBtoD.Click += new System.EventHandler(this.btnBtoD_Click);
            // 
            // btnDtoB
            // 
            this.btnDtoB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDtoB.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnDtoB.FlatAppearance.BorderSize = 2;
            this.btnDtoB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDtoB.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDtoB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDtoB.Location = new System.Drawing.Point(6, 6);
            this.btnDtoB.Name = "btnDtoB";
            this.btnDtoB.Size = new System.Drawing.Size(185, 54);
            this.btnDtoB.TabIndex = 0;
            this.btnDtoB.Text = "Decimal to Binary";
            this.btnDtoB.UseVisualStyleBackColor = false;
            this.btnDtoB.Click += new System.EventHandler(this.btnDtoB_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Location = new System.Drawing.Point(206, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(516, 450);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnHtoD
            // 
            this.btnHtoD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnHtoD.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnHtoD.FlatAppearance.BorderSize = 2;
            this.btnHtoD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHtoD.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHtoD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnHtoD.Location = new System.Drawing.Point(8, 197);
            this.btnHtoD.Name = "btnHtoD";
            this.btnHtoD.Size = new System.Drawing.Size(185, 57);
            this.btnHtoD.TabIndex = 3;
            this.btnHtoD.Text = "Hexadecimal to Decimal";
            this.btnHtoD.UseVisualStyleBackColor = false;
            this.btnHtoD.Click += new System.EventHandler(this.btnHtoD_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBtoD;
        private System.Windows.Forms.Button btnDtoB;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDtoH;
        private System.Windows.Forms.Button btnHtoD;
    }
}

