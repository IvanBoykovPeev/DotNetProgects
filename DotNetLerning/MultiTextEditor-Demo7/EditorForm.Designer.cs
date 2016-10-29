namespace MultiTextEditor_Demo7
{
    partial class EditorForm
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
            this.EditorRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // EditorRichTextBox
            // 
            this.EditorRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditorRichTextBox.Location = new System.Drawing.Point(0, 0);
            this.EditorRichTextBox.Name = "EditorRichTextBox";
            this.EditorRichTextBox.Size = new System.Drawing.Size(284, 261);
            this.EditorRichTextBox.TabIndex = 0;
            this.EditorRichTextBox.Text = "";
            this.EditorRichTextBox.SelectionChanged += new System.EventHandler(this.EditorRichTextBox_SelectionChanged);
            // 
            // SaveFileDialog
            // 
            this.SaveFileDialog.Filter = "\"Text files (*.txt)| *.txt\"";
            // 
            // EditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.EditorRichTextBox);
            this.Name = "EditorForm";
            this.Text = "EditorForm";
            this.Activated += new System.EventHandler(this.EditorForm_Activated);
            this.Leave += new System.EventHandler(this.EditorForm_Closed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox EditorRichTextBox;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
    }
}