
namespace VD_Calculator
{
    partial class frmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Calculator = new System.Windows.Forms.Button();
            this.btnTTSV = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(105, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(461, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "ỨNG DỤNG TÍNH TOÁN CƠ BẢN";
            // 
            // btn_Calculator
            // 
            this.btn_Calculator.Location = new System.Drawing.Point(121, 158);
            this.btn_Calculator.Name = "btn_Calculator";
            this.btn_Calculator.Size = new System.Drawing.Size(200, 95);
            this.btn_Calculator.TabIndex = 1;
            this.btn_Calculator.Text = "Calculator";
            this.btn_Calculator.UseVisualStyleBackColor = true;
            this.btn_Calculator.Click += new System.EventHandler(this.btn_Calculator_Click);
            // 
            // btnTTSV
            // 
            this.btnTTSV.Location = new System.Drawing.Point(441, 158);
            this.btnTTSV.Name = "btnTTSV";
            this.btnTTSV.Size = new System.Drawing.Size(229, 95);
            this.btnTTSV.TabIndex = 2;
            this.btnTTSV.Text = "THông tin SV";
            this.btnTTSV.UseVisualStyleBackColor = true;
            this.btnTTSV.Click += new System.EventHandler(this.btnTTSV_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(837, 431);
            this.Controls.Add(this.btnTTSV);
            this.Controls.Add(this.btn_Calculator);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmMain";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Calculator;
        private System.Windows.Forms.Button btnTTSV;
    }
}