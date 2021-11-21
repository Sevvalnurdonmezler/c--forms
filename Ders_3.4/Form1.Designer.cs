
namespace Ders_3._4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txt_number = new System.Windows.Forms.TextBox();
            this.lst_multiply = new System.Windows.Forms.ListBox();
            this.btn_multiply = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sayı Giriniz:";
            // 
            // txt_number
            // 
            this.txt_number.Location = new System.Drawing.Point(186, 80);
            this.txt_number.Name = "txt_number";
            this.txt_number.Size = new System.Drawing.Size(100, 23);
            this.txt_number.TabIndex = 1;
            // 
            // lst_multiply
            // 
            this.lst_multiply.FormattingEnabled = true;
            this.lst_multiply.ItemHeight = 15;
            this.lst_multiply.Location = new System.Drawing.Point(345, 80);
            this.lst_multiply.Name = "lst_multiply";
            this.lst_multiply.Size = new System.Drawing.Size(146, 214);
            this.lst_multiply.TabIndex = 2;
            // 
            // btn_multiply
            // 
            this.btn_multiply.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_multiply.Location = new System.Drawing.Point(87, 130);
            this.btn_multiply.Name = "btn_multiply";
            this.btn_multiply.Size = new System.Drawing.Size(199, 41);
            this.btn_multiply.TabIndex = 3;
            this.btn_multiply.Text = "Çarpımları";
            this.btn_multiply.UseVisualStyleBackColor = true;
            this.btn_multiply.Click += new System.EventHandler(this.btn_multiply_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_multiply);
            this.Controls.Add(this.lst_multiply);
            this.Controls.Add(this.txt_number);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_number;
        private System.Windows.Forms.ListBox lst_multiply;
        private System.Windows.Forms.Button btn_multiply;
    }
}

