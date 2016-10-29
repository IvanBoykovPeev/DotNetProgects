using System;
using System.IO;
using System.Windows.Forms;

namespace MultiTextEditor_Demo7
{
    public partial class EditorForm : Form
    {
        private string mFileName = null;

        public EditorForm()
        {
            InitializeComponent();
        }        

        public void CreateNewFile()
        {
            SetStatusBarInfo("Created new file.");
            mFileName = null;
            this.Text = "Untitled";
        }

        public void LoadFile(string aFileName)
        {
            mFileName = aFileName;
            this.Text = Path.GetFileName(aFileName);
            using (StreamReader reader = File.OpenText(aFileName))
            {
                string fileContents = reader.ReadToEnd();
                EditorRichTextBox.Text = fileContents;
            }
        }

        public void Save()
        {
            if (mFileName == null)
            {
                if (SaveFileDialog.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
                mFileName = SaveFileDialog.FileName;
                this.Text = Path.GetFileName(mFileName);
            }

            using(StreamWriter writer = new StreamWriter(mFileName))
	        {
                writer.Write(EditorRichTextBox.Text);
	        }

            SetStatusBarInfo("Saved file: " + mFileName);
        }

        private void SetStatusBarInfo(string aText)
        {
            MainForm mainForm = (MainForm)this.MdiParent;
            mainForm.SetInfoStatusBar(aText);
        }

        private void EditorForm_Activated(object sender, System.EventArgs e)
        {
            ShowLineNumber();
        }

        private void EditorRichTextBox_SelectionChanged(object sender, EventArgs e)
        {
            ShowLineNumber();
        }

        private void SetStatusBarLine(string aText)
        {
            MainForm mainForm = (MainForm)this.MdiParent;
            mainForm.SetLineStatusBar(aText);
        }

        public void ShowLineNumber()
        {
            int currentPos = EditorRichTextBox.SelectionStart;
            int line = EditorRichTextBox.GetLineFromCharIndex(currentPos);
            SetStatusBarLine("Line: " + line);
        }

        private void EditorForm_Closed(object sender, EventArgs e)
        {
            if (mFileName != null)
            {
                SetStatusBarInfo("Closed file: " + mFileName);
            }
            else
            {
                SetStatusBarInfo("Closed file.");
            }
            SetStatusBarInfo("");
        }

        private void EditorForm_Closed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
