namespace ComplexBinding
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
            this.ComboBoxTowns = new System.Windows.Forms.ComboBox();
            this.ButtonShow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ComboBoxTowns
            // 
            this.ComboBoxTowns.FormattingEnabled = true;
            this.ComboBoxTowns.Location = new System.Drawing.Point(13, 13);
            this.ComboBoxTowns.Name = "ComboBoxTowns";
            this.ComboBoxTowns.Size = new System.Drawing.Size(259, 21);
            this.ComboBoxTowns.TabIndex = 0;
            // 
            // ButtonShow
            // 
            this.ButtonShow.Location = new System.Drawing.Point(13, 41);
            this.ButtonShow.Name = "ButtonShow";
            this.ButtonShow.Size = new System.Drawing.Size(259, 23);
            this.ButtonShow.TabIndex = 1;
            this.ButtonShow.Text = "Show";
            this.ButtonShow.UseVisualStyleBackColor = true;
            this.ButtonShow.Click += new System.EventHandler(this.ButtonShow_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 85);
            this.Controls.Add(this.ButtonShow);
            this.Controls.Add(this.ComboBoxTowns);
            this.Name = "MainForm";
            this.Text = "Complex Binding";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboBoxTowns;
        private System.Windows.Forms.Button ButtonShow;
    }
}

