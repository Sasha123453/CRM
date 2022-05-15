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
            this.LoginControl = new System.Windows.Forms.TabControl();
            this.LoginPage = new System.Windows.Forms.TabPage();
            this.RegistrationPage = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.loginb = new System.Windows.Forms.Button();
            this.registrb = new System.Windows.Forms.Button();
            this.LoginControl.SuspendLayout();
            this.LoginPage.SuspendLayout();
            this.RegistrationPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginbox
            // 
            this.loginbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.1F);
            this.loginbox.Location = new System.Drawing.Point(168, 100);
            this.loginbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loginbox.Name = "loginbox";
            this.loginbox.Size = new System.Drawing.Size(167, 27);
            this.loginbox.TabIndex = 0;
            // 
            // passbox
            // 
            this.passbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.1F);
            this.passbox.Location = new System.Drawing.Point(168, 152);
            this.passbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passbox.Name = "passbox";
            this.passbox.Size = new System.Drawing.Size(167, 27);
            this.passbox.TabIndex = 1;
            // 
            // buttonlogin
            // 
            this.buttonlogin.Location = new System.Drawing.Point(168, 199);
            this.buttonlogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonlogin.Name = "buttonlogin";
            this.buttonlogin.Size = new System.Drawing.Size(165, 63);
            this.buttonlogin.TabIndex = 2;
            this.buttonlogin.Text = "Вход";
            this.buttonlogin.UseVisualStyleBackColor = true;
            this.buttonlogin.Click += new System.EventHandler(this.buttonlogin_Click);
            // 
            // registrationbutton
            // 
            this.registrationbutton.Location = new System.Drawing.Point(26, 19);
            this.registrationbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.registrationbutton.Name = "registrationbutton";
            this.registrationbutton.Size = new System.Drawing.Size(164, 39);
            this.registrationbutton.TabIndex = 3;
            this.registrationbutton.Text = "Зарегистрироваться";
            this.registrationbutton.UseVisualStyleBackColor = true;
            this.registrationbutton.Click += new System.EventHandler(this.registrationbutton_Click);
            // 
            // LoginControl
            // 
            this.LoginControl.Controls.Add(this.LoginPage);
            this.LoginControl.Controls.Add(this.RegistrationPage);
            this.LoginControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginControl.Location = new System.Drawing.Point(0, 0);
            this.LoginControl.Name = "LoginControl";
            this.LoginControl.SelectedIndex = 0;
            this.LoginControl.Size = new System.Drawing.Size(533, 364);
            this.LoginControl.TabIndex = 4;
            // 
            // LoginPage
            // 
            this.LoginPage.Controls.Add(this.registrationbutton);
            this.LoginPage.Controls.Add(this.buttonlogin);
            this.LoginPage.Controls.Add(this.loginbox);
            this.LoginPage.Controls.Add(this.passbox);
            this.LoginPage.Location = new System.Drawing.Point(4, 25);
            this.LoginPage.Name = "LoginPage";
            this.LoginPage.Padding = new System.Windows.Forms.Padding(3);
            this.LoginPage.Size = new System.Drawing.Size(525, 335);
            this.LoginPage.TabIndex = 0;
            this.LoginPage.Text = "Вход";
            this.LoginPage.UseVisualStyleBackColor = true;
            this.LoginPage.Click += new System.EventHandler(this.LoginPage_Click);
            // 
            // RegistrationPage
            // 
            this.RegistrationPage.Controls.Add(this.label2);
            this.RegistrationPage.Controls.Add(this.label1);
            this.RegistrationPage.Controls.Add(this.textBox2);
            this.RegistrationPage.Controls.Add(this.textBox1);
            this.RegistrationPage.Controls.Add(this.loginb);
            this.RegistrationPage.Controls.Add(this.registrb);
            this.RegistrationPage.Location = new System.Drawing.Point(4, 25);
            this.RegistrationPage.Name = "RegistrationPage";
            this.RegistrationPage.Padding = new System.Windows.Forms.Padding(3);
            this.RegistrationPage.Size = new System.Drawing.Size(525, 335);
            this.RegistrationPage.TabIndex = 1;
            this.RegistrationPage.Text = "Регистрация";
            this.RegistrationPage.UseVisualStyleBackColor = true;
            this.RegistrationPage.Click += new System.EventHandler(this.RegistrationPage_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.1F);
            this.label2.Location = new System.Drawing.Point(62, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Пароль:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.1F);
            this.label1.Location = new System.Drawing.Point(62, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Логин:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.1F);
            this.textBox2.Location = new System.Drawing.Point(167, 175);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(167, 27);
            this.textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.1F);
            this.textBox1.Location = new System.Drawing.Point(167, 101);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(167, 27);
            this.textBox1.TabIndex = 6;
            // 
            // loginb
            // 
            this.loginb.Location = new System.Drawing.Point(18, 29);
            this.loginb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loginb.Name = "loginb";
            this.loginb.Size = new System.Drawing.Size(101, 50);
            this.loginb.TabIndex = 5;
            this.loginb.Text = "Вход";
            this.loginb.UseVisualStyleBackColor = true;
            this.loginb.Click += new System.EventHandler(this.loginb_Click);
            // 
            // registrb
            // 
            this.registrb.Location = new System.Drawing.Point(170, 232);
            this.registrb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.registrb.Name = "registrb";
            this.registrb.Size = new System.Drawing.Size(164, 39);
            this.registrb.TabIndex = 4;
            this.registrb.Text = "Зарегистрироваться";
            this.registrb.UseVisualStyleBackColor = true;
            this.registrb.Click += new System.EventHandler(this.registrb_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 364);
            this.Controls.Add(this.LoginControl);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.LoginControl.ResumeLayout(false);
            this.LoginPage.ResumeLayout(false);
            this.LoginPage.PerformLayout();
            this.RegistrationPage.ResumeLayout(false);
            this.RegistrationPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox loginbox;
        private System.Windows.Forms.TextBox passbox;
        private System.Windows.Forms.Button buttonlogin;
        private System.Windows.Forms.Button registrationbutton;
        private System.Windows.Forms.TabControl LoginControl;
        private System.Windows.Forms.TabPage LoginPage;
        private System.Windows.Forms.TabPage RegistrationPage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button loginb;
        private System.Windows.Forms.Button registrb;
    }
}

