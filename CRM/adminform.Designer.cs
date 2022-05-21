namespace CRM
{
    partial class adminform
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
            this.userlistbutton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.editbutton = new System.Windows.Forms.Button();
            this.addbutton = new System.Windows.Forms.Button();
            this.deletebutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.exitbutton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.addfriends = new System.Windows.Forms.Button();
            this.MainPage = new System.Windows.Forms.TabControl();
            this.AdminPage = new System.Windows.Forms.TabPage();
            this.TaskSortBox = new System.Windows.Forms.ComboBox();
            this.ChangeData = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.LoginBox = new System.Windows.Forms.TextBox();
            this.ChangeDataButton = new System.Windows.Forms.Button();
            this.UserPage = new System.Windows.Forms.TabPage();
            this.BackButton = new System.Windows.Forms.Button();
            this.BanButton = new System.Windows.Forms.Button();
            this.UnbanButton = new System.Windows.Forms.Button();
            this.MakeUser = new System.Windows.Forms.Button();
            this.makeadmin = new System.Windows.Forms.Button();
            this.UserSearchBox = new System.Windows.Forms.TextBox();
            this.UsersBox = new System.Windows.Forms.ListBox();
            this.MainPage.SuspendLayout();
            this.AdminPage.SuspendLayout();
            this.ChangeData.SuspendLayout();
            this.UserPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // userlistbutton
            // 
            this.userlistbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.1F);
            this.userlistbutton.Location = new System.Drawing.Point(10, 58);
            this.userlistbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userlistbutton.Name = "userlistbutton";
            this.userlistbutton.Size = new System.Drawing.Size(157, 57);
            this.userlistbutton.TabIndex = 0;
            this.userlistbutton.Text = "Список пользователей";
            this.userlistbutton.UseVisualStyleBackColor = true;
            this.userlistbutton.Click += new System.EventHandler(this.userlistbutton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(182, 58);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(415, 212);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // editbutton
            // 
            this.editbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.1F);
            this.editbutton.Location = new System.Drawing.Point(182, 286);
            this.editbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editbutton.Name = "editbutton";
            this.editbutton.Size = new System.Drawing.Size(114, 58);
            this.editbutton.TabIndex = 2;
            this.editbutton.Text = "Изменить задачу";
            this.editbutton.UseVisualStyleBackColor = true;
            this.editbutton.Click += new System.EventHandler(this.editbutton_Click);
            // 
            // addbutton
            // 
            this.addbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.1F);
            this.addbutton.Location = new System.Drawing.Point(326, 285);
            this.addbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(123, 60);
            this.addbutton.TabIndex = 3;
            this.addbutton.Text = "Добавить задачу";
            this.addbutton.UseVisualStyleBackColor = true;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // deletebutton
            // 
            this.deletebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.1F);
            this.deletebutton.Location = new System.Drawing.Point(478, 285);
            this.deletebutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(119, 60);
            this.deletebutton.TabIndex = 4;
            this.deletebutton.Text = "Скрыть задачу";
            this.deletebutton.UseVisualStyleBackColor = true;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.1F);
            this.button1.Location = new System.Drawing.Point(632, 285);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 58);
            this.button1.TabIndex = 9;
            this.button1.Text = "Удалить задачу";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // exitbutton
            // 
            this.exitbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.1F);
            this.exitbutton.Location = new System.Drawing.Point(10, 226);
            this.exitbutton.Margin = new System.Windows.Forms.Padding(4);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(155, 44);
            this.exitbutton.TabIndex = 10;
            this.exitbutton.Text = "Выйти";
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.1F);
            this.button2.Location = new System.Drawing.Point(12, 285);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 58);
            this.button2.TabIndex = 11;
            this.button2.Text = "Изменить данные";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // addfriends
            // 
            this.addfriends.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.1F);
            this.addfriends.Location = new System.Drawing.Point(10, 137);
            this.addfriends.Margin = new System.Windows.Forms.Padding(4);
            this.addfriends.Name = "addfriends";
            this.addfriends.Size = new System.Drawing.Size(155, 75);
            this.addfriends.TabIndex = 12;
            this.addfriends.Text = "Добавить друзей";
            this.addfriends.UseVisualStyleBackColor = true;
            this.addfriends.Click += new System.EventHandler(this.addfriends_Click);
            // 
            // MainPage
            // 
            this.MainPage.Controls.Add(this.AdminPage);
            this.MainPage.Controls.Add(this.ChangeData);
            this.MainPage.Controls.Add(this.UserPage);
            this.MainPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPage.Location = new System.Drawing.Point(0, 0);
            this.MainPage.Name = "MainPage";
            this.MainPage.SelectedIndex = 0;
            this.MainPage.Size = new System.Drawing.Size(786, 443);
            this.MainPage.TabIndex = 13;
            // 
            // AdminPage
            // 
            this.AdminPage.Controls.Add(this.TaskSortBox);
            this.AdminPage.Controls.Add(this.listBox1);
            this.AdminPage.Controls.Add(this.button1);
            this.AdminPage.Controls.Add(this.button2);
            this.AdminPage.Controls.Add(this.deletebutton);
            this.AdminPage.Controls.Add(this.addfriends);
            this.AdminPage.Controls.Add(this.addbutton);
            this.AdminPage.Controls.Add(this.exitbutton);
            this.AdminPage.Controls.Add(this.editbutton);
            this.AdminPage.Controls.Add(this.userlistbutton);
            this.AdminPage.Location = new System.Drawing.Point(4, 25);
            this.AdminPage.Name = "AdminPage";
            this.AdminPage.Padding = new System.Windows.Forms.Padding(3);
            this.AdminPage.Size = new System.Drawing.Size(778, 414);
            this.AdminPage.TabIndex = 0;
            this.AdminPage.Text = "tabPage1";
            this.AdminPage.UseVisualStyleBackColor = true;
            this.AdminPage.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // TaskSortBox
            // 
            this.TaskSortBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TaskSortBox.FormattingEnabled = true;
            this.TaskSortBox.Items.AddRange(new object[] {
            "Все задачи",
            "Выполненные",
            "Невыполненные"});
            this.TaskSortBox.Location = new System.Drawing.Point(621, 58);
            this.TaskSortBox.Name = "TaskSortBox";
            this.TaskSortBox.Size = new System.Drawing.Size(134, 24);
            this.TaskSortBox.TabIndex = 13;
            this.TaskSortBox.SelectedIndexChanged += new System.EventHandler(this.TaskSortBox_SelectedIndexChanged);
            // 
            // ChangeData
            // 
            this.ChangeData.Controls.Add(this.label2);
            this.ChangeData.Controls.Add(this.label1);
            this.ChangeData.Controls.Add(this.button3);
            this.ChangeData.Controls.Add(this.PassBox);
            this.ChangeData.Controls.Add(this.LoginBox);
            this.ChangeData.Controls.Add(this.ChangeDataButton);
            this.ChangeData.Location = new System.Drawing.Point(4, 25);
            this.ChangeData.Name = "ChangeData";
            this.ChangeData.Padding = new System.Windows.Forms.Padding(3);
            this.ChangeData.Size = new System.Drawing.Size(778, 414);
            this.ChangeData.TabIndex = 1;
            this.ChangeData.Text = "Изменение данных";
            this.ChangeData.UseVisualStyleBackColor = true;
            this.ChangeData.Click += new System.EventHandler(this.ChangeData_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.11F);
            this.label2.Location = new System.Drawing.Point(141, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Пароль:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.11F);
            this.label1.Location = new System.Drawing.Point(141, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Логин:";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.1F);
            this.button3.Location = new System.Drawing.Point(20, 21);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 40);
            this.button3.TabIndex = 3;
            this.button3.Text = "Назад";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // PassBox
            // 
            this.PassBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.1F);
            this.PassBox.Location = new System.Drawing.Point(253, 178);
            this.PassBox.Name = "PassBox";
            this.PassBox.Size = new System.Drawing.Size(196, 27);
            this.PassBox.TabIndex = 2;
            // 
            // LoginBox
            // 
            this.LoginBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.1F);
            this.LoginBox.Location = new System.Drawing.Point(253, 75);
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(196, 27);
            this.LoginBox.TabIndex = 1;
            // 
            // ChangeDataButton
            // 
            this.ChangeDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.12F);
            this.ChangeDataButton.Location = new System.Drawing.Point(253, 291);
            this.ChangeDataButton.Name = "ChangeDataButton";
            this.ChangeDataButton.Size = new System.Drawing.Size(196, 61);
            this.ChangeDataButton.TabIndex = 0;
            this.ChangeDataButton.Text = "Сохранить";
            this.ChangeDataButton.UseVisualStyleBackColor = true;
            this.ChangeDataButton.Click += new System.EventHandler(this.ChangeDataButton_Click);
            // 
            // UserPage
            // 
            this.UserPage.Controls.Add(this.BackButton);
            this.UserPage.Controls.Add(this.BanButton);
            this.UserPage.Controls.Add(this.UnbanButton);
            this.UserPage.Controls.Add(this.MakeUser);
            this.UserPage.Controls.Add(this.makeadmin);
            this.UserPage.Controls.Add(this.UserSearchBox);
            this.UserPage.Controls.Add(this.UsersBox);
            this.UserPage.Location = new System.Drawing.Point(4, 25);
            this.UserPage.Name = "UserPage";
            this.UserPage.Padding = new System.Windows.Forms.Padding(3);
            this.UserPage.Size = new System.Drawing.Size(778, 414);
            this.UserPage.TabIndex = 2;
            this.UserPage.Text = "Пользователи";
            this.UserPage.UseVisualStyleBackColor = true;
            this.UserPage.Click += new System.EventHandler(this.UserPage_Click);
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.1F);
            this.BackButton.Location = new System.Drawing.Point(578, 27);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(97, 28);
            this.BackButton.TabIndex = 13;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // BanButton
            // 
            this.BanButton.Location = new System.Drawing.Point(551, 340);
            this.BanButton.Name = "BanButton";
            this.BanButton.Size = new System.Drawing.Size(125, 54);
            this.BanButton.TabIndex = 12;
            this.BanButton.Text = "Заблокировать";
            this.BanButton.UseVisualStyleBackColor = true;
            this.BanButton.Click += new System.EventHandler(this.BanButton_Click);
            // 
            // UnbanButton
            // 
            this.UnbanButton.Location = new System.Drawing.Point(400, 340);
            this.UnbanButton.Name = "UnbanButton";
            this.UnbanButton.Size = new System.Drawing.Size(133, 54);
            this.UnbanButton.TabIndex = 11;
            this.UnbanButton.Text = "Разблокировать";
            this.UnbanButton.UseVisualStyleBackColor = true;
            this.UnbanButton.Click += new System.EventHandler(this.UnbanButton_Click);
            // 
            // MakeUser
            // 
            this.MakeUser.Location = new System.Drawing.Point(236, 340);
            this.MakeUser.Name = "MakeUser";
            this.MakeUser.Size = new System.Drawing.Size(138, 54);
            this.MakeUser.TabIndex = 9;
            this.MakeUser.Text = "Забрать права администратора";
            this.MakeUser.UseVisualStyleBackColor = true;
            this.MakeUser.Click += new System.EventHandler(this.MakeUser_Click);
            // 
            // makeadmin
            // 
            this.makeadmin.Location = new System.Drawing.Point(46, 340);
            this.makeadmin.Name = "makeadmin";
            this.makeadmin.Size = new System.Drawing.Size(153, 54);
            this.makeadmin.TabIndex = 8;
            this.makeadmin.Text = "Сделать администратором";
            this.makeadmin.UseVisualStyleBackColor = true;
            this.makeadmin.Click += new System.EventHandler(this.makeadmin_Click);
            // 
            // UserSearchBox
            // 
            this.UserSearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F);
            this.UserSearchBox.Location = new System.Drawing.Point(46, 27);
            this.UserSearchBox.Name = "UserSearchBox";
            this.UserSearchBox.Size = new System.Drawing.Size(215, 28);
            this.UserSearchBox.TabIndex = 2;
            this.UserSearchBox.TextChanged += new System.EventHandler(this.UserSearchBox_TextChanged);
            // 
            // UsersBox
            // 
            this.UsersBox.FormattingEnabled = true;
            this.UsersBox.ItemHeight = 16;
            this.UsersBox.Location = new System.Drawing.Point(46, 79);
            this.UsersBox.Name = "UsersBox";
            this.UsersBox.Size = new System.Drawing.Size(629, 244);
            this.UsersBox.TabIndex = 1;
            // 
            // adminform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 443);
            this.Controls.Add(this.MainPage);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "adminform";
            this.Text = "adminform";
            this.Load += new System.EventHandler(this.adminform_Load);
            this.MainPage.ResumeLayout(false);
            this.AdminPage.ResumeLayout(false);
            this.ChangeData.ResumeLayout(false);
            this.ChangeData.PerformLayout();
            this.UserPage.ResumeLayout(false);
            this.UserPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button userlistbutton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button editbutton;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button addfriends;
        private System.Windows.Forms.TabControl MainPage;
        private System.Windows.Forms.TabPage AdminPage;
        private System.Windows.Forms.TabPage ChangeData;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox PassBox;
        private System.Windows.Forms.TextBox LoginBox;
        private System.Windows.Forms.Button ChangeDataButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage UserPage;
        private System.Windows.Forms.ListBox UsersBox;
        private System.Windows.Forms.TextBox UserSearchBox;
        private System.Windows.Forms.Button makeadmin;
        private System.Windows.Forms.Button MakeUser;
        private System.Windows.Forms.Button UnbanButton;
        private System.Windows.Forms.Button BanButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.ComboBox TaskSortBox;
    }
}