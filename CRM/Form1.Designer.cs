namespace CRM
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginbox = new System.Windows.Forms.TextBox();
            this.passbox = new System.Windows.Forms.TextBox();
            this.buttonlogin = new System.Windows.Forms.Button();
            this.registrationbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginbox
            // 
            this.loginbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.1F);
            this.loginbox.Location = new System.Drawing.Point(184, 120);
            this.loginbox.Name = "loginbox";
            this.loginbox.Size = new System.Drawing.Size(166, 27);
            this.loginbox.TabIndex = 0;
            // 
            // passbox
            // 
            this.passbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.1F);
            this.passbox.Location = new System.Drawing.Point(184, 213);
            this.passbox.Name = "passbox";
            this.passbox.Size = new System.Drawing.Size(166, 27);
            this.passbox.TabIndex = 1;
            // 
            // buttonlogin
            // 
            this.buttonlogin.Location = new System.Drawing.Point(184, 286);
            this.buttonlogin.Name = "buttonlogin";
            this.buttonlogin.Size = new System.Drawing.Size(166, 79);
            this.buttonlogin.TabIndex = 2;
            this.buttonlogin.Text = "Вход";
            this.buttonlogin.UseVisualStyleBackColor = true;
            this.buttonlogin.Click += new System.EventHandler(this.buttonlogin_Click);
            // 
            // registrationbutton
            // 
            this.registrationbutton.Location = new System.Drawing.Point(22, 31);
            this.registrationbutton.Name = "registrationbutton";
            this.registrationbutton.Size = new System.Drawing.Size(164, 39);
            this.registrationbutton.TabIndex = 3;
            this.registrationbutton.Text = "Зарегистрироваться";
            this.registrationbutton.UseVisualStyleBackColor = true;
            this.registrationbutton.Click += new System.EventHandler(this.registrationbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 430);
            this.Controls.Add(this.registrationbutton);
            this.Controls.Add(this.buttonlogin);
            this.Controls.Add(this.passbox);
            this.Controls.Add(this.loginbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loginbox;
        private System.Windows.Forms.TextBox passbox;
        private System.Windows.Forms.Button buttonlogin;
        private System.Windows.Forms.Button registrationbutton;
    }
}

