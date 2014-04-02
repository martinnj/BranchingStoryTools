namespace BranchingStoryReader
{
    partial class ReaderMainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loadNewXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startOverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.respawnImageWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeVariablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.delmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadNewXMLToolStripMenuItem,
            this.startOverToolStripMenuItem,
            this.respawnImageWindowToolStripMenuItem,
            this.changeVariablesToolStripMenuItem,
            this.delmeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(937, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loadNewXMLToolStripMenuItem
            // 
            this.loadNewXMLToolStripMenuItem.Name = "loadNewXMLToolStripMenuItem";
            this.loadNewXMLToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.loadNewXMLToolStripMenuItem.Text = "Load New XML";
            this.loadNewXMLToolStripMenuItem.Click += new System.EventHandler(this.loadNewXMLToolStripMenuItem_Click);
            // 
            // startOverToolStripMenuItem
            // 
            this.startOverToolStripMenuItem.Enabled = false;
            this.startOverToolStripMenuItem.Name = "startOverToolStripMenuItem";
            this.startOverToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.startOverToolStripMenuItem.Text = "Start Over";
            this.startOverToolStripMenuItem.Click += new System.EventHandler(this.startOverToolStripMenuItem_Click);
            // 
            // respawnImageWindowToolStripMenuItem
            // 
            this.respawnImageWindowToolStripMenuItem.Enabled = false;
            this.respawnImageWindowToolStripMenuItem.Name = "respawnImageWindowToolStripMenuItem";
            this.respawnImageWindowToolStripMenuItem.Size = new System.Drawing.Size(146, 20);
            this.respawnImageWindowToolStripMenuItem.Text = "Respawn ImageWindow";
            this.respawnImageWindowToolStripMenuItem.Click += new System.EventHandler(this.respawnImageWindowToolStripMenuItem_Click);
            // 
            // changeVariablesToolStripMenuItem
            // 
            this.changeVariablesToolStripMenuItem.Enabled = false;
            this.changeVariablesToolStripMenuItem.Name = "changeVariablesToolStripMenuItem";
            this.changeVariablesToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.changeVariablesToolStripMenuItem.Text = "Change Variables";
            this.changeVariablesToolStripMenuItem.Click += new System.EventHandler(this.changeVariablesToolStripMenuItem_Click);
            // 
            // delmeToolStripMenuItem
            // 
            this.delmeToolStripMenuItem.Name = "delmeToolStripMenuItem";
            this.delmeToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.richTextBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(937, 551);
            this.splitContainer1.SplitterDistance = 471;
            this.splitContainer1.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox1.Size = new System.Drawing.Size(937, 471);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(937, 76);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // ReaderMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 575);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ReaderMainForm";
            this.Text = "BranchStoryReader";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loadNewXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startOverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem respawnImageWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeVariablesToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ToolStripMenuItem delmeToolStripMenuItem;
    }
}

