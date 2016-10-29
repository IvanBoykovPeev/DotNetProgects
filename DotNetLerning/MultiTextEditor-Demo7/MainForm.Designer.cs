namespace MultiTextEditor_Demo7
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MenuMainForm = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolBarMainForm = new System.Windows.Forms.ToolStrip();
            this.ToolStripButtonNew = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButtonOpen = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.ImageListToolBar = new System.Windows.Forms.ImageList(this.components);
            this.StatusBarMainForm = new System.Windows.Forms.StatusStrip();
            this.StatusBarInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelLine = new System.Windows.Forms.ToolStripStatusLabel();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.MenuMainForm.SuspendLayout();
            this.ToolBarMainForm.SuspendLayout();
            this.StatusBarMainForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuMainForm
            // 
            this.MenuMainForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.windowToolStripMenuItem});
            this.MenuMainForm.Location = new System.Drawing.Point(0, 0);
            this.MenuMainForm.Name = "MenuMainForm";
            this.MenuMainForm.Size = new System.Drawing.Size(650, 24);
            this.MenuMainForm.TabIndex = 0;
            this.MenuMainForm.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemFileNew,
            this.MenuItemFileOpen,
            this.MenuItemFileSave,
            this.exitToolStripMenuItem,
            this.MenuItemFileExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // MenuItemFileNew
            // 
            this.MenuItemFileNew.Name = "MenuItemFileNew";
            this.MenuItemFileNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.MenuItemFileNew.Size = new System.Drawing.Size(146, 22);
            this.MenuItemFileNew.Text = "New";
            this.MenuItemFileNew.Click += new System.EventHandler(this.MenuItemFileNew_Click);
            // 
            // MenuItemFileOpen
            // 
            this.MenuItemFileOpen.Name = "MenuItemFileOpen";
            this.MenuItemFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.MenuItemFileOpen.Size = new System.Drawing.Size(146, 22);
            this.MenuItemFileOpen.Text = "Open";
            this.MenuItemFileOpen.Click += new System.EventHandler(this.MenuItemFileOpen_Click);
            // 
            // MenuItemFileSave
            // 
            this.MenuItemFileSave.Name = "MenuItemFileSave";
            this.MenuItemFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.MenuItemFileSave.Size = new System.Drawing.Size(146, 22);
            this.MenuItemFileSave.Text = "Save";
            this.MenuItemFileSave.Click += new System.EventHandler(this.MenuItemFileSave_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(143, 6);
            // 
            // MenuItemFileExit
            // 
            this.MenuItemFileExit.Name = "MenuItemFileExit";
            this.MenuItemFileExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.MenuItemFileExit.Size = new System.Drawing.Size(146, 22);
            this.MenuItemFileExit.Text = "Exit";
            this.MenuItemFileExit.Click += new System.EventHandler(this.MenuItemFileExit_Click);
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.windowToolStripMenuItem.Text = "Window";
            // 
            // ToolBarMainForm
            // 
            this.ToolBarMainForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripButtonNew,
            this.ToolStripButtonOpen,
            this.ToolStripButtonSave});
            this.ToolBarMainForm.Location = new System.Drawing.Point(0, 24);
            this.ToolBarMainForm.Name = "ToolBarMainForm";
            this.ToolBarMainForm.Size = new System.Drawing.Size(650, 25);
            this.ToolBarMainForm.TabIndex = 1;
            this.ToolBarMainForm.Text = "toolStrip1";
            // 
            // ToolStripButtonNew
            // 
            this.ToolStripButtonNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButtonNew.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButtonNew.Image")));
            this.ToolStripButtonNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButtonNew.Name = "ToolStripButtonNew";
            this.ToolStripButtonNew.Size = new System.Drawing.Size(23, 22);
            this.ToolStripButtonNew.Text = "New File";
            this.ToolStripButtonNew.Click += new System.EventHandler(this.ToolStripButtonNew_Click);
            // 
            // ToolStripButtonOpen
            // 
            this.ToolStripButtonOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButtonOpen.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButtonOpen.Image")));
            this.ToolStripButtonOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButtonOpen.Name = "ToolStripButtonOpen";
            this.ToolStripButtonOpen.Size = new System.Drawing.Size(23, 22);
            this.ToolStripButtonOpen.Text = "Open File";
            this.ToolStripButtonOpen.Click += new System.EventHandler(this.ToolStripButtonOpen_Click);
            // 
            // ToolStripButtonSave
            // 
            this.ToolStripButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButtonSave.Image")));
            this.ToolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButtonSave.Name = "ToolStripButtonSave";
            this.ToolStripButtonSave.Size = new System.Drawing.Size(23, 22);
            this.ToolStripButtonSave.Text = "Save File";
            this.ToolStripButtonSave.Click += new System.EventHandler(this.ToolStripButtonSave_Click);
            // 
            // ImageListToolBar
            // 
            this.ImageListToolBar.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageListToolBar.ImageStream")));
            this.ImageListToolBar.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageListToolBar.Images.SetKeyName(0, "ToolBarButtonNew.png");
            this.ImageListToolBar.Images.SetKeyName(1, "ToolBarButtonOpen.png");
            this.ImageListToolBar.Images.SetKeyName(2, "ToolBarButtonSave.png");
            // 
            // StatusBarMainForm
            // 
            this.StatusBarMainForm.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
            this.StatusBarMainForm.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.StatusBarMainForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusBarInfo,
            this.toolStripStatusLabelInfo,
            this.toolStripStatusLabelLine});
            this.StatusBarMainForm.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.StatusBarMainForm.Location = new System.Drawing.Point(0, 449);
            this.StatusBarMainForm.Name = "StatusBarMainForm";
            this.StatusBarMainForm.ShowItemToolTips = true;
            this.StatusBarMainForm.Size = new System.Drawing.Size(650, 22);
            this.StatusBarMainForm.TabIndex = 2;
            this.StatusBarMainForm.Text = "statusStrip1";
            // 
            // StatusBarInfo
            // 
            this.StatusBarInfo.AutoSize = false;
            this.StatusBarInfo.BackColor = System.Drawing.Color.Ivory;
            this.StatusBarInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.StatusBarInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StatusBarInfo.Name = "StatusBarInfo";
            this.StatusBarInfo.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabelInfo
            // 
            this.toolStripStatusLabelInfo.Name = "toolStripStatusLabelInfo";
            this.toolStripStatusLabelInfo.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabelInfo.Text = "Ready";
            // 
            // toolStripStatusLabelLine
            // 
            this.toolStripStatusLabelLine.Name = "toolStripStatusLabelLine";
            this.toolStripStatusLabelLine.Size = new System.Drawing.Size(29, 17);
            this.toolStripStatusLabelLine.Text = "Line";
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "openFileDialog1";
            this.OpenFileDialog.Filter = "\"Text files (*.txt)|*.txt";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 471);
            this.Controls.Add(this.StatusBarMainForm);
            this.Controls.Add(this.ToolBarMainForm);
            this.Controls.Add(this.MenuMainForm);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MenuMainForm;
            this.Name = "MainForm";
            this.Text = "Text Editor Demo";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MenuMainForm.ResumeLayout(false);
            this.MenuMainForm.PerformLayout();
            this.ToolBarMainForm.ResumeLayout(false);
            this.ToolBarMainForm.PerformLayout();
            this.StatusBarMainForm.ResumeLayout(false);
            this.StatusBarMainForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuMainForm;
        private System.Windows.Forms.ToolStrip ToolBarMainForm;
        private System.Windows.Forms.ImageList ImageListToolBar;
        private System.Windows.Forms.StatusStrip StatusBarMainForm;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton ToolStripButtonNew;
        private System.Windows.Forms.ToolStripButton ToolStripButtonOpen;
        private System.Windows.Forms.ToolStripButton ToolStripButtonSave;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFileNew;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFileOpen;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFileSave;
        private System.Windows.Forms.ToolStripSeparator exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFileExit;
        private System.Windows.Forms.ToolStripStatusLabel StatusBarInfo;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelInfo;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelLine;
    }
}

