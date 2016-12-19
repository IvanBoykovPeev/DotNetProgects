using System;
using System.Windows.Forms;

namespace _07.Sumator
{
    public partial class FormCalculate : Form
    {
        public FormCalculate()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            try
            {
            var num1 = decimal.Parse(this.textBox1.Text);
            var num2 = decimal.Parse(this.textBox2.Text);
            var sum = num1 + num2;
            textBoxSum.Text = sum.ToString();
            }
            catch (Exception)
            {

                textBoxSum.Text = "error";
            }
        }
    }
}
