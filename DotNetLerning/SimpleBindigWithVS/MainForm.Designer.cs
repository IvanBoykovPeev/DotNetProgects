namespace SimpleBindigWithVS
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
            this.TextBoxCustumrName = new System.Windows.Forms.TextBox();
            this.ButtonShowCustomer = new System.Windows.Forms.Button();
            this.ChangeCustomer = new System.Windows.Forms.Button();
            this.ButtonRebind = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBoxCustumrName
            // 
            this.TextBoxCustumrName.Location = new System.Drawing.Point(43, 12);
            this.TextBoxCustumrName.Name = "TextBoxCustumrName";
            this.TextBoxCustumrName.Size = new System.Drawing.Size(208, 20);
            this.TextBoxCustumrName.TabIndex = 0;
            // 
            // ButtonShowCustomer
            // 
            this.ButtonShowCustomer.Location = new System.Drawing.Point(81, 51);
            this.ButtonShowCustomer.Name = "ButtonShowCustomer";
            this.ButtonShowCustomer.Size = new System.Drawing.Size(141, 23);
            this.ButtonShowCustomer.TabIndex = 1;
            this.ButtonShowCustomer.Text = "ShowCustomer";
            this.ButtonShowCustomer.UseVisualStyleBackColor = true;
            this.ButtonShowCustomer.Click += new System.EventHandler(this.ButtonShowCustumer_Click);
            // 
            // ChangeCustomer
            // 
            this.ChangeCustomer.Location = new System.Drawing.Point(81, 95);
            this.ChangeCustomer.Name = "ChangeCustomer";
            this.ChangeCustomer.Size = new System.Drawing.Size(141, 23);
            this.ChangeCustomer.TabIndex = 2;
            this.ChangeCustomer.Text = "ChangeCustomer";
            this.ChangeCustomer.UseVisualStyleBackColor = true;
            this.ChangeCustomer.Click += new System.EventHandler(this.ButtonChangeCustumer_Click);
            // 
            // ButtonRebind
            // 
            this.ButtonRebind.Location = new System.Drawing.Point(81, 140);
            this.ButtonRebind.Name = "ButtonRebind";
            this.ButtonRebind.Size = new System.Drawing.Size(141, 23);
            this.ButtonRebind.TabIndex = 3;
            this.ButtonRebind.Text = "ButtonRebind";
            this.ButtonRebind.UseVisualStyleBackColor = true;
            this.ButtonRebind.Click += new System.EventHandler(this.ButtonRebind_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.ButtonRebind);
            this.Controls.Add(this.ChangeCustomer);
            this.Controls.Add(this.ButtonShowCustomer);
            this.Controls.Add(this.TextBoxCustumrName);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxCustumrName;
        private System.Windows.Forms.Button ButtonShowCustomer;
        private System.Windows.Forms.Button ChangeCustomer;
        private System.Windows.Forms.Button ButtonRebind;
    }
}

