namespace ProductsMaintenance
{
    partial class ProductsForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.numProducts = new System.Windows.Forms.Label();
            this.supplierList = new System.Windows.Forms.ComboBox();
            this.supplierID = new System.Windows.Forms.Label();
            this.suppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.northwindDataSet = new ProductsMaintenance.NorthwindDataSet();
            this.numProductsTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.numProductsTableAdapter = new ProductsMaintenance.NorthwindDataSetTableAdapters.NumProductsTableAdapter();
            this.suppliersTableAdapter = new ProductsMaintenance.NorthwindDataSetTableAdapters.SuppliersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numProductsTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of Products:";
            // 
            // numProducts
            // 
            this.numProducts.AutoSize = true;
            this.numProducts.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.numProductsTableBindingSource, "NumProducts", true));
            this.numProducts.Location = new System.Drawing.Point(131, 34);
            this.numProducts.Name = "numProducts";
            this.numProducts.Size = new System.Drawing.Size(69, 13);
            this.numProducts.TabIndex = 1;
            this.numProducts.Text = "numProducts";
            // 
            // supplierList
            // 
            this.supplierList.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suppliersBindingSource, "CompanyName", true));
            this.supplierList.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.suppliersBindingSource, "CompanyName", true));
            this.supplierList.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.suppliersBindingSource, "CompanyName", true));
            this.supplierList.DataSource = this.suppliersBindingSource;
            this.supplierList.DisplayMember = "CompanyName";
            this.supplierList.FormattingEnabled = true;
            this.supplierList.Location = new System.Drawing.Point(25, 65);
            this.supplierList.Name = "supplierList";
            this.supplierList.Size = new System.Drawing.Size(121, 21);
            this.supplierList.TabIndex = 2;
            this.supplierList.ValueMember = "SupplierID";
            this.supplierList.SelectedIndexChanged += new System.EventHandler(this.supplierList_SelectedIndexChanged);
            // 
            // supplierID
            // 
            this.supplierID.AutoSize = true;
            this.supplierID.Location = new System.Drawing.Point(178, 70);
            this.supplierID.Name = "supplierID";
            this.supplierID.Size = new System.Drawing.Size(54, 13);
            this.supplierID.TabIndex = 3;
            this.supplierID.Text = "supplierID";
            // 
            // suppliersBindingSource
            // 
            this.suppliersBindingSource.DataMember = "Suppliers";
            this.suppliersBindingSource.DataSource = this.northwindDataSet;
            // 
            // northwindDataSet
            // 
            this.northwindDataSet.DataSetName = "NorthwindDataSet";
            this.northwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // numProductsTableBindingSource
            // 
            this.numProductsTableBindingSource.DataMember = "NumProductsTable";
            this.numProductsTableBindingSource.DataSource = this.northwindDataSet;
            // 
            // numProductsTableAdapter
            // 
            this.numProductsTableAdapter.ClearBeforeFill = true;
            // 
            // suppliersTableAdapter
            // 
            this.suppliersTableAdapter.ClearBeforeFill = true;
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.supplierID);
            this.Controls.Add(this.supplierList);
            this.Controls.Add(this.numProducts);
            this.Controls.Add(this.label1);
            this.Name = "ProductsForm";
            this.Text = "Products Maintenance";
            this.Load += new System.EventHandler(this.ProductsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numProductsTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label numProducts;
        private NorthwindDataSet northwindDataSet;
        private System.Windows.Forms.BindingSource numProductsTableBindingSource;
        private NorthwindDataSetTableAdapters.NumProductsTableAdapter numProductsTableAdapter;
        private System.Windows.Forms.ComboBox supplierList;
        private System.Windows.Forms.Label supplierID;
        private System.Windows.Forms.BindingSource suppliersBindingSource;
        private NorthwindDataSetTableAdapters.SuppliersTableAdapter suppliersTableAdapter;
    }
}

