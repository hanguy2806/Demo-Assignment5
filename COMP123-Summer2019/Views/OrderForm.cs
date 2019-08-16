using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
/*
 * STUDENT NAME: THI THU HA NGUYEN
 * ID:301017727
 * DESCRIPTION: this is order form which displays the inf4 as well as the total of payment
 */
namespace COMP123_Summer2019.Views
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void PrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductsPrintForm.PrintAction = PrintAction.PrintToPreview;
            ProductsPrintForm.Print();
            MessageBox.Show("Your order is printing !");
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.aboutForm.ShowDialog();
        }

       

        private void BackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.productInfoForm.Show();
        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for your business!\n\nYour order will be processed in 7-10 business days.");
            Application.Exit();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            ConditionDataLabel.Text = Program.product.condition;
            PlatformDataLabel.Text = Program.product.platform;
            ManufacturerDataLabel.Text = Program.product.manufacturer;
            ModelDataLabel.Text = Program.product.model;
            lcdSizeDataLabel.Text = Program.product.screensize;
            memoryDataLabel.Text = Program.product.RAM_size;
            cpuBrandDataLabel.Text = Program.product.CPU_brand;
            cpuTypeDataLabel.Text = Program.product.CPU_type;
            cpuNoDataLabel.Text = Program.product.CPU_number;
            cpuSpeedDataLabel.Text = Program.product.CPU_speed;
            hddDataLabel.Text = Program.product.HDD_size;
            gpuDataLabel.Text = Program.product.GPU_Type;
            webcamDataLabel.Text = Program.product.webcam;
            osDataLabel.Text = Program.product.OS;
            priceDataLabel.Text = Program.product.cost.ToString();
            taxDataLabel.Text = (Program.product.cost * (decimal)0.13).ToString();
            totalDataLabel.Text= (Program.product.cost * (decimal)1.13).ToString();
        }
    }
}
