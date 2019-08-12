using COMP123_Summer2019.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_Summer2019.Views
{
    public partial class SelectForm : Form
    {
        public SelectForm()
        {
            InitializeComponent();
        }

        public bool isConnectedToDatabase()
        {
            return false;
        }

        private void SelectForm_Load(object sender, EventArgs e)
        {
            using (var db = new DollarComputerContext())
            {
                db.products.Load();
                productBindingSource.DataSource = db.products.Local.ToBindingList();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.productInfoForm.Show();
            //open a stream to write
            using (StreamWriter outputString = new StreamWriter(File.Open("computer.txt",FileMode.Create
                )))
            {
                outputString.WriteLine(Program.product.productID);
                outputString.WriteLine(Program.product.condition);
                outputString.WriteLine(Program.product.cost);
                outputString.WriteLine(Program.product.platform);
                outputString.WriteLine(Program.product.OS);
                outputString.WriteLine(Program.product.manufacturer);
                outputString.WriteLine(Program.product.model);
                outputString.WriteLine(Program.product.RAM_size);
                outputString.WriteLine(Program.product.screensize);
                outputString.WriteLine(Program.product.HDD_size);
                outputString.WriteLine(Program.product.CPU_brand);
                outputString.WriteLine(Program.product.CPU_number);
                outputString.WriteLine(Program.product.GPU_Type);
                outputString.WriteLine(Program.product.CPU_type);
                outputString.WriteLine(Program.product.CPU_speed);
                outputString.WriteLine(Program.product.webcam);
                //clean up
                outputString.Close();
                outputString.Dispose();

            }


    }

    private void ProductsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        var rowIndex = ProductsDataGridView.CurrentCell.RowIndex;
        var rows = ProductsDataGridView.Rows;
        var columnCount = ProductsDataGridView.ColumnCount;
        var cells = rows[rowIndex].Cells;
        string outputString = string.Empty;
        rows[rowIndex].Selected = true;
        for (int index =1 ; index <4; index++)
        {
            outputString += cells[index].Value.ToString() + " ";
        }
        selectionTextbox.Text = outputString;
        Program.product.manufacturer = cells[(int)ProductField.MANUFACTURER].Value.ToString();
        Program.product.model = cells[(int)ProductField.MODEL].Value.ToString();
        Program.product.cost = decimal.Parse(cells[(int)ProductField.COST].Value.ToString());
    }

}
}
