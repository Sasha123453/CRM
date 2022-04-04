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
            this.buttonshowall = new System.Windows.Forms.Button();
            this.buttonnotcomplete = new System.Windows.Forms.Button();
            this.buttoncomplete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userlistbutton
            // 
            this.userlistbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.1F);
            this.userlistbutton.Location = new System.Drawing.Point(22, 42);
            this.userlistbutton.Name = "userlistbutton";
            this.userlistbutton.Size = new System.Drawing.Size(158, 56);
            this.userlistbutton.TabIndex = 0;
            this.userlistbutton.Text = "Список пользователей";
            this.userlistbutton.UseVisualStyleBackColor = true;
            this.userlistbutton.Click += new System.EventHandler(this.userlistbutton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(199, 81);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(414, 212);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // editbutton
            // 
            this.editbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.1F);
            this.editbutton.Location = new System.Drawing.Point(199, 341);
            this.editbutton.Name = "editbutton";
            this.editbutton.Size = new System.Drawing.Size(108, 41);
            this.editbutton.TabIndex = 2;
            this.editbutton.Text = "Изменить";
            this.editbutton.UseVisualStyleBackColor = true;
            this.editbutton.Click += new System.EventHandler(this.editbutton_Click);
            // 
            // addbutton
            // 
            this.addbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.1F);
            this.addbutton.Location = new System.Drawing.Point(352, 343);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(117, 39);
            this.addbutton.TabIndex = 3;
            this.addbutton.Text = "Добавить";
            this.addbutton.UseVisualStyleBackColor = true;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // deletebutton
            // 
            this.deletebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.1F);
            this.deletebutton.Location = new System.Drawing.Point(503, 340);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(110, 40);
            this.deletebutton.TabIndex = 4;
            this.deletebutton.Text = "Отметить";
            this.deletebutton.UseVisualStyleBackColor = true;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // buttonshowall
            // 
            this.buttonshowall.Location = new System.Drawing.Point(647, 245);
            this.buttonshowall.Name = "buttonshowall";
            this.buttonshowall.Size = new System.Drawing.Size(122, 48);
            this.buttonshowall.TabIndex = 5;
            this.buttonshowall.Text = "Отобразить всё";
            this.buttonshowall.UseVisualStyleBackColor = true;
            this.buttonshowall.Click += new System.EventHandler(this.buttonshowall_Click);
            // 
            // buttonnotcomplete
            // 
            this.buttonnotcomplete.Location = new System.Drawing.Point(647, 168);
            this.buttonnotcomplete.Name = "buttonnotcomplete";
            this.buttonnotcomplete.Size = new System.Drawing.Size(122, 52);
            this.buttonnotcomplete.TabIndex = 6;
            this.buttonnotcomplete.Text = "Отобразить невыполненные";
            this.buttonnotcomplete.UseVisualStyleBackColor = true;
            this.buttonnotcomplete.Click += new System.EventHandler(this.buttonnotcomplete_Click);
            // 
            // buttoncomplete
            // 
            this.buttoncomplete.Location = new System.Drawing.Point(647, 81);
            this.buttoncomplete.Name = "buttoncomplete";
            this.buttoncomplete.Size = new System.Drawing.Size(122, 57);
            this.buttoncomplete.TabIndex = 7;
            this.buttoncomplete.Text = "Отобразить выполненные";
            this.buttoncomplete.UseVisualStyleBackColor = true;
            this.buttoncomplete.Click += new System.EventHandler(this.buttoncomplete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.1F);
            this.label1.Location = new System.Drawing.Point(609, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.1F);
            this.button1.Location = new System.Drawing.Point(647, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 40);
            this.button1.TabIndex = 9;
            this.button1.Text = "Удалить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // adminform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttoncomplete);
            this.Controls.Add(this.buttonnotcomplete);
            this.Controls.Add(this.buttonshowall);
            this.Controls.Add(this.deletebutton);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.editbutton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.userlistbutton);
            this.Name = "adminform";
            this.Text = "adminform";
            this.Load += new System.EventHandler(this.adminform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button userlistbutton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button editbutton;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.Button buttonshowall;
        private System.Windows.Forms.Button buttonnotcomplete;
        private System.Windows.Forms.Button buttoncomplete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}