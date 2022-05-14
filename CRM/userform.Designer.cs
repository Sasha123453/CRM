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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.exitbutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.addfriends = new System.Windows.Forms.Button();
            this.taskcontrol = new System.Windows.Forms.Button();
            this.MainPage = new System.Windows.Forms.TabControl();
            this.UserPage = new System.Windows.Forms.TabPage();
            this.ChangeData = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BackDataButton = new System.Windows.Forms.Button();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.LoginBox = new System.Windows.Forms.TextBox();
            this.ChangeDataButton = new System.Windows.Forms.Button();
            this.TaskPage = new System.Windows.Forms.TabPage();
            this.UpdateNotCompleted = new System.Windows.Forms.Button();
            this.UpdateCompleted = new System.Windows.Forms.Button();
            this.UpdateAll = new System.Windows.Forms.Button();
            this.DelButton = new System.Windows.Forms.Button();
            this.CheckButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.TaskListBox = new System.Windows.Forms.ListBox();
            this.TaskBackButton = new System.Windows.Forms.Button();
            this.MainPage.SuspendLayout();
            this.UserPage.SuspendLayout();
            this.ChangeData.SuspendLayout();
            this.TaskPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(131, 73);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(348, 212);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // solutionbutton
            // 
            this.solutionbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.1F);
            this.solutionbutton.Location = new System.Drawing.Point(131, 455);
            this.solutionbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.solutionbutton.Name = "solutionbutton";
            this.solutionbutton.Size = new System.Drawing.Size(139, 58);
            this.solutionbutton.TabIndex = 1;
            this.solutionbutton.Text = "Добавить решение";
            this.solutionbutton.UseVisualStyleBackColor = true;
            this.solutionbutton.Click += new System.EventHandler(this.solutionbutton_Click);
            // 
            // updatebutton
            // 
            this.updatebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.1F);
            this.updatebutton.Location = new System.Drawing.Point(340, 455);
            this.updatebutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updatebutton.Name = "updatebutton";
            this.updatebutton.Size = new System.Drawing.Size(139, 58);
            this.updatebutton.TabIndex = 2;
            this.updatebutton.Text = "Обновить";
            this.updatebutton.UseVisualStyleBackColor = true;
            this.updatebutton.Click += new System.EventHandler(this.updatebutton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(131, 306);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(348, 117);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // exitbutton
            // 
            this.exitbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.exitbutton.Location = new System.Drawing.Point(9, 32);
            this.exitbutton.Margin = new System.Windows.Forms.Padding(4);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(108, 38);
            this.exitbutton.TabIndex = 5;
            this.exitbutton.Text = "Выйти";
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.button1.Location = new System.Drawing.Point(518, 73);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 73);
            this.button1.TabIndex = 6;
            this.button1.Text = "Поменять данные";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // addfriends
            // 
            this.addfriends.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.addfriends.Location = new System.Drawing.Point(518, 191);
            this.addfriends.Margin = new System.Windows.Forms.Padding(4);
            this.addfriends.Name = "addfriends";
            this.addfriends.Size = new System.Drawing.Size(156, 73);
            this.addfriends.TabIndex = 7;
            this.addfriends.Text = "Друзья";
            this.addfriends.UseVisualStyleBackColor = true;
            this.addfriends.Click += new System.EventHandler(this.addfriends_Click);
            // 
            // taskcontrol
            // 
            this.taskcontrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.taskcontrol.Location = new System.Drawing.Point(518, 306);
            this.taskcontrol.Margin = new System.Windows.Forms.Padding(4);
            this.taskcontrol.Name = "taskcontrol";
            this.taskcontrol.Size = new System.Drawing.Size(156, 73);
            this.taskcontrol.TabIndex = 8;
            this.taskcontrol.Text = "Управление задачами";
            this.taskcontrol.UseVisualStyleBackColor = true;
            this.taskcontrol.Click += new System.EventHandler(this.taskcontrol_Click);
            // 
            // MainPage
            // 
            this.MainPage.Controls.Add(this.UserPage);
            this.MainPage.Controls.Add(this.ChangeData);
            this.MainPage.Controls.Add(this.TaskPage);
            this.MainPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPage.Location = new System.Drawing.Point(0, 0);
            this.MainPage.Name = "MainPage";
            this.MainPage.SelectedIndex = 0;
            this.MainPage.Size = new System.Drawing.Size(757, 570);
            this.MainPage.TabIndex = 9;
            // 
            // UserPage
            // 
            this.UserPage.Controls.Add(this.listBox1);
            this.UserPage.Controls.Add(this.updatebutton);
            this.UserPage.Controls.Add(this.richTextBox1);
            this.UserPage.Controls.Add(this.solutionbutton);
            this.UserPage.Controls.Add(this.taskcontrol);
            this.UserPage.Controls.Add(this.exitbutton);
            this.UserPage.Controls.Add(this.addfriends);
            this.UserPage.Controls.Add(this.button1);
            this.UserPage.Location = new System.Drawing.Point(4, 25);
            this.UserPage.Name = "UserPage";
            this.UserPage.Padding = new System.Windows.Forms.Padding(3);
            this.UserPage.Size = new System.Drawing.Size(749, 541);
            this.UserPage.TabIndex = 0;
            this.UserPage.Text = "tabpage1";
            this.UserPage.UseVisualStyleBackColor = true;
            // 
            // ChangeData
            // 
            this.ChangeData.Controls.Add(this.label2);
            this.ChangeData.Controls.Add(this.label1);
            this.ChangeData.Controls.Add(this.BackDataButton);
            this.ChangeData.Controls.Add(this.PassBox);
            this.ChangeData.Controls.Add(this.LoginBox);
            this.ChangeData.Controls.Add(this.ChangeDataButton);
            this.ChangeData.Location = new System.Drawing.Point(4, 25);
            this.ChangeData.Name = "ChangeData";
            this.ChangeData.Padding = new System.Windows.Forms.Padding(3);
            this.ChangeData.Size = new System.Drawing.Size(749, 541);
            this.ChangeData.TabIndex = 1;
            this.ChangeData.Text = "?";
            this.ChangeData.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.11F);
            this.label2.Location = new System.Drawing.Point(113, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Пароль:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.11F);
            this.label1.Location = new System.Drawing.Point(113, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Логин:";
            // 
            // BackDataButton
            // 
            this.BackDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.1F);
            this.BackDataButton.Location = new System.Drawing.Point(23, 52);
            this.BackDataButton.Name = "BackDataButton";
            this.BackDataButton.Size = new System.Drawing.Size(171, 57);
            this.BackDataButton.TabIndex = 9;
            this.BackDataButton.Text = "Назад";
            this.BackDataButton.UseVisualStyleBackColor = true;
            this.BackDataButton.Click += new System.EventHandler(this.BackDataButton_Click);
            // 
            // PassBox
            // 
            this.PassBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.1F);
            this.PassBox.Location = new System.Drawing.Point(212, 280);
            this.PassBox.Name = "PassBox";
            this.PassBox.Size = new System.Drawing.Size(277, 30);
            this.PassBox.TabIndex = 8;
            // 
            // LoginBox
            // 
            this.LoginBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.1F);
            this.LoginBox.Location = new System.Drawing.Point(212, 187);
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(277, 30);
            this.LoginBox.TabIndex = 7;
            // 
            // ChangeDataButton
            // 
            this.ChangeDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.12F);
            this.ChangeDataButton.Location = new System.Drawing.Point(212, 352);
            this.ChangeDataButton.Name = "ChangeDataButton";
            this.ChangeDataButton.Size = new System.Drawing.Size(277, 75);
            this.ChangeDataButton.TabIndex = 6;
            this.ChangeDataButton.Text = "Сохранить";
            this.ChangeDataButton.UseVisualStyleBackColor = true;
            this.ChangeDataButton.Click += new System.EventHandler(this.ChangeDataButton_Click);
            // 
            // TaskPage
            // 
            this.TaskPage.Controls.Add(this.TaskBackButton);
            this.TaskPage.Controls.Add(this.UpdateNotCompleted);
            this.TaskPage.Controls.Add(this.UpdateCompleted);
            this.TaskPage.Controls.Add(this.UpdateAll);
            this.TaskPage.Controls.Add(this.DelButton);
            this.TaskPage.Controls.Add(this.CheckButton);
            this.TaskPage.Controls.Add(this.EditButton);
            this.TaskPage.Controls.Add(this.AddButton);
            this.TaskPage.Controls.Add(this.TaskListBox);
            this.TaskPage.Location = new System.Drawing.Point(4, 25);
            this.TaskPage.Name = "TaskPage";
            this.TaskPage.Padding = new System.Windows.Forms.Padding(3);
            this.TaskPage.Size = new System.Drawing.Size(749, 541);
            this.TaskPage.TabIndex = 2;
            this.TaskPage.Text = "Задачи";
            this.TaskPage.UseVisualStyleBackColor = true;
            // 
            // UpdateNotCompleted
            // 
            this.UpdateNotCompleted.Location = new System.Drawing.Point(571, 293);
            this.UpdateNotCompleted.Name = "UpdateNotCompleted";
            this.UpdateNotCompleted.Size = new System.Drawing.Size(137, 99);
            this.UpdateNotCompleted.TabIndex = 15;
            this.UpdateNotCompleted.Text = "Отобразить невыполненные";
            this.UpdateNotCompleted.UseVisualStyleBackColor = true;
            this.UpdateNotCompleted.Click += new System.EventHandler(this.UpdateNotCompleted_Click);
            // 
            // UpdateCompleted
            // 
            this.UpdateCompleted.Location = new System.Drawing.Point(571, 187);
            this.UpdateCompleted.Name = "UpdateCompleted";
            this.UpdateCompleted.Size = new System.Drawing.Size(137, 97);
            this.UpdateCompleted.TabIndex = 14;
            this.UpdateCompleted.Text = "Отобразить выполненные";
            this.UpdateCompleted.UseVisualStyleBackColor = true;
            this.UpdateCompleted.Click += new System.EventHandler(this.UpdateCompleted_Click);
            // 
            // UpdateAll
            // 
            this.UpdateAll.Location = new System.Drawing.Point(571, 84);
            this.UpdateAll.Name = "UpdateAll";
            this.UpdateAll.Size = new System.Drawing.Size(137, 94);
            this.UpdateAll.TabIndex = 13;
            this.UpdateAll.Text = "Отобразить всё";
            this.UpdateAll.UseVisualStyleBackColor = true;
            this.UpdateAll.Click += new System.EventHandler(this.UpdateAll_Click);
            // 
            // DelButton
            // 
            this.DelButton.Location = new System.Drawing.Point(457, 402);
            this.DelButton.Name = "DelButton";
            this.DelButton.Size = new System.Drawing.Size(96, 65);
            this.DelButton.TabIndex = 12;
            this.DelButton.Text = "Удалить";
            this.DelButton.UseVisualStyleBackColor = true;
            this.DelButton.Click += new System.EventHandler(this.DelButton_Click);
            // 
            // CheckButton
            // 
            this.CheckButton.Location = new System.Drawing.Point(338, 402);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(108, 65);
            this.CheckButton.TabIndex = 11;
            this.CheckButton.Text = "Скрыть";
            this.CheckButton.UseVisualStyleBackColor = true;
            this.CheckButton.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(223, 402);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(102, 65);
            this.EditButton.TabIndex = 10;
            this.EditButton.Text = "Изменить";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(93, 402);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(106, 65);
            this.AddButton.TabIndex = 9;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // TaskListBox
            // 
            this.TaskListBox.FormattingEnabled = true;
            this.TaskListBox.ItemHeight = 16;
            this.TaskListBox.Location = new System.Drawing.Point(93, 84);
            this.TaskListBox.Name = "TaskListBox";
            this.TaskListBox.Size = new System.Drawing.Size(460, 308);
            this.TaskListBox.TabIndex = 8;
            this.TaskListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TaskListBox_MouseDoubleClick);
            // 
            // TaskBackButton
            // 
            this.TaskBackButton.Location = new System.Drawing.Point(21, 26);
            this.TaskBackButton.Name = "TaskBackButton";
            this.TaskBackButton.Size = new System.Drawing.Size(98, 41);
            this.TaskBackButton.TabIndex = 17;
            this.TaskBackButton.Text = "Назад";
            this.TaskBackButton.UseVisualStyleBackColor = true;
            this.TaskBackButton.Click += new System.EventHandler(this.TaskBackButton_Click);
            // 
            // userform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 570);
            this.Controls.Add(this.MainPage);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "userform";
            this.Text = "userform";
            this.Load += new System.EventHandler(this.userform_Load);
            this.MainPage.ResumeLayout(false);
            this.UserPage.ResumeLayout(false);
            this.ChangeData.ResumeLayout(false);
            this.ChangeData.PerformLayout();
            this.TaskPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button solutionbutton;
        private System.Windows.Forms.Button updatebutton;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button addfriends;
        private System.Windows.Forms.Button taskcontrol;
        private System.Windows.Forms.TabControl MainPage;
        private System.Windows.Forms.TabPage UserPage;
        private System.Windows.Forms.TabPage ChangeData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BackDataButton;
        private System.Windows.Forms.TextBox PassBox;
        private System.Windows.Forms.TextBox LoginBox;
        private System.Windows.Forms.Button ChangeDataButton;
        private System.Windows.Forms.TabPage TaskPage;
        private System.Windows.Forms.Button UpdateNotCompleted;
        private System.Windows.Forms.Button UpdateCompleted;
        private System.Windows.Forms.Button UpdateAll;
        private System.Windows.Forms.Button DelButton;
        private System.Windows.Forms.Button CheckButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.ListBox TaskListBox;
        private System.Windows.Forms.Button TaskBackButton;
    }
}