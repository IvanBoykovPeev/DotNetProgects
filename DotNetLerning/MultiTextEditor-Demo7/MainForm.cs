using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        private void MainForm_Load(object sender, EventArgs e)
        {
            SetInfoStatusBar("Application started.");
        }

        private void MenuItemFileNew_Click(object sender, EventArgs e)
        {
            CreateNewFile();
        }        

        private void MenuItemFileOpen_Click(object sender, EventArgs e)
        {
            OpenExistingFile();
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
            OpenExistingFile();
        }

        private void ToolStripButtonSave_Click(object sender, EventArgs e)
        {
            SaveCurrentFile();
        }


        public void SetInfoStatusBar(string aText)
        {
            toolStripStatusLabelInfo.Text = aText;
        }

        public void SetLineStatusBar(string aText)
        {
            toolStripStatusLabelLine.Text = aText;
        }

        private void CreateNewFile()
        {
            EditorForm editorForm = new EditorForm();
            editorForm.MdiParent = this;
            editorForm.CreateNewFile();
            editorForm.Show();
        }

        private void OpenExistingFile()
        {
            if (OpenFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            string fileName = OpenFileDialog.FileName;

            EditorForm editorForm = new EditorForm();
            try
            {
                editorForm.LoadFile(fileName);
                editorForm.MdiParent = this;
                editorForm.Show();
                SetInfoStatusBar("Loaded file: " + fileName);
            }
            catch(IOException)
            {
                editorForm.Dispose();
                MessageBox.Show("Can not load file: " + fileName, "Error");
            }
        }

        private void SaveCurrentFile()
        {
            EditorForm activeEditorForm = (EditorForm)this.ActiveMdiChild;
            if (activeEditorForm != null)
            {
                activeEditorForm.Save();
            }
        }

        private void MenuItemFileExit_Click(object sender, EventArgs e)
        {
            Close();
        }        
    }
}
