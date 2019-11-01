namespace login_of__student
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.manageStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.batchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newBatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayBatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.othersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uploadTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iOTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.buttonexit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.polymerphismToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageStudentToolStripMenuItem,
            this.batchToolStripMenuItem,
            this.othersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // manageStudentToolStripMenuItem
            // 
            this.manageStudentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newStudentToolStripMenuItem,
            this.displayStudentToolStripMenuItem});
            this.manageStudentToolStripMenuItem.Name = "manageStudentToolStripMenuItem";
            this.manageStudentToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.manageStudentToolStripMenuItem.Text = "Manage Student";
            // 
            // newStudentToolStripMenuItem
            // 
            this.newStudentToolStripMenuItem.Name = "newStudentToolStripMenuItem";
            this.newStudentToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.newStudentToolStripMenuItem.Text = "New Student";
            this.newStudentToolStripMenuItem.Click += new System.EventHandler(this.NewStudentToolStripMenuItem_Click);
            // 
            // displayStudentToolStripMenuItem
            // 
            this.displayStudentToolStripMenuItem.Name = "displayStudentToolStripMenuItem";
            this.displayStudentToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.displayStudentToolStripMenuItem.Text = "Display Student";
            this.displayStudentToolStripMenuItem.Click += new System.EventHandler(this.DisplayStudentToolStripMenuItem_Click);
            // 
            // batchToolStripMenuItem
            // 
            this.batchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newBatchToolStripMenuItem,
            this.displayBatchToolStripMenuItem});
            this.batchToolStripMenuItem.Name = "batchToolStripMenuItem";
            this.batchToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.batchToolStripMenuItem.Text = "Batch";
            // 
            // newBatchToolStripMenuItem
            // 
            this.newBatchToolStripMenuItem.Name = "newBatchToolStripMenuItem";
            this.newBatchToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.newBatchToolStripMenuItem.Text = "New Batch";
            this.newBatchToolStripMenuItem.Click += new System.EventHandler(this.NewBatchToolStripMenuItem_Click);
            // 
            // displayBatchToolStripMenuItem
            // 
            this.displayBatchToolStripMenuItem.Name = "displayBatchToolStripMenuItem";
            this.displayBatchToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.displayBatchToolStripMenuItem.Text = "Display Batch";
            this.displayBatchToolStripMenuItem.Click += new System.EventHandler(this.DisplayBatchToolStripMenuItem_Click);
            // 
            // othersToolStripMenuItem
            // 
            this.othersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileTestToolStripMenuItem,
            this.uploadTestToolStripMenuItem,
            this.iOTestToolStripMenuItem,
            this.polymerphismToolStripMenuItem});
            this.othersToolStripMenuItem.Name = "othersToolStripMenuItem";
            this.othersToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.othersToolStripMenuItem.Text = "Others";
            // 
            // fileTestToolStripMenuItem
            // 
            this.fileTestToolStripMenuItem.Name = "fileTestToolStripMenuItem";
            this.fileTestToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fileTestToolStripMenuItem.Text = "FileTest";
            this.fileTestToolStripMenuItem.Click += new System.EventHandler(this.FileTestToolStripMenuItem_Click);
            // 
            // uploadTestToolStripMenuItem
            // 
            this.uploadTestToolStripMenuItem.Name = "uploadTestToolStripMenuItem";
            this.uploadTestToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.uploadTestToolStripMenuItem.Text = "UploadTest";
            this.uploadTestToolStripMenuItem.Click += new System.EventHandler(this.UploadTestToolStripMenuItem_Click);
            // 
            // iOTestToolStripMenuItem
            // 
            this.iOTestToolStripMenuItem.Name = "iOTestToolStripMenuItem";
            this.iOTestToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.iOTestToolStripMenuItem.Text = "IOTest";
            this.iOTestToolStripMenuItem.Click += new System.EventHandler(this.IOTestToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // buttonexit
            // 
            this.buttonexit.Location = new System.Drawing.Point(725, 1);
            this.buttonexit.Name = "buttonexit";
            this.buttonexit.Size = new System.Drawing.Size(75, 23);
            this.buttonexit.TabIndex = 1;
            this.buttonexit.Text = "Exit";
            this.buttonexit.UseVisualStyleBackColor = true;
            this.buttonexit.Click += new System.EventHandler(this.Buttonexit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(310, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // polymerphismToolStripMenuItem
            // 
            this.polymerphismToolStripMenuItem.Name = "polymerphismToolStripMenuItem";
            this.polymerphismToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.polymerphismToolStripMenuItem.Text = "Polymerphism";
            this.polymerphismToolStripMenuItem.Click += new System.EventHandler(this.PolymerphismToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonexit);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem manageStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem batchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newBatchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayBatchToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button buttonexit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem othersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uploadTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iOTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem polymerphismToolStripMenuItem;
    }
}

