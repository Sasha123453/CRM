namespace CRM
{
    partial class Form2
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
            this.registration = new System.Windows.Forms.Button();
            this.loginbox = new System.Windows.Forms.TextBox();
            this.passbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // registration
            // 
            this.registration.Location = new System.Drawing.Point(278, 302);
            this.registration.Name = "registration";
            this.registration.Size = new System.Drawing.Size(208, 74);
            this.registration.TabIndex = 0;
            this.registration.Text = "Зарегистрироваться";
            this.registration.UseVisualStyleBackColor = true;
            this.registration.Click += new System.EventHandler(this.registration_Click);
            // 
            // loginbox
            // 
            this.loginbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.1F);
            this.loginbox.Location = new System.Drawing.Point(265, 112);
            this.loginbox.Name = "loginbox";
            this.loginbox.Size = new System.Drawing.Size(221, 27);
            this.loginbox.TabIndex = 1;
            // 
            // passbox
            // 
            this.passbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.1F);
            this.passbox.Location = new System.Drawing.Point(265, 185);
            this.passbox.Name = "passbox";
            this.passbox.Size = new System.Drawing.Size(221, 27);
            this.passbox.TabIndex = 2;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.passbox);
            this.Controls.Add(this.loginbox);
            this.Controls.Add(this.registration);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button registration;
        private System.Windows.Forms.TextBox loginbox;
        private System.Windows.Forms.TextBox passbox;
    }
}