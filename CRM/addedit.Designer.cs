﻿namespace CRM
{
    partial class addedit
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
            this.nametextbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.descbox = new System.Windows.Forms.RichTextBox();
            this.completebox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nametextbox
            // 
            this.nametextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.1F);
            this.nametextbox.Location = new System.Drawing.Point(219, 27);
            this.nametextbox.Name = "nametextbox";
            this.nametextbox.Size = new System.Drawing.Size(266, 27);
            this.nametextbox.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.12F);
            this.button1.Location = new System.Drawing.Point(219, 426);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(266, 61);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // descbox
            // 
            this.descbox.Location = new System.Drawing.Point(219, 93);
            this.descbox.Name = "descbox";
            this.descbox.Size = new System.Drawing.Size(266, 159);
            this.descbox.TabIndex = 4;
            this.descbox.Text = "";
            // 
            // completebox
            // 
            this.completebox.Location = new System.Drawing.Point(219, 277);
            this.completebox.Name = "completebox";
            this.completebox.Size = new System.Drawing.Size(266, 126);
            this.completebox.TabIndex = 5;
            this.completebox.Text = "";
            this.completebox.TextChanged += new System.EventHandler(this.completebox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F);
            this.label1.Location = new System.Drawing.Point(578, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F);
            this.label2.Location = new System.Drawing.Point(578, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 30);
            this.label2.TabIndex = 7;
            this.label2.Text = "Описание";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F);
            this.label3.Location = new System.Drawing.Point(555, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 30);
            this.label3.TabIndex = 8;
            this.label3.Text = "Комментарий";
            // 
            // addedit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 499);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.completebox);
            this.Controls.Add(this.descbox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nametextbox);
            this.Name = "addedit";
            this.Text = "addedit";
            this.Load += new System.EventHandler(this.addedit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nametextbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox descbox;
        private System.Windows.Forms.RichTextBox completebox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}