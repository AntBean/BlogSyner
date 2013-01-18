namespace BlogSyner
{
    partial class OpenBlogDlg
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("草稿", 0);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("最近发表", 1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpenBlogDlg));
            this.catagorylist = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.filterbox = new System.Windows.Forms.TextBox();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.freeWizard1 = new FreeWizard.FreeWizard();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.contentlist = new System.Windows.Forms.ListView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.okbtn = new System.Windows.Forms.Button();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.freeWizard1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // catagorylist
            // 
            this.catagorylist.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.catagorylist.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.catagorylist.AutoArrange = false;
            this.catagorylist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            listViewItem1.UseItemStyleForSubItems = false;
            this.catagorylist.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.catagorylist.LargeImageList = this.imageList1;
            this.catagorylist.Location = new System.Drawing.Point(28, 38);
            this.catagorylist.Name = "catagorylist";
            this.catagorylist.Size = new System.Drawing.Size(208, 345);
            this.catagorylist.TabIndex = 0;
            this.catagorylist.UseCompatibleStateImageBehavior = false;
            this.catagorylist.SelectedIndexChanged += new System.EventHandler(this.catagorylist_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 0;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "draft.bmp");
            this.imageList1.Images.SetKeyName(1, "recently.bmp");
            this.imageList1.Images.SetKeyName(2, "blog.bmp");
            // 
            // filterbox
            // 
            this.filterbox.Location = new System.Drawing.Point(308, 38);
            this.filterbox.Name = "filterbox";
            this.filterbox.Size = new System.Drawing.Size(327, 21);
            this.filterbox.TabIndex = 2;
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "mini.bmp");
            // 
            // freeWizard1
            // 
            this.freeWizard1.Controls.Add(this.tabPage1);
            this.freeWizard1.Controls.Add(this.tabPage2);
            this.freeWizard1.Location = new System.Drawing.Point(275, 75);
            this.freeWizard1.Name = "freeWizard1";
            this.freeWizard1.SelectedIndex = 0;
            this.freeWizard1.Size = new System.Drawing.Size(364, 308);
            this.freeWizard1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.contentlist);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(356, 283);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // contentlist
            // 
            this.contentlist.Dock = System.Windows.Forms.DockStyle.Top;
            this.contentlist.Location = new System.Drawing.Point(3, 3);
            this.contentlist.Name = "contentlist";
            this.contentlist.Size = new System.Drawing.Size(350, 320);
            this.contentlist.SmallImageList = this.imageList2;
            this.contentlist.TabIndex = 2;
            this.contentlist.UseCompatibleStateImageBehavior = false;
            this.contentlist.View = System.Windows.Forms.View.List;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 21);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(356, 283);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(-4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(364, 310);
            this.label2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(273, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "搜索";
            // 
            // okbtn
            // 
            this.okbtn.Location = new System.Drawing.Point(443, 389);
            this.okbtn.Name = "okbtn";
            this.okbtn.Size = new System.Drawing.Size(75, 23);
            this.okbtn.TabIndex = 5;
            this.okbtn.Text = "确定";
            this.okbtn.UseVisualStyleBackColor = true;
            this.okbtn.Click += new System.EventHandler(this.okbtn_Click);
            // 
            // cancelbtn
            // 
            this.cancelbtn.Location = new System.Drawing.Point(560, 389);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(75, 23);
            this.cancelbtn.TabIndex = 6;
            this.cancelbtn.Text = "取消";
            this.cancelbtn.UseVisualStyleBackColor = true;
            // 
            // OpenBlogDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 415);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.okbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.freeWizard1);
            this.Controls.Add(this.filterbox);
            this.Controls.Add(this.catagorylist);
            this.Name = "OpenBlogDlg";
            this.Text = "OpenBlogDlg";
            this.freeWizard1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView catagorylist;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox filterbox;
        private System.Windows.Forms.ImageList imageList2;
        private FreeWizard.FreeWizard freeWizard1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListView contentlist;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button okbtn;
        private System.Windows.Forms.Button cancelbtn;
    }
}