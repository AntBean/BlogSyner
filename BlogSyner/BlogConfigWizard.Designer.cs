namespace BlogSyner
{
    partial class BlogConfigWizard
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
            this.freeWizard1 = new FreeWizard.FreeWizard();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.remembered = new System.Windows.Forms.CheckBox();
            this.passwdbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.usernamebox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.urlbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.postbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.blogbox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.nextbtn = new System.Windows.Forms.Button();
            this.prevbtn = new System.Windows.Forms.Button();
            this.freeWizard1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // freeWizard1
            // 
            this.freeWizard1.Controls.Add(this.tabPage1);
            this.freeWizard1.Controls.Add(this.tabPage2);
            this.freeWizard1.Dock = System.Windows.Forms.DockStyle.Top;
            this.freeWizard1.Location = new System.Drawing.Point(0, 0);
            this.freeWizard1.Name = "freeWizard1";
            this.freeWizard1.SelectedIndex = 0;
            this.freeWizard1.Size = new System.Drawing.Size(462, 264);
            this.freeWizard1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.remembered);
            this.tabPage1.Controls.Add(this.passwdbox);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.usernamebox);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.urlbox);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(454, 239);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.postbox);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.blogbox);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Location = new System.Drawing.Point(4, 21);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(454, 239);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // remembered
            // 
            this.remembered.AutoSize = true;
            this.remembered.Location = new System.Drawing.Point(22, 204);
            this.remembered.Name = "remembered";
            this.remembered.Size = new System.Drawing.Size(96, 16);
            this.remembered.TabIndex = 15;
            this.remembered.Text = "记住我的密码";
            this.remembered.UseVisualStyleBackColor = true;
            // 
            // passwdbox
            // 
            this.passwdbox.Location = new System.Drawing.Point(22, 173);
            this.passwdbox.Name = "passwdbox";
            this.passwdbox.PasswordChar = '*';
            this.passwdbox.Size = new System.Drawing.Size(226, 21);
            this.passwdbox.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "密码:";
            // 
            // usernamebox
            // 
            this.usernamebox.Location = new System.Drawing.Point(22, 122);
            this.usernamebox.Name = "usernamebox";
            this.usernamebox.Size = new System.Drawing.Size(226, 21);
            this.usernamebox.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "用户名:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "博客网址:";
            // 
            // urlbox
            // 
            this.urlbox.Location = new System.Drawing.Point(22, 71);
            this.urlbox.Name = "urlbox";
            this.urlbox.Size = new System.Drawing.Size(403, 21);
            this.urlbox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(19, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "添加博客账户";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox2.Location = new System.Drawing.Point(24, 181);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(362, 18);
            this.textBox2.TabIndex = 11;
            this.textBox2.Text = "可以不填,软件会根据您的用户名和博客类型，自动生成该网址";
            // 
            // postbox
            // 
            this.postbox.Location = new System.Drawing.Point(24, 154);
            this.postbox.Name = "postbox";
            this.postbox.Size = new System.Drawing.Size(225, 21);
            this.postbox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "博客远程post网址:";
            // 
            // blogbox
            // 
            this.blogbox.FormattingEnabled = true;
            this.blogbox.Location = new System.Drawing.Point(23, 92);
            this.blogbox.Name = "blogbox";
            this.blogbox.Size = new System.Drawing.Size(226, 20);
            this.blogbox.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 12);
            this.label6.TabIndex = 7;
            this.label6.Text = "当前使用的博客:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(21, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "选择博客类型";
            // 
            // cancelbtn
            // 
            this.cancelbtn.Location = new System.Drawing.Point(384, 272);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(75, 23);
            this.cancelbtn.TabIndex = 6;
            this.cancelbtn.Text = "取消";
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // nextbtn
            // 
            this.nextbtn.Location = new System.Drawing.Point(284, 272);
            this.nextbtn.Name = "nextbtn";
            this.nextbtn.Size = new System.Drawing.Size(75, 23);
            this.nextbtn.TabIndex = 5;
            this.nextbtn.Text = "下一步";
            this.nextbtn.UseVisualStyleBackColor = true;
            this.nextbtn.Click += new System.EventHandler(this.nextbtn_Click);
            // 
            // prevbtn
            // 
            this.prevbtn.Location = new System.Drawing.Point(184, 272);
            this.prevbtn.Name = "prevbtn";
            this.prevbtn.Size = new System.Drawing.Size(75, 23);
            this.prevbtn.TabIndex = 4;
            this.prevbtn.Text = "上一步";
            this.prevbtn.UseVisualStyleBackColor = true;
            this.prevbtn.Click += new System.EventHandler(this.prevbtn_Click);
            // 
            // BlogConfigWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 307);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.nextbtn);
            this.Controls.Add(this.prevbtn);
            this.Controls.Add(this.freeWizard1);
            this.Name = "BlogConfigWizard";
            this.Text = "BlogConfigWizard";
            this.freeWizard1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FreeWizard.FreeWizard freeWizard1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox remembered;
        private System.Windows.Forms.TextBox passwdbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox usernamebox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox urlbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox postbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox blogbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.Button nextbtn;
        private System.Windows.Forms.Button prevbtn;
    }
}