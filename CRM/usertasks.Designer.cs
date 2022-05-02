namespace CRM
{
    partial class usertasks
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
            this.editbutton = new System.Windows.Forms.Button();
            this.checkbutton = new System.Windows.Forms.Button();
            this.delbutton = new System.Windows.Forms.Button();
            this.updateall = new System.Windows.Forms.Button();
            this.updatecompleted = new System.Windows.Forms.Button();
            this.updatenotcompleted = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(85, 44);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(451, 292);
            this.listBox1.TabIndex = 0;
            // 
            // addbutton
            // 
            this.addbutton.Location = new System.Drawing.Point(85, 362);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(97, 43);
            this.addbutton.TabIndex = 1;
            this.addbutton.Text = "Добавить";
            this.addbutton.UseVisualStyleBackColor = true;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // editbutton
            // 
            this.editbutton.Location = new System.Drawing.Point(215, 362);
            this.editbutton.Name = "editbutton";
            this.editbutton.Size = new System.Drawing.Size(93, 43);
            this.editbutton.TabIndex = 2;
            this.editbutton.Text = "Изменить";
            this.editbutton.UseVisualStyleBackColor = true;
            this.editbutton.Click += new System.EventHandler(this.editbutton_Click);
            // 
            // checkbutton
            // 
            this.checkbutton.Location = new System.Drawing.Point(330, 362);
            this.checkbutton.Name = "checkbutton";
            this.checkbutton.Size = new System.Drawing.Size(99, 43);
            this.checkbutton.TabIndex = 3;
            this.checkbutton.Text = "Отметить";
            this.checkbutton.UseVisualStyleBackColor = true;
            // 
            // delbutton
            // 
            this.delbutton.Location = new System.Drawing.Point(449, 362);
            this.delbutton.Name = "delbutton";
            this.delbutton.Size = new System.Drawing.Size(87, 43);
            this.delbutton.TabIndex = 4;
            this.delbutton.Text = "Удалить";
            this.delbutton.UseVisualStyleBackColor = true;
            // 
            // updateall
            // 
            this.updateall.Location = new System.Drawing.Point(563, 44);
            this.updateall.Name = "updateall";
            this.updateall.Size = new System.Drawing.Size(128, 72);
            this.updateall.TabIndex = 5;
            this.updateall.Text = "Отобразить всё";
            this.updateall.UseVisualStyleBackColor = true;
            this.updateall.Click += new System.EventHandler(this.updateall_Click);
            // 
            // updatecompleted
            // 
            this.updatecompleted.Location = new System.Drawing.Point(563, 147);
            this.updatecompleted.Name = "updatecompleted";
            this.updatecompleted.Size = new System.Drawing.Size(128, 75);
            this.updatecompleted.TabIndex = 6;
            this.updatecompleted.Text = "Отобразить выполненные";
            this.updatecompleted.UseVisualStyleBackColor = true;
            this.updatecompleted.Click += new System.EventHandler(this.updatecompleted_Click);
            // 
            // updatenotcompleted
            // 
            this.updatenotcompleted.Location = new System.Drawing.Point(563, 253);
            this.updatenotcompleted.Name = "updatenotcompleted";
            this.updatenotcompleted.Size = new System.Drawing.Size(128, 83);
            this.updatenotcompleted.TabIndex = 7;
            this.updatenotcompleted.Text = "Отобразить невыполненные";
            this.updatenotcompleted.UseVisualStyleBackColor = true;
            this.updatenotcompleted.Click += new System.EventHandler(this.updatenotcompleted_Click);
            // 
            // usertasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 441);
            this.Controls.Add(this.updatenotcompleted);
            this.Controls.Add(this.updatecompleted);
            this.Controls.Add(this.updateall);
            this.Controls.Add(this.delbutton);
            this.Controls.Add(this.checkbutton);
            this.Controls.Add(this.editbutton);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.listBox1);
            this.Name = "usertasks";
            this.Text = "usertasks";
            this.Load += new System.EventHandler(this.usertasks_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.Button editbutton;
        private System.Windows.Forms.Button checkbutton;
        private System.Windows.Forms.Button delbutton;
        private System.Windows.Forms.Button updateall;
        private System.Windows.Forms.Button updatecompleted;
        private System.Windows.Forms.Button updatenotcompleted;
    }
}