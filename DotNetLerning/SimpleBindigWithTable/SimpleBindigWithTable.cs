using System;
using System.Data;
using System.Windows.Forms;

namespace SimpleBindigWithTable
{
    public class SimpleBindigWithTable : Form
    {
        static void Main()
        {
            SimpleBindigWithTable simpleBindigWithTable = new SimpleBindigWithTable();
            TextBox textBoxTowns = new TextBox();
            simpleBindigWithTable.Controls.Add(textBoxTowns);
            //Create a DataTable with columns id and name
            DataTable towns = new DataTable("Towns");
            towns.Columns.Add(new DataColumn("Id", typeof(int)));
            towns.Columns.Add(new DataColumn("name", typeof(string)));

            //Add tree rows to the table
            DataRow row;

            row = towns.NewRow();
            row["Id"] = 1;
            row["name"] = "София";
            towns.Rows.Add(row);

            row = towns.NewRow();
            row["Id"] = 2;
            row["name"] = "Пловдив";
            towns.Rows.Add(row);
            row = towns.NewRow();

            row["Id"] = 3;
            row["name"] = "Варна";
            towns.Rows.Add(row);

            //Create a DataSet and add the table to the DataSet
            DataSet ds = new DataSet();
            ds.Tables.Add(towns);
            textBoxTowns.DataBindings.Add(new Binding("Text", ds, "Towns.Name"));
            simpleBindigWithTable.ShowDialog();
            simpleBindigWithTable.Dispose();
        }
    }
}
