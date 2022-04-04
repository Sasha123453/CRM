namespace CRM
{
    partial class userform
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.solutionbutton = new System.Windows.Forms.Button();
            this.updatebutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(178, 78);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(348, 212);
            this.listBox1.TabIndex = 0;
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // solutionbutton
            // 
            this.solutionbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.1F);
            this.solutionbutton.Location = new System.Drawing.Point(178, 335);
            this.solutionbutton.Name = "solutionbutton";
            this.solutionbutton.Size = new System.Drawing.Size(138, 58);
            this.solutionbutton.TabIndex = 1;
            this.solutionbutton.Text = "Добавить решение";
            this.solutionbutton.UseVisualStyleBackColor = true;
            this.solutionbutton.Click += new System.EventHandler(this.solutionbutton_Click);
            // 
            // updatebutton
            // 
            this.updatebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.1F);
            this.updatebutton.Location = new System.Drawing.Point(388, 335);
            this.updatebutton.Name = "updatebutton";
            this.updatebutton.Size = new System.Drawing.Size(138, 58);
            this.updatebutton.TabIndex = 2;
            this.updatebutton.Text = "Обновить";
            this.updatebutton.UseVisualStyleBackColor = true;
            this.updatebutton.Click += new System.EventHandler(this.updatebutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.1F);
            this.label1.Location = new System.Drawing.Point(605, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // userform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.updatebutton);
            this.Controls.Add(this.solutionbutton);
            this.Controls.Add(this.listBox1);
            this.Name = "userform";
            this.Text = "userform";
            this.Load += new System.EventHandler(this.userform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button solutionbutton;
        private System.Windows.Forms.Button updatebutton;
        private System.Windows.Forms.Label label1;
    }
}