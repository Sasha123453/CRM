namespace CRM
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
            this.addusers = new System.Windows.Forms.Button();
            this.allusersbutton = new System.Windows.Forms.Button();
            this.TaskTab = new System.Windows.Forms.TabControl();
            this.TaskAddPage = new System.Windows.Forms.TabPage();
            this.CleanAllUsersButton = new System.Windows.Forms.Button();
            this.UsersPage = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.TaskSortBox = new System.Windows.Forms.ComboBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.CleanAll = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.UsersBox = new System.Windows.Forms.TextBox();
            this.UsersListBox = new System.Windows.Forms.ListBox();
            this.TaskTab.SuspendLayout();
            this.TaskAddPage.SuspendLayout();
            this.UsersPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // nametextbox
            // 
            this.nametextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.1F);
            this.nametextbox.Location = new System.Drawing.Point(239, 20);
            this.nametextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nametextbox.Name = "nametextbox";
            this.nametextbox.Size = new System.Drawing.Size(265, 27);
            this.nametextbox.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.12F);
            this.button1.Location = new System.Drawing.Point(239, 397);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(265, 62);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // descbox
            // 
            this.descbox.Location = new System.Drawing.Point(239, 75);
            this.descbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.descbox.Name = "descbox";
            this.descbox.Size = new System.Drawing.Size(265, 159);
            this.descbox.TabIndex = 4;
            this.descbox.Text = "";
            // 
            // completebox
            // 
            this.completebox.Location = new System.Drawing.Point(239, 255);
            this.completebox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.completebox.Name = "completebox";
            this.completebox.Size = new System.Drawing.Size(265, 126);
            this.completebox.TabIndex = 5;
            this.completebox.Text = "";
            this.completebox.TextChanged += new System.EventHandler(this.completebox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F);
            this.label1.Location = new System.Drawing.Point(529, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F);
            this.label2.Location = new System.Drawing.Point(529, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 30);
            this.label2.TabIndex = 7;
            this.label2.Text = "Описание";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F);
            this.label3.Location = new System.Drawing.Point(529, 351);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 30);
            this.label3.TabIndex = 8;
            this.label3.Text = "Комментарий";
            // 
            // addusers
            // 
            this.addusers.Location = new System.Drawing.Point(60, 160);
            this.addusers.Name = "addusers";
            this.addusers.Size = new System.Drawing.Size(138, 74);
            this.addusers.TabIndex = 9;
            this.addusers.Text = "Добавить пользователей";
            this.addusers.UseVisualStyleBackColor = true;
            this.addusers.Click += new System.EventHandler(this.addusers_Click);
            // 
            // allusersbutton
            // 
            this.allusersbutton.Location = new System.Drawing.Point(60, 255);
            this.allusersbutton.Name = "allusersbutton";
            this.allusersbutton.Size = new System.Drawing.Size(138, 74);
            this.allusersbutton.TabIndex = 10;
            this.allusersbutton.Text = "Добавить всех пользователей";
            this.allusersbutton.UseVisualStyleBackColor = true;
            this.allusersbutton.Click += new System.EventHandler(this.allusersbutton_Click);
            // 
            // TaskTab
            // 
            this.TaskTab.Controls.Add(this.TaskAddPage);
            this.TaskTab.Controls.Add(this.UsersPage);
            this.TaskTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TaskTab.Location = new System.Drawing.Point(0, 0);
            this.TaskTab.Name = "TaskTab";
            this.TaskTab.SelectedIndex = 0;
            this.TaskTab.Size = new System.Drawing.Size(770, 504);
            this.TaskTab.TabIndex = 11;
            // 
            // TaskAddPage
            // 
            this.TaskAddPage.Controls.Add(this.CleanAllUsersButton);
            this.TaskAddPage.Controls.Add(this.nametextbox);
            this.TaskAddPage.Controls.Add(this.addusers);
            this.TaskAddPage.Controls.Add(this.allusersbutton);
            this.TaskAddPage.Controls.Add(this.label1);
            this.TaskAddPage.Controls.Add(this.descbox);
            this.TaskAddPage.Controls.Add(this.button1);
            this.TaskAddPage.Controls.Add(this.label3);
            this.TaskAddPage.Controls.Add(this.completebox);
            this.TaskAddPage.Controls.Add(this.label2);
            this.TaskAddPage.Location = new System.Drawing.Point(4, 25);
            this.TaskAddPage.Name = "TaskAddPage";
            this.TaskAddPage.Padding = new System.Windows.Forms.Padding(3);
            this.TaskAddPage.Size = new System.Drawing.Size(762, 475);
            this.TaskAddPage.TabIndex = 0;
            this.TaskAddPage.Text = "Задача";
            this.TaskAddPage.UseVisualStyleBackColor = true;
            // 
            // CleanAllUsersButton
            // 
            this.CleanAllUsersButton.Location = new System.Drawing.Point(60, 351);
            this.CleanAllUsersButton.Name = "CleanAllUsersButton";
            this.CleanAllUsersButton.Size = new System.Drawing.Size(138, 74);
            this.CleanAllUsersButton.TabIndex = 11;
            this.CleanAllUsersButton.Text = "Очистить всех пользователей";
            this.CleanAllUsersButton.UseVisualStyleBackColor = true;
            this.CleanAllUsersButton.Click += new System.EventHandler(this.CleanAllUsersButton_Click);
            // 
            // UsersPage
            // 
            this.UsersPage.Controls.Add(this.label4);
            this.UsersPage.Controls.Add(this.TaskSortBox);
            this.UsersPage.Controls.Add(this.BackButton);
            this.UsersPage.Controls.Add(this.CleanAll);
            this.UsersPage.Controls.Add(this.SaveButton);
            this.UsersPage.Controls.Add(this.DeleteButton);
            this.UsersPage.Controls.Add(this.AddButton);
            this.UsersPage.Controls.Add(this.UsersBox);
            this.UsersPage.Controls.Add(this.UsersListBox);
            this.UsersPage.Location = new System.Drawing.Point(4, 25);
            this.UsersPage.Name = "UsersPage";
            this.UsersPage.Padding = new System.Windows.Forms.Padding(3);
            this.UsersPage.Size = new System.Drawing.Size(762, 475);
            this.UsersPage.TabIndex = 1;
            this.UsersPage.Text = "Пользователи";
            this.UsersPage.UseVisualStyleBackColor = true;
            this.UsersPage.Click += new System.EventHandler(this.UsersPage_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label4.Location = new System.Drawing.Point(595, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 22);
            this.label4.TabIndex = 15;
            this.label4.Text = "Пользователи:";
            // 
            // TaskSortBox
            // 
            this.TaskSortBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TaskSortBox.FormattingEnabled = true;
            this.TaskSortBox.Items.AddRange(new object[] {
            "Все",
            "С задачи"});
            this.TaskSortBox.Location = new System.Drawing.Point(599, 231);
            this.TaskSortBox.Name = "TaskSortBox";
            this.TaskSortBox.Size = new System.Drawing.Size(134, 24);
            this.TaskSortBox.TabIndex = 14;
            this.TaskSortBox.SelectedIndexChanged += new System.EventHandler(this.TaskSortBox_SelectedIndexChanged);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(605, 74);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(114, 62);
            this.BackButton.TabIndex = 11;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // CleanAll
            // 
            this.CleanAll.Location = new System.Drawing.Point(465, 382);
            this.CleanAll.Name = "CleanAll";
            this.CleanAll.Size = new System.Drawing.Size(114, 55);
            this.CleanAll.TabIndex = 10;
            this.CleanAll.Text = "Очистить";
            this.CleanAll.UseVisualStyleBackColor = true;
            this.CleanAll.Click += new System.EventHandler(this.CleanAll_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(316, 382);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(114, 56);
            this.SaveButton.TabIndex = 9;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(167, 383);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(118, 54);
            this.DeleteButton.TabIndex = 6;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(20, 383);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(120, 54);
            this.AddButton.TabIndex = 3;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // UsersBox
            // 
            this.UsersBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.11F);
            this.UsersBox.Location = new System.Drawing.Point(20, 28);
            this.UsersBox.Name = "UsersBox";
            this.UsersBox.Size = new System.Drawing.Size(293, 28);
            this.UsersBox.TabIndex = 2;
            this.UsersBox.TextChanged += new System.EventHandler(this.UsersBox_TextChanged);
            // 
            // UsersListBox
            // 
            this.UsersListBox.FormattingEnabled = true;
            this.UsersListBox.ItemHeight = 16;
            this.UsersListBox.Location = new System.Drawing.Point(20, 74);
            this.UsersListBox.Name = "UsersListBox";
            this.UsersListBox.Size = new System.Drawing.Size(559, 292);
            this.UsersListBox.TabIndex = 1;
            // 
            // addedit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 504);
            this.Controls.Add(this.TaskTab);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "addedit";
            this.Text = "Редактирование задач";
            this.Load += new System.EventHandler(this.addedit_Load);
            this.TaskTab.ResumeLayout(false);
            this.TaskAddPage.ResumeLayout(false);
            this.TaskAddPage.PerformLayout();
            this.UsersPage.ResumeLayout(false);
            this.UsersPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox nametextbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox descbox;
        private System.Windows.Forms.RichTextBox completebox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addusers;
        private System.Windows.Forms.Button allusersbutton;
        private System.Windows.Forms.TabControl TaskTab;
        private System.Windows.Forms.TabPage TaskAddPage;
        private System.Windows.Forms.TabPage UsersPage;
        private System.Windows.Forms.ListBox UsersListBox;
        private System.Windows.Forms.TextBox UsersBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CleanAll;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button CleanAllUsersButton;
        private System.Windows.Forms.ComboBox TaskSortBox;
        private System.Windows.Forms.Label label4;
    }
}