using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SipleBindingControlWithObject
{
    public class SipleBindingControlWithObject : Form
    {
        static void Main()
        {            
            SipleBindingControlWithObject mainForm = new SipleBindingControlWithObject();
            mainForm.Text = "Simple Form";
            TextBox myBox = new TextBox();
            TextBox textBox = new TextBox();
            TextBox textBoxTowns = new TextBox();
            Custumer cust = new Custumer();
            cust.Name = "Иван";
            string[] towns = { "София", "Пловдив", "Варна" };
            myBox.DataBindings.Add(new Binding("Text", cust, "Name"));
            textBoxTowns.DataBindings.Add(new Binding("Text", towns, ""));
            //mainForm.Controls.Add(myBox);
            //mainForm.Controls.Add(textBox);
            mainForm.Controls.Add(textBoxTowns);
            mainForm.ShowDialog();
            mainForm.Dispose();
        }

        class Custumer
        {
            private string mName;
            public string Name
            {
                get { return mName; }
                set { mName = value; }
            }
        }
    }
}
