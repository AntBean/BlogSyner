namespace BlogSyner
{
    partial class UpdateAccoutDlg
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.nextbtn = new System.Windows.Forms.Button();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.urlbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.usernamebox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.passwdbox = new System.Windows.Forms.TextBox();
            this.remembered = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.remembered);
            this.panel1.Controls.Add(this.passwdbox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.usernamebox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.urlbox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 260);
            this.panel1.TabIndex = 0;
            // 
            // nextbtn
            // 
            this.nextbtn.Location = new System.Drawing.Point(183, 275);
            this.nextbtn.Name = "nextbtn";
            this.nextbtn.Size = new System.Drawing.Size(83, 26);
            this.nextbtn.TabIndex = 2;
            this.nextbtn.Text = "下一步";
            this.nextbtn.UseVisualStyleBackColor = true;
            this.nextbtn.Click += new System.EventHandler(this.nextbtn_Click);
            // 
            // cancelbtn
            // 
            this.cancelbtn.Location = new System.Drawing.Point(304, 275);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(83, 26);
            this.cancelbtn.TabIndex = 3;
            this.cancelbtn.Text = "取消";
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "添加博客账户";
            // 
            // urlbox
            // 
            this.urlbox.Location = new System.Drawing.Point(15, 66);
            this.urlbox.Name = "urlbox";
            this.urlbox.Size = new System.Drawing.Size(403, 21);
            this.urlbox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "博客网址:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "用户名:";
            // 
            // usernamebox
            // 
            this.usernamebox.Location = new System.Drawing.Point(15, 117);
            this.usernamebox.Name = "usernamebox";
            this.usernamebox.Size = new System.Drawing.Size(226, 21);
            this.usernamebox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "密码:";
            // 
            // passwdbox
            // 
            this.passwdbox.Location = new System.Drawing.Point(15, 168);
            this.passwdbox.Name = "passwdbox";
            this.passwdbox.Size = new System.Drawing.Size(226, 21);
            this.passwdbox.TabIndex = 6;
            // 
            // remembered
            // 
            this.remembered.AutoSize = true;
            this.remembered.Location = new System.Drawing.Point(15, 199);
            this.remembered.Name = "remembered";
            this.remembered.Size = new System.Drawing.Size(96, 16);
            this.remembered.TabIndex = 7;
            this.remembered.Text = "记住我的密码";
            this.remembered.UseVisualStyleBackColor = true;
            // 
            // UpdateAccoutDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 313);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.nextbtn);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateAccoutDlg";
            this.Text = "更新账户配置";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button nextbtn;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox urlbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passwdbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox usernamebox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox remembered;
    }
}