using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiTextEditor_Demo7
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MenuItemFileNew_Click(object sender, EventArgs e)
        {
            CreateNewFile();
        }        

        private void MenuItemFileOpen_Click(object sender, EventArgs e)
        {
            OpenExistinfFile();
        }

        private void MenuItemFileSave_Click(object sender, EventArgs e)
        {
            SaveCurrentFile();
        }

        private void ToolStripButtonNew_Click(object sender, EventArgs e)
        {
            CreateNewFile();
        }

        private void ToolStripButtonOpen_Click(object sender, EventArgs e)
        {
            OpenExistinfFile();
        }

        private void ToolStripButtonSave_Click(object sender, EventArgs e)
        {
            SaveCurrentFile();
        }







        private void CreateNewFile()
        {
            EditorForm editorForm = new EditorForm();
            editorForm.MdiParent = this;

            editorForm.Show();
        }

        private void OpenExistinfFile()
        {
            throw new NotImplementedException();
        }

        private void SaveCurrentFile()
        {
            throw new NotImplementedException();
        }

        private void MenuItemFileExit_Click(object sender, EventArgs e)
        {
            Close();
        }



        

        
    }
}
