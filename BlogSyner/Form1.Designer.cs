namespace BlogSyner
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.freeTabCtrl1 = new FreeTabCtrl.FreeTabCtrl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.titlebox = new System.Windows.Forms.TextBox();
            this.publishbtn = new MSButton.MSButton();
            this.newbtn = new MSButton.MSButton();
            this.openbtn = new MSButton.MSButton();
            this.draftbtn = new MSButton.MSButton();
            this.blogbtn = new MSButton.MSButton();
            this.titlelabel = new System.Windows.Forms.Label();
            this.changebtn = new MSButton.MSButton();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // freeTabCtrl1
            // 
            this.freeTabCtrl1.BackColor = System.Drawing.Color.Transparent;
            this.freeTabCtrl1.FocusedImage = ((System.Drawing.Image)(resources.GetObject("freeTabCtrl1.FocusedImage")));
            this.freeTabCtrl1.HoverImage = ((System.Drawing.Image)(resources.GetObject("freeTabCtrl1.HoverImage")));
            this.freeTabCtrl1.Location = new System.Drawing.Point(-2, 103);
            this.freeTabCtrl1.Name = "freeTabCtrl1";
            this.freeTabCtrl1.NormalImage = ((System.Drawing.Image)(resources.GetObject("freeTabCtrl1.NormalImage")));
            this.freeTabCtrl1.Size = new System.Drawing.Size(654, 487);
            this.freeTabCtrl1.TabBtnPadding = 10;
            this.freeTabCtrl1.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // titlebox
            // 
            this.titlebox.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.titlebox.Location = new System.Drawing.Point(41, 71);
            this.titlebox.Name = "titlebox";
            this.titlebox.Size = new System.Drawing.Size(611, 26);
            this.titlebox.TabIndex = 1;
            // 
            // publishbtn
            // 
            this.publishbtn.BackColor = System.Drawing.Color.Transparent;
            this.publishbtn.FlatAppearance.BorderSize = 0;
            this.publishbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.publishbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.publishbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.publishbtn.FocusedImage = ((System.Drawing.Image)(resources.GetObject("publishbtn.FocusedImage")));
            this.publishbtn.ForeColor = System.Drawing.Color.Transparent;
            this.publishbtn.HoverImage = ((System.Drawing.Image)(resources.GetObject("publishbtn.HoverImage")));
            this.publishbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.publishbtn.Location = new System.Drawing.Point(1, 42);
            this.publishbtn.Name = "publishbtn";
            this.publishbtn.NormalImage = ((System.Drawing.Image)(resources.GetObject("publishbtn.NormalImage")));
            this.publishbtn.Size = new System.Drawing.Size(75, 23);
            this.publishbtn.TabIndex = 2;
            this.publishbtn.Text = "发布";
            this.publishbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.publishbtn.UseVisualStyleBackColor = true;
            this.publishbtn.Click += new System.EventHandler(this.publishbtn_Click_1);
            // 
            // newbtn
            // 
            this.newbtn.BackColor = System.Drawing.Color.Transparent;
            this.newbtn.FlatAppearance.BorderSize = 0;
            this.newbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.newbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.newbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newbtn.FocusedImage = ((System.Drawing.Image)(resources.GetObject("newbtn.FocusedImage")));
            this.newbtn.ForeColor = System.Drawing.Color.Transparent;
            this.newbtn.HoverImage = ((System.Drawing.Image)(resources.GetObject("newbtn.HoverImage")));
            this.newbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.newbtn.Location = new System.Drawing.Point(82, 42);
            this.newbtn.Name = "newbtn";
            this.newbtn.NormalImage = null;
            this.newbtn.Size = new System.Drawing.Size(75, 23);
            this.newbtn.TabIndex = 4;
            this.newbtn.Text = "新建";
            this.newbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.newbtn.UseVisualStyleBackColor = true;
            this.newbtn.Click += new System.EventHandler(this.newbtn_Click);
            // 
            // openbtn
            // 
            this.openbtn.BackColor = System.Drawing.Color.Transparent;
            this.openbtn.FlatAppearance.BorderSize = 0;
            this.openbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.openbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.openbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openbtn.FocusedImage = null;
            this.openbtn.ForeColor = System.Drawing.Color.Transparent;
            this.openbtn.HoverImage = null;
            this.openbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.openbtn.Location = new System.Drawing.Point(163, 42);
            this.openbtn.Name = "openbtn";
            this.openbtn.NormalImage = null;
            this.openbtn.Size = new System.Drawing.Size(75, 23);
            this.openbtn.TabIndex = 5;
            this.openbtn.Text = "打开";
            this.openbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.openbtn.UseVisualStyleBackColor = true;
            this.openbtn.Click += new System.EventHandler(this.openbtn_Click);
            // 
            // draftbtn
            // 
            this.draftbtn.BackColor = System.Drawing.Color.Transparent;
            this.draftbtn.FlatAppearance.BorderSize = 0;
            this.draftbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.draftbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.draftbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.draftbtn.FocusedImage = null;
            this.draftbtn.ForeColor = System.Drawing.Color.Transparent;
            this.draftbtn.HoverImage = null;
            this.draftbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.draftbtn.Location = new System.Drawing.Point(244, 42);
            this.draftbtn.Name = "draftbtn";
            this.draftbtn.NormalImage = null;
            this.draftbtn.Size = new System.Drawing.Size(75, 23);
            this.draftbtn.TabIndex = 6;
            this.draftbtn.Text = "保存草稿";
            this.draftbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.draftbtn.UseVisualStyleBackColor = true;
            this.draftbtn.Click += new System.EventHandler(this.draftbtn_Click);
            // 
            // blogbtn
            // 
            this.blogbtn.BackColor = System.Drawing.Color.Transparent;
            this.blogbtn.FlatAppearance.BorderSize = 0;
            this.blogbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.blogbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.blogbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.blogbtn.FocusedImage = null;
            this.blogbtn.ForeColor = System.Drawing.Color.Transparent;
            this.blogbtn.HoverImage = null;
            this.blogbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.blogbtn.Location = new System.Drawing.Point(326, 42);
            this.blogbtn.Name = "blogbtn";
            this.blogbtn.NormalImage = null;
            this.blogbtn.Size = new System.Drawing.Size(75, 23);
            this.blogbtn.TabIndex = 7;
            this.blogbtn.Text = "博客设置";
            this.blogbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.blogbtn.UseVisualStyleBackColor = true;
            this.blogbtn.Click += new System.EventHandler(this.blogbtn_Click);
            // 
            // titlelabel
            // 
            this.titlelabel.AutoSize = true;
            this.titlelabel.BackColor = System.Drawing.Color.Transparent;
            this.titlelabel.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.titlelabel.Location = new System.Drawing.Point(21, 11);
            this.titlelabel.Name = "titlelabel";
            this.titlelabel.Size = new System.Drawing.Size(136, 19);
            this.titlelabel.TabIndex = 8;
            this.titlelabel.Text = "FreeNet的博客";
            // 
            // changebtn
            // 
            this.changebtn.BackColor = System.Drawing.Color.Transparent;
            this.changebtn.FlatAppearance.BorderSize = 0;
            this.changebtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.changebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.changebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changebtn.FocusedImage = null;
            this.changebtn.ForeColor = System.Drawing.Color.Transparent;
            this.changebtn.HoverImage = null;
            this.changebtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.changebtn.Location = new System.Drawing.Point(418, 42);
            this.changebtn.Name = "changebtn";
            this.changebtn.NormalImage = null;
            this.changebtn.Size = new System.Drawing.Size(75, 23);
            this.changebtn.TabIndex = 9;
            this.changebtn.Text = "切换账户";
            this.changebtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.changebtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(-2, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "标题";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(653, 639);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.changebtn);
            this.Controls.Add(this.titlelabel);
            this.Controls.Add(this.blogbtn);
            this.Controls.Add(this.draftbtn);
            this.Controls.Add(this.openbtn);
            this.Controls.Add(this.newbtn);
            this.Controls.Add(this.publishbtn);
            this.Controls.Add(this.titlebox);
            this.Controls.Add(this.freeTabCtrl1);
            this.Name = "Form1";
            this.Text = "FreeBlogger by FreeNet Inc.";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

      //  private RichTextBoxLinks.RichTextBoxEx richTextBox1 = new RichTextBoxLinks.RichTextBoxEx();
        private FreeTabCtrl.FreeTabCtrl freeTabCtrl1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox titlebox;
        private MSButton.MSButton publishbtn;
        private MSButton.MSButton newbtn;
        private MSButton.MSButton openbtn;
        private MSButton.MSButton draftbtn;
        private MSButton.MSButton blogbtn;
        private System.Windows.Forms.Label titlelabel;
        private MSButton.MSButton changebtn;
        private System.Windows.Forms.Label label2;
    }
}

