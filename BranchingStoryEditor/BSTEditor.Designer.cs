namespace BranchingStoryEditor
{
    partial class BSTEditor
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.nodebrowser = new System.Windows.Forms.TreeView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.imgtab = new System.Windows.Forms.TabPage();
            this.txttab = new System.Windows.Forms.TabPage();
            this.currenttxt = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.currenttextreset = new System.Windows.Forms.Button();
            this.currenttextapply = new System.Windows.Forms.Button();
            this.choicetab = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveXMLAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.gallerycontrol = new System.Windows.Forms.FlowLayoutPanel();
            this.imgdescription = new System.Windows.Forms.TextBox();
            this.currentpicturebox = new System.Windows.Forms.PictureBox();
            this.nodepage = new System.Windows.Forms.TabPage();
            this.idtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.imgtab.SuspendLayout();
            this.txttab.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentpicturebox)).BeginInit();
            this.nodepage.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.nodebrowser);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(1078, 508);
            this.splitContainer1.SplitterDistance = 207;
            this.splitContainer1.TabIndex = 0;
            // 
            // nodebrowser
            // 
            this.nodebrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nodebrowser.Location = new System.Drawing.Point(0, 0);
            this.nodebrowser.Name = "nodebrowser";
            this.nodebrowser.Size = new System.Drawing.Size(207, 508);
            this.nodebrowser.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.nodepage);
            this.tabControl1.Controls.Add(this.imgtab);
            this.tabControl1.Controls.Add(this.txttab);
            this.tabControl1.Controls.Add(this.choicetab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(867, 508);
            this.tabControl1.TabIndex = 0;
            // 
            // imgtab
            // 
            this.imgtab.Controls.Add(this.splitContainer2);
            this.imgtab.Controls.Add(this.panel2);
            this.imgtab.Location = new System.Drawing.Point(4, 22);
            this.imgtab.Name = "imgtab";
            this.imgtab.Padding = new System.Windows.Forms.Padding(3);
            this.imgtab.Size = new System.Drawing.Size(859, 482);
            this.imgtab.TabIndex = 0;
            this.imgtab.Text = "Images";
            this.imgtab.UseVisualStyleBackColor = true;
            // 
            // txttab
            // 
            this.txttab.Controls.Add(this.currenttxt);
            this.txttab.Controls.Add(this.panel1);
            this.txttab.Location = new System.Drawing.Point(4, 22);
            this.txttab.Name = "txttab";
            this.txttab.Padding = new System.Windows.Forms.Padding(3);
            this.txttab.Size = new System.Drawing.Size(859, 482);
            this.txttab.TabIndex = 1;
            this.txttab.Text = "Text";
            this.txttab.UseVisualStyleBackColor = true;
            // 
            // currenttxt
            // 
            this.currenttxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.currenttxt.Location = new System.Drawing.Point(3, 3);
            this.currenttxt.Name = "currenttxt";
            this.currenttxt.Size = new System.Drawing.Size(853, 445);
            this.currenttxt.TabIndex = 1;
            this.currenttxt.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.currenttextreset);
            this.panel1.Controls.Add(this.currenttextapply);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 448);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(853, 31);
            this.panel1.TabIndex = 0;
            // 
            // currenttextreset
            // 
            this.currenttextreset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.currenttextreset.Location = new System.Drawing.Point(692, 4);
            this.currenttextreset.Name = "currenttextreset";
            this.currenttextreset.Size = new System.Drawing.Size(75, 23);
            this.currenttextreset.TabIndex = 1;
            this.currenttextreset.Text = "Reset";
            this.currenttextreset.UseVisualStyleBackColor = true;
            // 
            // currenttextapply
            // 
            this.currenttextapply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.currenttextapply.Location = new System.Drawing.Point(773, 4);
            this.currenttextapply.Name = "currenttextapply";
            this.currenttextapply.Size = new System.Drawing.Size(75, 23);
            this.currenttextapply.TabIndex = 0;
            this.currenttextapply.Text = "Apply";
            this.currenttextapply.UseVisualStyleBackColor = true;
            // 
            // choicetab
            // 
            this.choicetab.Location = new System.Drawing.Point(4, 22);
            this.choicetab.Name = "choicetab";
            this.choicetab.Padding = new System.Windows.Forms.Padding(3);
            this.choicetab.Size = new System.Drawing.Size(859, 482);
            this.choicetab.TabIndex = 2;
            this.choicetab.Text = "Choices";
            this.choicetab.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1078, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.loadXMLToolStripMenuItem,
            this.saveXMLToolStripMenuItem,
            this.saveXMLAsToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // loadXMLToolStripMenuItem
            // 
            this.loadXMLToolStripMenuItem.Name = "loadXMLToolStripMenuItem";
            this.loadXMLToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.loadXMLToolStripMenuItem.Text = "Load XML";
            // 
            // saveXMLToolStripMenuItem
            // 
            this.saveXMLToolStripMenuItem.Name = "saveXMLToolStripMenuItem";
            this.saveXMLToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.saveXMLToolStripMenuItem.Text = "Save XML";
            // 
            // saveXMLAsToolStripMenuItem
            // 
            this.saveXMLAsToolStripMenuItem.Name = "saveXMLAsToolStripMenuItem";
            this.saveXMLAsToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.saveXMLAsToolStripMenuItem.Text = "Save XML as";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 451);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(853, 28);
            this.panel2.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.gallerycontrol);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.currentpicturebox);
            this.splitContainer2.Panel2.Controls.Add(this.imgdescription);
            this.splitContainer2.Size = new System.Drawing.Size(853, 448);
            this.splitContainer2.SplitterDistance = 167;
            this.splitContainer2.TabIndex = 1;
            // 
            // gallerycontrol
            // 
            this.gallerycontrol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gallerycontrol.Location = new System.Drawing.Point(0, 0);
            this.gallerycontrol.Name = "gallerycontrol";
            this.gallerycontrol.Size = new System.Drawing.Size(167, 448);
            this.gallerycontrol.TabIndex = 0;
            // 
            // imgdescription
            // 
            this.imgdescription.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.imgdescription.Location = new System.Drawing.Point(0, 413);
            this.imgdescription.Multiline = true;
            this.imgdescription.Name = "imgdescription";
            this.imgdescription.Size = new System.Drawing.Size(682, 35);
            this.imgdescription.TabIndex = 0;
            // 
            // currentpicturebox
            // 
            this.currentpicturebox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.currentpicturebox.Location = new System.Drawing.Point(0, 0);
            this.currentpicturebox.Name = "currentpicturebox";
            this.currentpicturebox.Size = new System.Drawing.Size(682, 413);
            this.currentpicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.currentpicturebox.TabIndex = 1;
            this.currentpicturebox.TabStop = false;
            // 
            // nodepage
            // 
            this.nodepage.Controls.Add(this.label1);
            this.nodepage.Controls.Add(this.idtxt);
            this.nodepage.Location = new System.Drawing.Point(4, 22);
            this.nodepage.Name = "nodepage";
            this.nodepage.Padding = new System.Windows.Forms.Padding(3);
            this.nodepage.Size = new System.Drawing.Size(859, 482);
            this.nodepage.TabIndex = 3;
            this.nodepage.Text = "Branch Information";
            this.nodepage.UseVisualStyleBackColor = true;
            // 
            // idtxt
            // 
            this.idtxt.Location = new System.Drawing.Point(33, 6);
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(307, 20);
            this.idtxt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID:";
            // 
            // BSTEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 532);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BSTEditor";
            this.Text = "BST Editor";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.imgtab.ResumeLayout(false);
            this.txttab.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.currentpicturebox)).EndInit();
            this.nodepage.ResumeLayout(false);
            this.nodepage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView nodebrowser;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage imgtab;
        private System.Windows.Forms.TabPage txttab;
        private System.Windows.Forms.TabPage choicetab;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveXMLAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.RichTextBox currenttxt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button currenttextreset;
        private System.Windows.Forms.Button currenttextapply;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.FlowLayoutPanel gallerycontrol;
        private System.Windows.Forms.TextBox imgdescription;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox currentpicturebox;
        private System.Windows.Forms.TabPage nodepage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idtxt;
    }
}

