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
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.exitbutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.addfriends = new System.Windows.Forms.Button();
            this.taskcontrol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(179, 78);
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
            this.solutionbutton.Location = new System.Drawing.Point(179, 491);
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
            this.updatebutton.Location = new System.Drawing.Point(389, 491);
            this.updatebutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updatebutton.Name = "updatebutton";
            this.updatebutton.Size = new System.Drawing.Size(139, 58);
            this.updatebutton.TabIndex = 2;
            this.updatebutton.Text = "Обновить";
            this.updatebutton.UseVisualStyleBackColor = true;
            this.updatebutton.Click += new System.EventHandler(this.updatebutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.1F);
            this.label1.Location = new System.Drawing.Point(605, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(179, 345);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(348, 117);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // exitbutton
            // 
            this.exitbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.exitbutton.Location = new System.Drawing.Point(31, 78);
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
            this.button1.Location = new System.Drawing.Point(564, 78);
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
            this.addfriends.Location = new System.Drawing.Point(564, 179);
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
            this.taskcontrol.Location = new System.Drawing.Point(564, 279);
            this.taskcontrol.Margin = new System.Windows.Forms.Padding(4);
            this.taskcontrol.Name = "taskcontrol";
            this.taskcontrol.Size = new System.Drawing.Size(156, 73);
            this.taskcontrol.TabIndex = 8;
            this.taskcontrol.Text = "Управление задачами";
            this.taskcontrol.UseVisualStyleBackColor = true;
            this.taskcontrol.Click += new System.EventHandler(this.taskcontrol_Click);
            // 
            // userform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 625);
            this.Controls.Add(this.taskcontrol);
            this.Controls.Add(this.addfriends);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.updatebutton);
            this.Controls.Add(this.solutionbutton);
            this.Controls.Add(this.listBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "userform";
            this.Text = "userform";
            this.Load += new System.EventHandler(this.userform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button solutionbutton;
        private System.Windows.Forms.Button updatebutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button addfriends;
        private System.Windows.Forms.Button taskcontrol;
    }
}