namespace COMP123_Summer2019.Views
{
    partial class ProductInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductInfoForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAnotherProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductIdLabel = new System.Windows.Forms.Label();
            this.ProductIdLabelData = new System.Windows.Forms.Label();
            this.ConditionLabel = new System.Windows.Forms.Label();
            this.ConditionDataLabel = new System.Windows.Forms.Label();
            this.CostDataLabel = new System.Windows.Forms.Label();
            this.TechSpecsGroupBox = new System.Windows.Forms.GroupBox();
            this.WebcamDataLabel = new System.Windows.Forms.Label();
            this.GPUTypeDataLabel = new System.Windows.Forms.Label();
            this.HDDDataLabel = new System.Windows.Forms.Label();
            this.CPUNumberDataLabel = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.CPUSpeedDataLabel = new System.Windows.Forms.Label();
            this.LCDSizeDataLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.HDDLabel = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.CPUBrandDataLabel = new System.Windows.Forms.Label();
            this.LCDLabel = new System.Windows.Forms.Label();
            this.CPUTypeDataLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ManufacturerLabel = new System.Windows.Forms.Label();
            this.PLatFormLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OSDataLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.ManufacturerDataLabel = new System.Windows.Forms.Label();
            this.PlatfromDataLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SelectAnotherProductButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ComputerOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.computerSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.TechSpecsGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(778, 35);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAnotherProductToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // selectAnotherProductToolStripMenuItem
            // 
            this.selectAnotherProductToolStripMenuItem.Name = "selectAnotherProductToolStripMenuItem";
            this.selectAnotherProductToolStripMenuItem.Size = new System.Drawing.Size(278, 30);
            this.selectAnotherProductToolStripMenuItem.Text = "Se&lect Another Product";
            // 
            // ProductIdLabel
            // 
            this.ProductIdLabel.Location = new System.Drawing.Point(18, 69);
            this.ProductIdLabel.Name = "ProductIdLabel";
            this.ProductIdLabel.Size = new System.Drawing.Size(96, 30);
            this.ProductIdLabel.TabIndex = 1;
            this.ProductIdLabel.Text = "Product ID";
            this.ProductIdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ProductIdLabelData
            // 
            this.ProductIdLabelData.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ProductIdLabelData.Location = new System.Drawing.Point(119, 72);
            this.ProductIdLabelData.Name = "ProductIdLabelData";
            this.ProductIdLabelData.Size = new System.Drawing.Size(101, 30);
            this.ProductIdLabelData.TabIndex = 1;
            this.ProductIdLabelData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ConditionLabel
            // 
            this.ConditionLabel.Location = new System.Drawing.Point(242, 72);
            this.ConditionLabel.Name = "ConditionLabel";
            this.ConditionLabel.Size = new System.Drawing.Size(100, 30);
            this.ConditionLabel.TabIndex = 1;
            this.ConditionLabel.Text = "Condition";
            this.ConditionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ConditionDataLabel
            // 
            this.ConditionDataLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ConditionDataLabel.Location = new System.Drawing.Point(343, 69);
            this.ConditionDataLabel.Name = "ConditionDataLabel";
            this.ConditionDataLabel.Size = new System.Drawing.Size(117, 30);
            this.ConditionDataLabel.TabIndex = 1;
            this.ConditionDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CostDataLabel
            // 
            this.CostDataLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CostDataLabel.Location = new System.Drawing.Point(541, 68);
            this.CostDataLabel.Name = "CostDataLabel";
            this.CostDataLabel.Size = new System.Drawing.Size(107, 30);
            this.CostDataLabel.TabIndex = 1;
            this.CostDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TechSpecsGroupBox
            // 
            this.TechSpecsGroupBox.Controls.Add(this.WebcamDataLabel);
            this.TechSpecsGroupBox.Controls.Add(this.GPUTypeDataLabel);
            this.TechSpecsGroupBox.Controls.Add(this.HDDDataLabel);
            this.TechSpecsGroupBox.Controls.Add(this.CPUNumberDataLabel);
            this.TechSpecsGroupBox.Controls.Add(this.label14);
            this.TechSpecsGroupBox.Controls.Add(this.CPUSpeedDataLabel);
            this.TechSpecsGroupBox.Controls.Add(this.LCDSizeDataLabel);
            this.TechSpecsGroupBox.Controls.Add(this.label1);
            this.TechSpecsGroupBox.Controls.Add(this.label10);
            this.TechSpecsGroupBox.Controls.Add(this.HDDLabel);
            this.TechSpecsGroupBox.Controls.Add(this.label17);
            this.TechSpecsGroupBox.Controls.Add(this.label18);
            this.TechSpecsGroupBox.Controls.Add(this.CPUBrandDataLabel);
            this.TechSpecsGroupBox.Controls.Add(this.LCDLabel);
            this.TechSpecsGroupBox.Controls.Add(this.CPUTypeDataLabel);
            this.TechSpecsGroupBox.Controls.Add(this.label6);
            this.TechSpecsGroupBox.Controls.Add(this.ManufacturerLabel);
            this.TechSpecsGroupBox.Controls.Add(this.PLatFormLabel);
            this.TechSpecsGroupBox.Location = new System.Drawing.Point(16, 256);
            this.TechSpecsGroupBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TechSpecsGroupBox.Name = "TechSpecsGroupBox";
            this.TechSpecsGroupBox.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TechSpecsGroupBox.Size = new System.Drawing.Size(737, 182);
            this.TechSpecsGroupBox.TabIndex = 2;
            this.TechSpecsGroupBox.TabStop = false;
            this.TechSpecsGroupBox.Text = "Tech Specs";
            // 
            // WebcamDataLabel
            // 
            this.WebcamDataLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.WebcamDataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.WebcamDataLabel.Location = new System.Drawing.Point(549, 140);
            this.WebcamDataLabel.Name = "WebcamDataLabel";
            this.WebcamDataLabel.Size = new System.Drawing.Size(172, 30);
            this.WebcamDataLabel.TabIndex = 1;
            this.WebcamDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GPUTypeDataLabel
            // 
            this.GPUTypeDataLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GPUTypeDataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.GPUTypeDataLabel.Location = new System.Drawing.Point(549, 89);
            this.GPUTypeDataLabel.Name = "GPUTypeDataLabel";
            this.GPUTypeDataLabel.Size = new System.Drawing.Size(172, 30);
            this.GPUTypeDataLabel.TabIndex = 1;
            this.GPUTypeDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // HDDDataLabel
            // 
            this.HDDDataLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.HDDDataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.HDDDataLabel.Location = new System.Drawing.Point(551, 32);
            this.HDDDataLabel.Name = "HDDDataLabel";
            this.HDDDataLabel.Size = new System.Drawing.Size(170, 30);
            this.HDDDataLabel.TabIndex = 1;
            this.HDDDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CPUNumberDataLabel
            // 
            this.CPUNumberDataLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CPUNumberDataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.CPUNumberDataLabel.Location = new System.Drawing.Point(325, 86);
            this.CPUNumberDataLabel.Name = "CPUNumberDataLabel";
            this.CPUNumberDataLabel.Size = new System.Drawing.Size(113, 30);
            this.CPUNumberDataLabel.TabIndex = 1;
            this.CPUNumberDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(426, 86);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(117, 30);
            this.label14.TabIndex = 1;
            this.label14.Text = "GPU Type";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CPUSpeedDataLabel
            // 
            this.CPUSpeedDataLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CPUSpeedDataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.CPUSpeedDataLabel.Location = new System.Drawing.Point(321, 139);
            this.CPUSpeedDataLabel.Name = "CPUSpeedDataLabel";
            this.CPUSpeedDataLabel.Size = new System.Drawing.Size(117, 30);
            this.CPUSpeedDataLabel.TabIndex = 1;
            this.CPUSpeedDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LCDSizeDataLabel
            // 
            this.LCDSizeDataLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LCDSizeDataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.LCDSizeDataLabel.Location = new System.Drawing.Point(325, 29);
            this.LCDSizeDataLabel.Name = "LCDSizeDataLabel";
            this.LCDSizeDataLabel.Size = new System.Drawing.Size(113, 30);
            this.LCDSizeDataLabel.TabIndex = 1;
            this.LCDSizeDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(422, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "WebCam";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(220, 86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 30);
            this.label10.TabIndex = 1;
            this.label10.Text = "CPU number";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // HDDLabel
            // 
            this.HDDLabel.Location = new System.Drawing.Point(422, 31);
            this.HDDLabel.Name = "HDDLabel";
            this.HDDLabel.Size = new System.Drawing.Size(115, 30);
            this.HDDLabel.TabIndex = 1;
            this.HDDLabel.Text = "HDD";
            this.HDDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label17.Location = new System.Drawing.Point(106, 33);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(101, 30);
            this.label17.TabIndex = 1;
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(205, 139);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(107, 30);
            this.label18.TabIndex = 1;
            this.label18.Text = "CPU speed";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CPUBrandDataLabel
            // 
            this.CPUBrandDataLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CPUBrandDataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.CPUBrandDataLabel.Location = new System.Drawing.Point(106, 83);
            this.CPUBrandDataLabel.Name = "CPUBrandDataLabel";
            this.CPUBrandDataLabel.Size = new System.Drawing.Size(101, 30);
            this.CPUBrandDataLabel.TabIndex = 1;
            this.CPUBrandDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LCDLabel
            // 
            this.LCDLabel.Location = new System.Drawing.Point(201, 29);
            this.LCDLabel.Name = "LCDLabel";
            this.LCDLabel.Size = new System.Drawing.Size(115, 30);
            this.LCDLabel.TabIndex = 1;
            this.LCDLabel.Text = "LCD Size";
            this.LCDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CPUTypeDataLabel
            // 
            this.CPUTypeDataLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CPUTypeDataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.CPUTypeDataLabel.Location = new System.Drawing.Point(106, 139);
            this.CPUTypeDataLabel.Name = "CPUTypeDataLabel";
            this.CPUTypeDataLabel.Size = new System.Drawing.Size(101, 30);
            this.CPUTypeDataLabel.TabIndex = 1;
            this.CPUTypeDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(1, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 30);
            this.label6.TabIndex = 1;
            this.label6.Text = "CPU Type";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ManufacturerLabel
            // 
            this.ManufacturerLabel.Location = new System.Drawing.Point(1, 92);
            this.ManufacturerLabel.Name = "ManufacturerLabel";
            this.ManufacturerLabel.Size = new System.Drawing.Size(99, 30);
            this.ManufacturerLabel.TabIndex = 1;
            this.ManufacturerLabel.Text = "CPU Brand";
            this.ManufacturerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PLatFormLabel
            // 
            this.PLatFormLabel.Location = new System.Drawing.Point(6, 32);
            this.PLatFormLabel.Name = "PLatFormLabel";
            this.PLatFormLabel.Size = new System.Drawing.Size(93, 30);
            this.PLatFormLabel.TabIndex = 1;
            this.PLatFormLabel.Text = "Memory";
            this.PLatFormLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OSDataLabel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ModelLabel);
            this.groupBox1.Controls.Add(this.ManufacturerDataLabel);
            this.groupBox1.Controls.Add(this.PlatfromDataLabel);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(15, 114);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(738, 136);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product Info";
            // 
            // OSDataLabel
            // 
            this.OSDataLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OSDataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.OSDataLabel.Location = new System.Drawing.Point(321, 32);
            this.OSDataLabel.Name = "OSDataLabel";
            this.OSDataLabel.Size = new System.Drawing.Size(381, 30);
            this.OSDataLabel.TabIndex = 1;
            this.OSDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(216, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "OS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ModelLabel
            // 
            this.ModelLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ModelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ModelLabel.Location = new System.Drawing.Point(321, 86);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(381, 30);
            this.ModelLabel.TabIndex = 1;
            this.ModelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ManufacturerDataLabel
            // 
            this.ManufacturerDataLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ManufacturerDataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ManufacturerDataLabel.Location = new System.Drawing.Point(106, 86);
            this.ManufacturerDataLabel.Name = "ManufacturerDataLabel";
            this.ManufacturerDataLabel.Size = new System.Drawing.Size(101, 30);
            this.ManufacturerDataLabel.TabIndex = 1;
            this.ManufacturerDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PlatfromDataLabel
            // 
            this.PlatfromDataLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PlatfromDataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.PlatfromDataLabel.Location = new System.Drawing.Point(106, 32);
            this.PlatfromDataLabel.Name = "PlatfromDataLabel";
            this.PlatfromDataLabel.Size = new System.Drawing.Size(101, 30);
            this.PlatfromDataLabel.TabIndex = 1;
            this.PlatfromDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(216, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 30);
            this.label7.TabIndex = 1;
            this.label7.Text = "Model";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(1, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 30);
            this.label8.TabIndex = 1;
            this.label8.Text = "Manufacturer";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(6, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 30);
            this.label9.TabIndex = 1;
            this.label9.Text = "Platform";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(16, 453);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(323, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Click Next to Confirm Your Selection";
            // 
            // SelectAnotherProductButton
            // 
            this.SelectAnotherProductButton.Location = new System.Drawing.Point(299, 485);
            this.SelectAnotherProductButton.Name = "SelectAnotherProductButton";
            this.SelectAnotherProductButton.Size = new System.Drawing.Size(217, 34);
            this.SelectAnotherProductButton.TabIndex = 4;
            this.SelectAnotherProductButton.Text = "Select Another Product";
            this.SelectAnotherProductButton.UseVisualStyleBackColor = true;
            this.SelectAnotherProductButton.Click += new System.EventHandler(this.SelectAnotherProductButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(543, 485);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(95, 34);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(665, 485);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(92, 34);
            this.NextButton.TabIndex = 4;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(466, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 30);
            this.label4.TabIndex = 1;
            this.label4.Text = "Cost";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(466, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 30);
            this.label5.TabIndex = 1;
            this.label5.Text = "Cost";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(553, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 30);
            this.label11.TabIndex = 1;
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripButton,
            this.saveToolStripButton,
            this.toolStripSeparator,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 35);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(778, 31);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(28, 28);
            this.openToolStripButton.Text = "&Open";
            this.openToolStripButton.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(28, 28);
            this.saveToolStripButton.Text = "&Save";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // ComputerOpenFileDialog
            // 
            this.ComputerOpenFileDialog.FileName = "openFileDialog1";
            // 
            // ProductInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 544);
            this.ControlBox = false;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SelectAnotherProductButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TechSpecsGroupBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.CostDataLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ConditionDataLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ConditionLabel);
            this.Controls.Add(this.ProductIdLabelData);
            this.Controls.Add(this.ProductIdLabel);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ProductInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Information Form";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.TechSpecsGroupBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAnotherProductToolStripMenuItem;
        private System.Windows.Forms.Label ProductIdLabel;
        private System.Windows.Forms.Label ProductIdLabelData;
        private System.Windows.Forms.Label ConditionLabel;
        private System.Windows.Forms.Label ConditionDataLabel;
        private System.Windows.Forms.Label CostDataLabel;
        private System.Windows.Forms.GroupBox TechSpecsGroupBox;
        private System.Windows.Forms.Label LCDSizeDataLabel;
        private System.Windows.Forms.Label LCDLabel;
        private System.Windows.Forms.Label ManufacturerLabel;
        private System.Windows.Forms.Label PLatFormLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label OSDataLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.Label ManufacturerDataLabel;
        private System.Windows.Forms.Label PlatfromDataLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label HDDDataLabel;
        private System.Windows.Forms.Label HDDLabel;
        private System.Windows.Forms.Label GPUTypeDataLabel;
        private System.Windows.Forms.Label CPUNumberDataLabel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label CPUTypeDataLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label CPUBrandDataLabel;
        private System.Windows.Forms.Label CPUSpeedDataLabel;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label WebcamDataLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SelectAnotherProductButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.OpenFileDialog ComputerOpenFileDialog;
        private System.Windows.Forms.SaveFileDialog computerSaveFileDialog;
    }
}