using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductsMaintenance
{
    public partial class ProductsForm : Form
    {
        public ProductsForm()
        {
            InitializeComponent();
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'northwindDataSet.Suppliers' table. You can move, or remove it, as needed.
            this.suppliersTableAdapter.Fill(this.northwindDataSet.Suppliers);
            // TODO: This line of code loads data into the 'northwindDataSet.NumProductsTable' table. You can move, or remove it, as needed.
            this.numProductsTableAdapter.Fill(this.northwindDataSet.NumProductsTable);

        }

        private void supplierList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (supplierList.SelectedValue != null)
            {
            supplierID.Text = supplierList.SelectedValue.ToString();
            }
        }
    }
}
