using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorForm
{
    public class CalculatorForm : Form
    {
        private TextBox TexBoxNumber1;
        private TextBox TexBoxNumber2;
        private TextBox TexBoxSum;
        private Button ButtonCalc;
        private Label LabelPlus;
        private Label LabelEquals;

        public CalculatorForm()
        {
            TexBoxNumber1 = new TextBox();
            TexBoxNumber1.Bounds = new Rectangle(new Point(16, 16), new Size(72, 20));
            TexBoxNumber1.MaxLength = 10;

            LabelPlus = new Label();
            LabelPlus.AutoSize = true;
            LabelPlus.Location = new Point(94, 19);
            LabelPlus.Text = "+";

            TexBoxNumber2 = new TextBox();
            TexBoxNumber2.Bounds = new Rectangle(new Point(112, 16), new Size(72, 20));
            TexBoxNumber2.MaxLength = 10;

            LabelEquals = new Label();
            LabelEquals.AutoSize = true;
            LabelEquals.Location = new Point(191, 18);
            LabelEquals.Text = "=";

            TexBoxSum = new TextBox();
            TexBoxSum.Bounds = new Rectangle(new Point(208, 16), new Size(72, 20));
            TexBoxSum.ReadOnly = true;

            ButtonCalc = new Button();
            ButtonCalc.Bounds = new Rectangle(new Point(16, 48), new Size(264, 23));
            ButtonCalc.Text = "Calculate sum";
            ButtonCalc.Click += new EventHandler(this.ButtonCalc_Click);

            this.ClientSize = new Size(298, 87);
            this.Controls.Add(TexBoxNumber1);
            this.Controls.Add(LabelPlus);
            this.Controls.Add(TexBoxNumber2);
            this.Controls.Add(LabelEquals);            
            this.Controls.Add(TexBoxSum);
            this.Controls.Add(ButtonCalc);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Text = "Calculator";
        }

        private void ButtonCalc_Click(object eSender, EventArgs aArgs)
        {
            try
            {
                int value1 = Int32.Parse(TexBoxNumber1.Text);
                int value2 = Int32.Parse(TexBoxNumber2.Text);
                int sum = value1 + value2;
                TexBoxSum.Text = sum.ToString();
            }
            catch(FormatException)
            {
                TexBoxSum.Text = "Invalid!";
            }

            TexBoxNumber1.SelectAll();
            TexBoxNumber2.SelectAll();

            TexBoxNumber1.Focus();
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            CalculatorForm calcForm = new CalculatorForm();
            Application.Run(calcForm);
        }
    }
}
