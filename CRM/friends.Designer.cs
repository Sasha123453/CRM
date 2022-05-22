namespace CRM
{
    partial class friends
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
            this.addbutton = new System.Windows.Forms.Button();
            this.deletefriend = new System.Windows.Forms.Button();
            this.showall = new System.Windows.Forms.Button();
            this.showfriends = new System.Windows.Forms.Button();
            this.showquerys = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 60);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(536, 276);
            this.listBox1.TabIndex = 0;
            // 
            // addbutton
            // 
            this.addbutton.Location = new System.Drawing.Point(12, 352);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(120, 44);
            this.addbutton.TabIndex = 1;
            this.addbutton.Text = "Добавить";
            this.addbutton.UseVisualStyleBackColor = true;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // deletefriend
            // 
            this.deletefriend.Location = new System.Drawing.Point(159, 352);
            this.deletefriend.Name = "deletefriend";
            this.deletefriend.Size = new System.Drawing.Size(120, 44);
            this.deletefriend.TabIndex = 2;
            this.deletefriend.Text = "Удалить";
            this.deletefriend.UseVisualStyleBackColor = true;
            this.deletefriend.Click += new System.EventHandler(this.deletefriend_Click);
            // 
            // showall
            // 
            this.showall.Location = new System.Drawing.Point(304, 352);
            this.showall.Name = "showall";
            this.showall.Size = new System.Drawing.Size(110, 44);
            this.showall.TabIndex = 3;
            this.showall.Text = "Показать всех";
            this.showall.UseVisualStyleBackColor = true;
            this.showall.Click += new System.EventHandler(this.showall_Click);
            // 
            // showfriends
            // 
            this.showfriends.Location = new System.Drawing.Point(438, 352);
            this.showfriends.Name = "showfriends";
            this.showfriends.Size = new System.Drawing.Size(110, 44);
            this.showfriends.TabIndex = 4;
            this.showfriends.Text = "Показать друзей";
            this.showfriends.UseVisualStyleBackColor = true;
            this.showfriends.Click += new System.EventHandler(this.showfriends_Click);
            // 
            // showquerys
            // 
            this.showquerys.Location = new System.Drawing.Point(565, 352);
            this.showquerys.Name = "showquerys";
            this.showquerys.Size = new System.Drawing.Size(110, 44);
            this.showquerys.TabIndex = 5;
            this.showquerys.Text = "Показать заявки";
            this.showquerys.UseVisualStyleBackColor = true;
            this.showquerys.Click += new System.EventHandler(this.showquerys_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.12F);
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(236, 30);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // friends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 408);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.showquerys);
            this.Controls.Add(this.showfriends);
            this.Controls.Add(this.showall);
            this.Controls.Add(this.deletefriend);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.listBox1);
            this.Name = "friends";
            this.Text = "Друзья";
            this.Load += new System.EventHandler(this.friends_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.Button deletefriend;
        private System.Windows.Forms.Button showall;
        private System.Windows.Forms.Button showfriends;
        private System.Windows.Forms.Button showquerys;
        private System.Windows.Forms.TextBox textBox1;
    }
}