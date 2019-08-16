using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * STUDENT NAME: THI THU HA NGUYEN
 * ID:301017727
 * DESCRIPTION: this is product information form get all the information from selected item.
 */

namespace COMP123_Summer2019.Views
{
    public partial class ProductInfoForm : Form
    {
        public ProductInfoForm()
        {
            InitializeComponent();
        }

        private void SelectAnotherProductButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.selectForm.Show();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.orderForm.Show();
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // configure the file dialog
            ComputerOpenFileDialog.FileName = "computer.txt";
            ComputerOpenFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            ComputerOpenFileDialog.Filter = "Text Files (*.txt)|*.txt| All Files (*.*)|*.*";

            // open the file dialog
            var result = ComputerOpenFileDialog.ShowDialog();
            if (result != DialogResult.Cancel)
            {
                // Open your stream to read
                using (StreamReader inputStream = new StreamReader(
                    File.Open(ComputerOpenFileDialog.FileName, FileMode.Open)))
                {
                    // Read stuff into the Student class
                    Program.product.productID = short.Parse(inputStream.ReadLine());
                    Program.product.condition = inputStream.ReadLine();
                    Program.product.cost = decimal.Parse(inputStream.ReadLine());
                    Program.product.platform = inputStream.ReadLine();
                    Program.product.OS = inputStream.ReadLine();
                    Program.product.manufacturer = inputStream.ReadLine();
                    Program.product.model = inputStream.ReadLine();
                    Program.product.RAM_size = inputStream.ReadLine();
                    Program.product.screensize = inputStream.ReadLine();
                    Program.product.HDD_size = inputStream.ReadLine();
                    Program.product.CPU_brand = inputStream.ReadLine();
                    Program.product.CPU_number = inputStream.ReadLine();
                    Program.product.GPU_Type = inputStream.ReadLine();
                    Program.product.CPU_type = inputStream.ReadLine();
                    Program.product.CPU_speed = inputStream.ReadLine();
                    Program.product.webcam = inputStream.ReadLine();

                    // cleanup
                    inputStream.Close();
                    inputStream.Dispose();

                    ProductInfoForm_Activated(sender, e);
                }
            }
        }
        private void ProductInfoForm_Activated(object sender, EventArgs e)
        {
            ProductIdLabelData.Text = Program.product.productID.ToString();
            ConditionDataLabel.Text = Program.product.condition;
            CostDataLabel.Text = Program.product.cost.ToString();
            PlatformDataLabel.Text = Program.product.platform;
            OSDataLabel.Text = Program.product.OS;
            ManufacturerDataLabel.Text = Program.product.manufacturer;
            ModelDataLabel.Text = Program.product.model;
            memoryDataLabel.Text = Program.product.RAM_size;
            LCDSizeDataLabel.Text = Program.product.screensize;
            HDDDataLabel.Text = Program.product.HDD_size;
            CPUBrandDataLabel.Text = Program.product.CPU_brand;
            CPUNumberDataLabel.Text = Program.product.CPU_number;
            GPUTypeDataLabel.Text = Program.product.GPU_Type;
            CPUTypeDataLabel.Text = Program.product.CPU_type;
            CPUSpeedDataLabel.Text = Program.product.CPU_speed;
            WebcamDataLabel.Text = Program.product.webcam;
        }

        private void SaveToolStripButton_Click(object sender, EventArgs e)
        {
            computerSaveFileDialog.FileName = "computer.txt";
            computerSaveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            computerSaveFileDialog.Filter = "Text Files (*.txt)|*.txt | All Files (*.*)|*.*";

            var result = computerSaveFileDialog.ShowDialog();
            if (result != DialogResult.Cancel)
            {
                using (StreamWriter outputStream = new StreamWriter(File.Open(computerSaveFileDialog.FileName, FileMode.Create)))
                {
                    outputStream.WriteLine(Program.product.productID.ToString());
                    outputStream.WriteLine(Program.product.condition);
                    outputStream.WriteLine(Program.product.cost.ToString());
                    outputStream.WriteLine(Program.product.platform);
                    outputStream.WriteLine(Program.product.OS);
                    outputStream.WriteLine(Program.product.manufacturer);
                    outputStream.WriteLine(Program.product.model);
                    outputStream.WriteLine(Program.product.RAM_size);
                    outputStream.WriteLine(Program.product.screensize);
                    outputStream.WriteLine(Program.product.HDD_size);
                    outputStream.WriteLine(Program.product.CPU_brand);
                    outputStream.WriteLine(Program.product.CPU_number);
                    outputStream.WriteLine(Program.product.GPU_Type);
                    outputStream.WriteLine(Program.product.CPU_type);
                    outputStream.WriteLine(Program.product.CPU_speed);
                    outputStream.WriteLine(Program.product.webcam);

                    //clean up
                    outputStream.Close();
                    outputStream.Dispose();

                    MessageBox.Show("File Saved...");
                }
            }


        }
    }
}
