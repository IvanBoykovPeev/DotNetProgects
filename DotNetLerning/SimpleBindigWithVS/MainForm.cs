using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleBindigWithVS
{
    public partial class MainForm : Form
    {
        private Custumer mCustumer;
        public MainForm()
        {
            InitializeComponent();
            
        }

        private void RebindFormControls()
        {
            TextBoxCustumrName.DataBindings.Clear();
            TextBoxCustumrName.DataBindings.Add(new Binding("Text", mCustumer, "Name"));
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            mCustumer = new Custumer();
            mCustumer.Name = "Иван";
            RebindFormControls();
        }

        private void ButtonShowCustumer_Click(object sender, System.EventArgs e)
        {
            string custumerName = mCustumer.Name;
            MessageBox.Show(custumerName);
        }

        private void ButtonChangeCustumer_Click(object sender, System.EventArgs e)
        {
            mCustumer.Name = "Дядо Коледа";
        }

        private void ButtonRebind_Click(object sender, System.EventArgs e)
        {
            RebindFormControls();
        }
    }
}
