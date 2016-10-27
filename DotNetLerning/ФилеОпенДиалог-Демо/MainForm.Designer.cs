namespace ФилеОпенДиалог_Демо
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
            this.textBox = new System.Windows.Forms.TextBox();
            this.PanelBottom = new System.Windows.Forms.Panel();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.ButtonLoadFile = new System.Windows.Forms.Button();
            this.PanelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox.Location = new System.Drawing.Point(0, 0);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox.Size = new System.Drawing.Size(284, 261);
            this.textBox.TabIndex = 0;
            // 
            // PanelBottom
            // 
            this.PanelBottom.Controls.Add(this.ButtonLoadFile);
            this.PanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelBottom.Location = new System.Drawing.Point(0, 214);
            this.PanelBottom.Name = "PanelBottom";
            this.PanelBottom.Size = new System.Drawing.Size(284, 47);
            this.PanelBottom.TabIndex = 1;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "\"Text files (*.txt)|*.txt|Log files (*.log)|*.log\"";
            this.openFileDialog.Title = "\"Coose text file\"";
            // 
            // ButtonLoadFile
            // 
            this.ButtonLoadFile.Location = new System.Drawing.Point(4, 4);
            this.ButtonLoadFile.Name = "ButtonLoadFile";
            this.ButtonLoadFile.Size = new System.Drawing.Size(75, 23);
            this.ButtonLoadFile.TabIndex = 0;
            this.ButtonLoadFile.Text = "Load File";
            this.ButtonLoadFile.UseVisualStyleBackColor = true;
            this.ButtonLoadFile.Click += new System.EventHandler(this.ButtonLoadFile_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.PanelBottom);
            this.Controls.Add(this.textBox);
            this.Name = "MainForm";
            this.Text = "FileOpenDialog-Demo";
            this.PanelBottom.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Panel PanelBottom;
        private System.Windows.Forms.Button ButtonLoadFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

