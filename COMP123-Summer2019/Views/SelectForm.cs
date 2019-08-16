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
/*
 * STUDENT NAME: THI THU HA NGUYEN
 * ID:301017727
 * DESCRIPTION: this is select from which allow user to select a product and show manufacturer, cost, product name in selection label
 */
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
           
        }

        private void ProductsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var rowIndex = ProductsDataGridView.CurrentCell.RowIndex;
            var rows = ProductsDataGridView.Rows;
            var columnCount = ProductsDataGridView.ColumnCount;
            var cells = rows[rowIndex].Cells;
            string outputString = string.Empty;
            rows[rowIndex].Selected = true;
            outputString += cells[(int)ProductField.MANUFACTURER].Value.ToString() + " " + 
                cells[(int)ProductField.COST].Value.ToString() + " " + cells[(int)ProductField.MODEL].Value.ToString();
            selectionTextbox.Text = outputString;
           
            //update value for product (which instantiate in main Program.
            Program.product.productID = short.Parse(cells[(int)ProductField.ID].Value.ToString());
            Program.product.condition = cells[(int)ProductField.condition].Value.ToString();
            Program.product.cost = decimal.Parse(cells[(int)ProductField.COST].Value.ToString());
            Program.product.platform = cells[(int)ProductField.platform].Value.ToString();
            Program.product.OS= cells[(int)ProductField.OS].Value.ToString();
            Program.product.manufacturer = cells[(int)ProductField.MANUFACTURER].Value.ToString();
            Program.product.model = cells[(int)ProductField.MODEL].Value.ToString();
            Program.product.RAM_size = cells[(int)ProductField.RAM_size].Value.ToString();
            Program.product.screensize= cells[(int)ProductField.screensize].Value.ToString();
            Program.product.HDD_size = cells[(int)ProductField.HDD_size].Value.ToString();
            Program.product.CPU_brand = cells[(int)ProductField.CPU_brand].Value.ToString();
            Program.product.CPU_number = cells[(int)ProductField.CPU_number].Value.ToString();
            Program.product.GPU_Type= cells[(int)ProductField.GPU_Type].Value.ToString();
            Program.product.CPU_type = cells[(int)ProductField.CPU_type].Value.ToString();
            Program.product.CPU_speed = cells[(int)ProductField.CPU_speed].Value.ToString();
            Program.product.webcam = cells[(int)ProductField.webcam].Value.ToString();
        }

    }
}
