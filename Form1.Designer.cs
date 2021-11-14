
namespace WinFormsApp5
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
            this.txt_write = new System.Windows.Forms.TextBox();
            this.btn_try = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_write
            // 
            this.txt_write.Location = new System.Drawing.Point(294, 130);
            this.txt_write.Name = "txt_write";
            this.txt_write.PlaceholderText = "Lütfen geçerli bir renk giriniz";
            this.txt_write.Size = new System.Drawing.Size(223, 27);
            this.txt_write.TabIndex = 0;
            // 
            // btn_try
            // 
            this.btn_try.Location = new System.Drawing.Point(294, 200);
            this.btn_try.Name = "btn_try";
            this.btn_try.Size = new System.Drawing.Size(223, 47);
            this.btn_try.TabIndex = 1;
            this.btn_try.Text = "Dene";
            this.btn_try.UseVisualStyleBackColor = true;
            this.btn_try.Click += new System.EventHandler(this.btn_try_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Trafik Lamba değerini giriniz";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_try);
            this.Controls.Add(this.txt_write);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_write;
        private System.Windows.Forms.Button btn_try;
        private System.Windows.Forms.Label label1;
    }
}

