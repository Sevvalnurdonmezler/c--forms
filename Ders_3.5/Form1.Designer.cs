
namespace Ders_3._5
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
            this.btn_show = new System.Windows.Forms.Button();
            this.txt_message = new System.Windows.Forms.TextBox();
            this.txt_messagenumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lst_message = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_show
            // 
            this.btn_show.Location = new System.Drawing.Point(194, 144);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(134, 43);
            this.btn_show.TabIndex = 0;
            this.btn_show.Text = "Göster";
            this.btn_show.UseVisualStyleBackColor = true;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // txt_message
            // 
            this.txt_message.Location = new System.Drawing.Point(194, 46);
            this.txt_message.Name = "txt_message";
            this.txt_message.Size = new System.Drawing.Size(134, 23);
            this.txt_message.TabIndex = 1;
            // 
            // txt_messagenumber
            // 
            this.txt_messagenumber.Location = new System.Drawing.Point(194, 102);
            this.txt_messagenumber.Name = "txt_messagenumber";
            this.txt_messagenumber.Size = new System.Drawing.Size(134, 23);
            this.txt_messagenumber.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(123, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mesaj";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(100, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mesaj Adeti";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lst_message
            // 
            this.lst_message.FormattingEnabled = true;
            this.lst_message.ItemHeight = 15;
            this.lst_message.Location = new System.Drawing.Point(443, 42);
            this.lst_message.Name = "lst_message";
            this.lst_message.Size = new System.Drawing.Size(156, 139);
            this.lst_message.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lst_message);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_messagenumber);
            this.Controls.Add(this.txt_message);
            this.Controls.Add(this.btn_show);
            this.Name = "Form1";
            this.Text = "Ders_3.5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.TextBox txt_message;
        private System.Windows.Forms.TextBox txt_messagenumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lst_message;
    }
}

