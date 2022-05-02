namespace CRM
{
    partial class Users
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.addbutton = new System.Windows.Forms.Button();
            this.showuser = new System.Windows.Forms.Button();
            this.showall = new System.Windows.Forms.Button();
            this.delbutton = new System.Windows.Forms.Button();
            this.savebutton = new System.Windows.Forms.Button();
            this.makeadmin = new System.Windows.Forms.Button();
            this.makeuser = new System.Windows.Forms.Button();
            this.banbutton = new System.Windows.Forms.Button();
            this.unbanbutton = new System.Windows.Forms.Button();
            this.cleanusers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(26, 68);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(595, 292);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.11F);
            this.textBox1.Location = new System.Drawing.Point(26, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(293, 28);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // addbutton
            // 
            this.addbutton.Location = new System.Drawing.Point(26, 376);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(95, 54);
            this.addbutton.TabIndex = 2;
            this.addbutton.Text = "Добавить";
            this.addbutton.UseVisualStyleBackColor = true;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // showuser
            // 
            this.showuser.Location = new System.Drawing.Point(346, 376);
            this.showuser.Name = "showuser";
            this.showuser.Size = new System.Drawing.Size(87, 49);
            this.showuser.TabIndex = 3;
            this.showuser.Text = "Юзеры с задачи";
            this.showuser.UseVisualStyleBackColor = true;
            this.showuser.Click += new System.EventHandler(this.showuser_Click);
            // 
            // showall
            // 
            this.showall.Location = new System.Drawing.Point(496, 376);
            this.showall.Name = "showall";
            this.showall.Size = new System.Drawing.Size(91, 49);
            this.showall.TabIndex = 4;
            this.showall.Text = "Показать всё";
            this.showall.UseVisualStyleBackColor = true;
            this.showall.Click += new System.EventHandler(this.showall_Click);
            // 
            // delbutton
            // 
            this.delbutton.Location = new System.Drawing.Point(175, 376);
            this.delbutton.Name = "delbutton";
            this.delbutton.Size = new System.Drawing.Size(94, 49);
            this.delbutton.TabIndex = 5;
            this.delbutton.Text = "Удалить";
            this.delbutton.UseVisualStyleBackColor = true;
            this.delbutton.Click += new System.EventHandler(this.delbutton_Click);
            // 
            // savebutton
            // 
            this.savebutton.Location = new System.Drawing.Point(175, 431);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(94, 49);
            this.savebutton.TabIndex = 6;
            this.savebutton.Text = "Сохранить";
            this.savebutton.UseVisualStyleBackColor = true;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // makeadmin
            // 
            this.makeadmin.Location = new System.Drawing.Point(26, 376);
            this.makeadmin.Name = "makeadmin";
            this.makeadmin.Size = new System.Drawing.Size(153, 54);
            this.makeadmin.TabIndex = 7;
            this.makeadmin.Text = "Сделать администратором";
            this.makeadmin.UseVisualStyleBackColor = true;
            this.makeadmin.Click += new System.EventHandler(this.makeadmin_Click);
            // 
            // makeuser
            // 
            this.makeuser.Location = new System.Drawing.Point(202, 376);
            this.makeuser.Name = "makeuser";
            this.makeuser.Size = new System.Drawing.Size(138, 54);
            this.makeuser.TabIndex = 8;
            this.makeuser.Text = "Забрать права администратора";
            this.makeuser.UseVisualStyleBackColor = true;
            this.makeuser.Click += new System.EventHandler(this.makeuser_Click);
            // 
            // banbutton
            // 
            this.banbutton.Location = new System.Drawing.Point(496, 373);
            this.banbutton.Name = "banbutton";
            this.banbutton.Size = new System.Drawing.Size(125, 54);
            this.banbutton.TabIndex = 9;
            this.banbutton.Text = "Заблокировать";
            this.banbutton.UseVisualStyleBackColor = true;
            this.banbutton.Click += new System.EventHandler(this.banbutton_Click);
            // 
            // unbanbutton
            // 
            this.unbanbutton.Location = new System.Drawing.Point(357, 376);
            this.unbanbutton.Name = "unbanbutton";
            this.unbanbutton.Size = new System.Drawing.Size(133, 54);
            this.unbanbutton.TabIndex = 10;
            this.unbanbutton.Text = "Разблокировать";
            this.unbanbutton.UseVisualStyleBackColor = true;
            this.unbanbutton.Click += new System.EventHandler(this.unbanbutton_Click);
            // 
            // cleanusers
            // 
            this.cleanusers.Location = new System.Drawing.Point(339, 431);
            this.cleanusers.Name = "cleanusers";
            this.cleanusers.Size = new System.Drawing.Size(94, 49);
            this.cleanusers.TabIndex = 11;
            this.cleanusers.Text = "Очистить";
            this.cleanusers.UseVisualStyleBackColor = true;
            this.cleanusers.Click += new System.EventHandler(this.cleanusers_Click);
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 489);
            this.Controls.Add(this.cleanusers);
            this.Controls.Add(this.unbanbutton);
            this.Controls.Add(this.banbutton);
            this.Controls.Add(this.makeuser);
            this.Controls.Add(this.makeadmin);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.delbutton);
            this.Controls.Add(this.showall);
            this.Controls.Add(this.showuser);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Name = "Users";
            this.Text = "Users";
            this.Load += new System.EventHandler(this.Users_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.Button showuser;
        private System.Windows.Forms.Button showall;
        private System.Windows.Forms.Button delbutton;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.Button makeadmin;
        private System.Windows.Forms.Button makeuser;
        private System.Windows.Forms.Button banbutton;
        private System.Windows.Forms.Button unbanbutton;
        private System.Windows.Forms.Button cleanusers;
    }
}