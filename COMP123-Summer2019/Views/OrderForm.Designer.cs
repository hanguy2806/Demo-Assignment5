namespace COMP123_Summer2019.Views
{
    partial class OrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            this.OrderFormMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductsPrintForm = new Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(this.components);
            this.TotalLine = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.FinishButton = new System.Windows.Forms.Button();
            this.SystemComponentGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.osLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lcdSizeDataLabel = new System.Windows.Forms.Label();
            this.memoryDataLabel = new System.Windows.Forms.Label();
            this.cpuBrandDataLabel = new System.Windows.Forms.Label();
            this.cpuTypeDataLabel = new System.Windows.Forms.Label();
            this.cpuNoDataLabel = new System.Windows.Forms.Label();
            this.cpuSpeedDataLabel = new System.Windows.Forms.Label();
            this.hddDataLabel = new System.Windows.Forms.Label();
            this.gpuDataLabel = new System.Windows.Forms.Label();
            this.webcamDataLabel = new System.Windows.Forms.Label();
            this.osDataLabel = new System.Windows.Forms.Label();
            this.PlatformDataLabel = new System.Windows.Forms.Label();
            this.ModelDataLabel = new System.Windows.Forms.Label();
            this.ManufacturerDataLabel = new System.Windows.Forms.Label();
            this.ConditionDataLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.PriceGroupBox = new System.Windows.Forms.GroupBox();
            this.label31 = new System.Windows.Forms.Label();
            this.totalDataLabel = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.taxDataLabel = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.priceDataLabel = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.computerPrintForm = new Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(this.components);
            this.OrderFormMenuStrip.SuspendLayout();
            this.SystemComponentGroupBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PriceGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // OrderFormMenuStrip
            // 
            this.OrderFormMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.OrderFormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.OrderFormMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.OrderFormMenuStrip.Name = "OrderFormMenuStrip";
            this.OrderFormMenuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.OrderFormMenuStrip.Size = new System.Drawing.Size(778, 33);
            this.OrderFormMenuStrip.TabIndex = 0;
            this.OrderFormMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.printToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(190, 6);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(193, 30);
            this.printToolStripMenuItem.Text = "&Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.PrintToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(190, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(193, 30);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.backToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.backToolStripMenuItem.Text = "&Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.BackToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(61, 29);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(155, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(158, 30);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // ProductsPrintForm
            // 
            this.ProductsPrintForm.DocumentName = "document";
            this.ProductsPrintForm.Form = this;
            this.ProductsPrintForm.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter;
            this.ProductsPrintForm.PrinterSettings = ((System.Drawing.Printing.PrinterSettings)(resources.GetObject("ProductsPrintForm.PrinterSettings")));
            this.ProductsPrintForm.PrintFileName = null;
            // 
            // TotalLine
            // 
            this.TotalLine.BorderWidth = 3;
            this.TotalLine.Name = "TotalLine";
            this.TotalLine.X1 = 18;
            this.TotalLine.X2 = 319;
            this.TotalLine.Y1 = 92;
            this.TotalLine.Y2 = 92;
            // 
            // FinishButton
            // 
            this.FinishButton.Location = new System.Drawing.Point(665, 484);
            this.FinishButton.Margin = new System.Windows.Forms.Padding(2);
            this.FinishButton.Name = "FinishButton";
            this.FinishButton.Size = new System.Drawing.Size(93, 35);
            this.FinishButton.TabIndex = 2;
            this.FinishButton.Text = "Finish";
            this.FinishButton.UseVisualStyleBackColor = true;
            this.FinishButton.Click += new System.EventHandler(this.FinishButton_Click);
            // 
            // SystemComponentGroupBox
            // 
            this.SystemComponentGroupBox.Controls.Add(this.tableLayoutPanel1);
            this.SystemComponentGroupBox.Controls.Add(this.PlatformDataLabel);
            this.SystemComponentGroupBox.Controls.Add(this.ModelDataLabel);
            this.SystemComponentGroupBox.Controls.Add(this.ManufacturerDataLabel);
            this.SystemComponentGroupBox.Controls.Add(this.ConditionDataLabel);
            this.SystemComponentGroupBox.Controls.Add(this.label6);
            this.SystemComponentGroupBox.Controls.Add(this.label2);
            this.SystemComponentGroupBox.Controls.Add(this.label4);
            this.SystemComponentGroupBox.Controls.Add(this.label1);
            this.SystemComponentGroupBox.Location = new System.Drawing.Point(9, 37);
            this.SystemComponentGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.SystemComponentGroupBox.Name = "SystemComponentGroupBox";
            this.SystemComponentGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.SystemComponentGroupBox.Size = new System.Drawing.Size(419, 496);
            this.SystemComponentGroupBox.TabIndex = 3;
            this.SystemComponentGroupBox.TabStop = false;
            this.SystemComponentGroupBox.Text = "System Components";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.17032F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.82968F));
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label12, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label13, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.osLbl, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lcdSizeDataLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.memoryDataLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cpuBrandDataLabel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cpuTypeDataLabel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.cpuNoDataLabel, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.cpuSpeedDataLabel, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.hddDataLabel, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.gpuDataLabel, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.webcamDataLabel, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.osDataLabel, 1, 9);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 132);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(411, 359);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Location = new System.Drawing.Point(3, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 35);
            this.label5.TabIndex = 1;
            this.label5.Text = "Memory";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Location = new System.Drawing.Point(3, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 35);
            this.label7.TabIndex = 1;
            this.label7.Text = "CPU Brand";
            this.label7.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.Location = new System.Drawing.Point(3, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 35);
            this.label8.TabIndex = 1;
            this.label8.Text = "CPU Type";
            this.label8.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.Location = new System.Drawing.Point(3, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 35);
            this.label9.TabIndex = 1;
            this.label9.Text = "CPU number";
            this.label9.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.Location = new System.Drawing.Point(3, 175);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 35);
            this.label10.TabIndex = 1;
            this.label10.Text = "CPU speed";
            this.label10.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.Location = new System.Drawing.Point(3, 210);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 35);
            this.label11.TabIndex = 1;
            this.label11.Text = "HDD";
            this.label11.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.Location = new System.Drawing.Point(3, 245);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 35);
            this.label12.TabIndex = 1;
            this.label12.Text = "GPU Type";
            this.label12.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.Location = new System.Drawing.Point(3, 280);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(118, 35);
            this.label13.TabIndex = 1;
            this.label13.Text = "Webcam";
            this.label13.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // osLbl
            // 
            this.osLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.osLbl.Location = new System.Drawing.Point(3, 315);
            this.osLbl.Name = "osLbl";
            this.osLbl.Size = new System.Drawing.Size(118, 44);
            this.osLbl.TabIndex = 1;
            this.osLbl.Text = "OS";
            this.osLbl.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 35);
            this.label3.TabIndex = 0;
            this.label3.Text = "LCD Size";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lcdSizeDataLabel
            // 
            this.lcdSizeDataLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lcdSizeDataLabel.Location = new System.Drawing.Point(127, 0);
            this.lcdSizeDataLabel.Name = "lcdSizeDataLabel";
            this.lcdSizeDataLabel.Size = new System.Drawing.Size(281, 35);
            this.lcdSizeDataLabel.TabIndex = 0;
            this.lcdSizeDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // memoryDataLabel
            // 
            this.memoryDataLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.memoryDataLabel.Location = new System.Drawing.Point(127, 35);
            this.memoryDataLabel.Name = "memoryDataLabel";
            this.memoryDataLabel.Size = new System.Drawing.Size(281, 35);
            this.memoryDataLabel.TabIndex = 0;
            this.memoryDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cpuBrandDataLabel
            // 
            this.cpuBrandDataLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cpuBrandDataLabel.Location = new System.Drawing.Point(127, 70);
            this.cpuBrandDataLabel.Name = "cpuBrandDataLabel";
            this.cpuBrandDataLabel.Size = new System.Drawing.Size(281, 35);
            this.cpuBrandDataLabel.TabIndex = 0;
            this.cpuBrandDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cpuTypeDataLabel
            // 
            this.cpuTypeDataLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cpuTypeDataLabel.Location = new System.Drawing.Point(127, 105);
            this.cpuTypeDataLabel.Name = "cpuTypeDataLabel";
            this.cpuTypeDataLabel.Size = new System.Drawing.Size(281, 35);
            this.cpuTypeDataLabel.TabIndex = 0;
            this.cpuTypeDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cpuNoDataLabel
            // 
            this.cpuNoDataLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cpuNoDataLabel.Location = new System.Drawing.Point(127, 140);
            this.cpuNoDataLabel.Name = "cpuNoDataLabel";
            this.cpuNoDataLabel.Size = new System.Drawing.Size(281, 35);
            this.cpuNoDataLabel.TabIndex = 0;
            this.cpuNoDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cpuSpeedDataLabel
            // 
            this.cpuSpeedDataLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cpuSpeedDataLabel.Location = new System.Drawing.Point(127, 175);
            this.cpuSpeedDataLabel.Name = "cpuSpeedDataLabel";
            this.cpuSpeedDataLabel.Size = new System.Drawing.Size(281, 35);
            this.cpuSpeedDataLabel.TabIndex = 0;
            this.cpuSpeedDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // hddDataLabel
            // 
            this.hddDataLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.hddDataLabel.Location = new System.Drawing.Point(127, 210);
            this.hddDataLabel.Name = "hddDataLabel";
            this.hddDataLabel.Size = new System.Drawing.Size(281, 35);
            this.hddDataLabel.TabIndex = 0;
            this.hddDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gpuDataLabel
            // 
            this.gpuDataLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gpuDataLabel.Location = new System.Drawing.Point(127, 245);
            this.gpuDataLabel.Name = "gpuDataLabel";
            this.gpuDataLabel.Size = new System.Drawing.Size(281, 35);
            this.gpuDataLabel.TabIndex = 0;
            this.gpuDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // webcamDataLabel
            // 
            this.webcamDataLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.webcamDataLabel.Location = new System.Drawing.Point(127, 280);
            this.webcamDataLabel.Name = "webcamDataLabel";
            this.webcamDataLabel.Size = new System.Drawing.Size(281, 35);
            this.webcamDataLabel.TabIndex = 0;
            this.webcamDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // osDataLabel
            // 
            this.osDataLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.osDataLabel.Location = new System.Drawing.Point(127, 315);
            this.osDataLabel.Name = "osDataLabel";
            this.osDataLabel.Size = new System.Drawing.Size(281, 44);
            this.osDataLabel.TabIndex = 0;
            this.osDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PlatformDataLabel
            // 
            this.PlatformDataLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PlatformDataLabel.Location = new System.Drawing.Point(310, 39);
            this.PlatformDataLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PlatformDataLabel.Name = "PlatformDataLabel";
            this.PlatformDataLabel.Size = new System.Drawing.Size(96, 22);
            this.PlatformDataLabel.TabIndex = 1;
            // 
            // ModelDataLabel
            // 
            this.ModelDataLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ModelDataLabel.Location = new System.Drawing.Point(310, 87);
            this.ModelDataLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ModelDataLabel.Name = "ModelDataLabel";
            this.ModelDataLabel.Size = new System.Drawing.Size(96, 22);
            this.ModelDataLabel.TabIndex = 1;
            // 
            // ManufacturerDataLabel
            // 
            this.ManufacturerDataLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ManufacturerDataLabel.Location = new System.Drawing.Point(125, 87);
            this.ManufacturerDataLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ManufacturerDataLabel.Name = "ManufacturerDataLabel";
            this.ManufacturerDataLabel.Size = new System.Drawing.Size(86, 22);
            this.ManufacturerDataLabel.TabIndex = 1;
            // 
            // ConditionDataLabel
            // 
            this.ConditionDataLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ConditionDataLabel.Location = new System.Drawing.Point(125, 39);
            this.ConditionDataLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ConditionDataLabel.Name = "ConditionDataLabel";
            this.ConditionDataLabel.Size = new System.Drawing.Size(86, 22);
            this.ConditionDataLabel.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(214, 87);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 22);
            this.label6.TabIndex = 0;
            this.label6.Text = "Model";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(214, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Platform";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(4, 87);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Manufacturer";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(20, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Condition";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(470, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 156);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(568, 484);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(470, 484);
            this.BackButton.Margin = new System.Windows.Forms.Padding(2);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(93, 35);
            this.BackButton.TabIndex = 2;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackToolStripMenuItem_Click);
            // 
            // PriceGroupBox
            // 
            this.PriceGroupBox.Controls.Add(this.label31);
            this.PriceGroupBox.Controls.Add(this.totalDataLabel);
            this.PriceGroupBox.Controls.Add(this.label29);
            this.PriceGroupBox.Controls.Add(this.taxDataLabel);
            this.PriceGroupBox.Controls.Add(this.label27);
            this.PriceGroupBox.Controls.Add(this.priceDataLabel);
            this.PriceGroupBox.Controls.Add(this.label25);
            this.PriceGroupBox.Controls.Add(this.shapeContainer2);
            this.PriceGroupBox.Location = new System.Drawing.Point(433, 228);
            this.PriceGroupBox.Name = "PriceGroupBox";
            this.PriceGroupBox.Size = new System.Drawing.Size(333, 175);
            this.PriceGroupBox.TabIndex = 5;
            this.PriceGroupBox.TabStop = false;
            this.PriceGroupBox.Text = "Your Price";
            // 
            // label31
            // 
            this.label31.Location = new System.Drawing.Point(16, 140);
            this.label31.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(92, 22);
            this.label31.TabIndex = 0;
            this.label31.Text = "Total";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // totalDataLabel
            // 
            this.totalDataLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.totalDataLabel.Location = new System.Drawing.Point(203, 140);
            this.totalDataLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalDataLabel.Name = "totalDataLabel";
            this.totalDataLabel.Size = new System.Drawing.Size(112, 22);
            this.totalDataLabel.TabIndex = 1;
            // 
            // label29
            // 
            this.label29.Location = new System.Drawing.Point(16, 70);
            this.label29.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(175, 22);
            this.label29.TabIndex = 0;
            this.label29.Text = "Sales Tax (13%)";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // taxDataLabel
            // 
            this.taxDataLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.taxDataLabel.Location = new System.Drawing.Point(195, 70);
            this.taxDataLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.taxDataLabel.Name = "taxDataLabel";
            this.taxDataLabel.Size = new System.Drawing.Size(120, 22);
            this.taxDataLabel.TabIndex = 1;
            // 
            // label27
            // 
            this.label27.Location = new System.Drawing.Point(16, 70);
            this.label27.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(92, 22);
            this.label27.TabIndex = 0;
            this.label27.Text = "Model";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // priceDataLabel
            // 
            this.priceDataLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.priceDataLabel.Location = new System.Drawing.Point(195, 35);
            this.priceDataLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.priceDataLabel.Name = "priceDataLabel";
            this.priceDataLabel.Size = new System.Drawing.Size(120, 22);
            this.priceDataLabel.TabIndex = 1;
            // 
            // label25
            // 
            this.label25.Location = new System.Drawing.Point(16, 35);
            this.label25.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(92, 22);
            this.label25.TabIndex = 0;
            this.label25.Text = "Price";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(3, 24);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.TotalLine});
            this.shapeContainer2.Size = new System.Drawing.Size(327, 148);
            this.shapeContainer2.TabIndex = 2;
            this.shapeContainer2.TabStop = false;
            // 
            // computerPrintForm
            // 
            this.computerPrintForm.DocumentName = "document";
            this.computerPrintForm.Form = this;
            this.computerPrintForm.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter;
            this.computerPrintForm.PrinterSettings = ((System.Drawing.Printing.PrinterSettings)(resources.GetObject("computerPrintForm.PrinterSettings")));
            this.computerPrintForm.PrintFileName = null;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 544);
            this.ControlBox = false;
            this.Controls.Add(this.PriceGroupBox);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SystemComponentGroupBox);
            this.Controls.Add(this.FinishButton);
            this.Controls.Add(this.OrderFormMenuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.OrderFormMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderForm";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.OrderFormMenuStrip.ResumeLayout(false);
            this.OrderFormMenuStrip.PerformLayout();
            this.SystemComponentGroupBox.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PriceGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip OrderFormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private Microsoft.VisualBasic.PowerPacks.Printing.PrintForm ProductsPrintForm;
        private Microsoft.VisualBasic.PowerPacks.LineShape TotalLine;
        private System.Windows.Forms.Button FinishButton;
        private System.Windows.Forms.GroupBox SystemComponentGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label PlatformDataLabel;
        private System.Windows.Forms.Label ModelDataLabel;
        private System.Windows.Forms.Label ManufacturerDataLabel;
        private System.Windows.Forms.Label ConditionDataLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label osLbl;
        private System.Windows.Forms.Label lcdSizeDataLabel;
        private System.Windows.Forms.Label memoryDataLabel;
        private System.Windows.Forms.Label cpuBrandDataLabel;
        private System.Windows.Forms.Label cpuTypeDataLabel;
        private System.Windows.Forms.Label cpuNoDataLabel;
        private System.Windows.Forms.Label cpuSpeedDataLabel;
        private System.Windows.Forms.Label hddDataLabel;
        private System.Windows.Forms.Label gpuDataLabel;
        private System.Windows.Forms.Label webcamDataLabel;
        private System.Windows.Forms.Label osDataLabel;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox PriceGroupBox;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label totalDataLabel;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label taxDataLabel;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label priceDataLabel;
        private System.Windows.Forms.Label label25;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.Printing.PrintForm computerPrintForm;
    }
}