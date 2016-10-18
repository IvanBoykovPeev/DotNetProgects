using System;
using System.Windows.Forms;

namespace SampleForms
{
    public class SampleForms : Form
    {
        static void Main()
        {
            SampleForms sampleForm = new SampleForms();
            sampleForm.Text = "Sample form";
            Button button = new Button();
            button.Text = "Close";
            button.Click += new EventHandler(sampleForm.button_Click);
            sampleForm.Controls.Add(button);
            sampleForm.ShowDialog();
            sampleForm.Dispose();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
