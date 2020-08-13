namespace Avtopark
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.panel1 = new System.Windows.Forms.Panel();
            this.YellowPanel = new System.Windows.Forms.Panel();
            this.IncomeButton = new System.Windows.Forms.Button();
            this.WorkingsDaysButton = new System.Windows.Forms.Button();
            this.DriversButton = new System.Windows.Forms.Button();
            this.AutoRepairButton = new System.Windows.Forms.Button();
            this.AvtoButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.addCarForm = new Avtopark.AddCarForm();
            this.CarsListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel4 = new System.Windows.Forms.Panel();
            this.NonServiceRecordSaveButton = new System.Windows.Forms.Button();
            this.AddServiceRecordInFileButton = new System.Windows.Forms.Button();
            this.addCarServiceRecord = new Avtopark.AddCarServiceRecord();
            this.OpenCarServiceRecordForm_Button = new System.Windows.Forms.Button();
            this.historyTOCarsForm = new Avtopark.HistoryTOCarsForm();
            this.InsDateLabel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.InsLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.LicenseDateLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.LicenseLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CarPriceLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PTSLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SORLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AddCarButton = new System.Windows.Forms.Button();
            this.RenameCarButton = new System.Windows.Forms.Button();
            this.DelCarButton = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.AddCarOnDBbutton = new System.Windows.Forms.Button();
            this.NoSaveOnDBbutton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.YellowPanel);
            this.panel1.Controls.Add(this.IncomeButton);
            this.panel1.Controls.Add(this.WorkingsDaysButton);
            this.panel1.Controls.Add(this.DriversButton);
            this.panel1.Controls.Add(this.AutoRepairButton);
            this.panel1.Controls.Add(this.AvtoButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 650);
            this.panel1.TabIndex = 0;
            // 
            // YellowPanel
            // 
            this.YellowPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(168)))), ((int)(((byte)(37)))));
            this.YellowPanel.Location = new System.Drawing.Point(0, 72);
            this.YellowPanel.Margin = new System.Windows.Forms.Padding(0);
            this.YellowPanel.Name = "YellowPanel";
            this.YellowPanel.Size = new System.Drawing.Size(10, 50);
            this.YellowPanel.TabIndex = 2;
            this.YellowPanel.Visible = false;
            // 
            // IncomeButton
            // 
            this.IncomeButton.FlatAppearance.BorderSize = 0;
            this.IncomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IncomeButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IncomeButton.ForeColor = System.Drawing.Color.White;
            this.IncomeButton.Image = ((System.Drawing.Image)(resources.GetObject("IncomeButton.Image")));
            this.IncomeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IncomeButton.Location = new System.Drawing.Point(12, 272);
            this.IncomeButton.Margin = new System.Windows.Forms.Padding(0);
            this.IncomeButton.Name = "IncomeButton";
            this.IncomeButton.Size = new System.Drawing.Size(213, 50);
            this.IncomeButton.TabIndex = 5;
            this.IncomeButton.Text = "     Доход";
            this.IncomeButton.UseVisualStyleBackColor = true;
            this.IncomeButton.Click += new System.EventHandler(this.IncomeButton_Click);
            // 
            // WorkingsDaysButton
            // 
            this.WorkingsDaysButton.FlatAppearance.BorderSize = 0;
            this.WorkingsDaysButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WorkingsDaysButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WorkingsDaysButton.ForeColor = System.Drawing.Color.White;
            this.WorkingsDaysButton.Image = ((System.Drawing.Image)(resources.GetObject("WorkingsDaysButton.Image")));
            this.WorkingsDaysButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.WorkingsDaysButton.Location = new System.Drawing.Point(12, 222);
            this.WorkingsDaysButton.Margin = new System.Windows.Forms.Padding(0);
            this.WorkingsDaysButton.Name = "WorkingsDaysButton";
            this.WorkingsDaysButton.Size = new System.Drawing.Size(213, 50);
            this.WorkingsDaysButton.TabIndex = 4;
            this.WorkingsDaysButton.Text = "     Смены";
            this.WorkingsDaysButton.UseVisualStyleBackColor = true;
            this.WorkingsDaysButton.Click += new System.EventHandler(this.WorkingsDaysButton_Click);
            // 
            // DriversButton
            // 
            this.DriversButton.FlatAppearance.BorderSize = 0;
            this.DriversButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DriversButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DriversButton.ForeColor = System.Drawing.Color.White;
            this.DriversButton.Image = ((System.Drawing.Image)(resources.GetObject("DriversButton.Image")));
            this.DriversButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DriversButton.Location = new System.Drawing.Point(12, 172);
            this.DriversButton.Margin = new System.Windows.Forms.Padding(0);
            this.DriversButton.Name = "DriversButton";
            this.DriversButton.Size = new System.Drawing.Size(213, 50);
            this.DriversButton.TabIndex = 3;
            this.DriversButton.Text = "       Водители";
            this.DriversButton.UseVisualStyleBackColor = true;
            this.DriversButton.Click += new System.EventHandler(this.DriversButton_Click);
            // 
            // AutoRepairButton
            // 
            this.AutoRepairButton.FlatAppearance.BorderSize = 0;
            this.AutoRepairButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AutoRepairButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AutoRepairButton.ForeColor = System.Drawing.Color.White;
            this.AutoRepairButton.Image = ((System.Drawing.Image)(resources.GetObject("AutoRepairButton.Image")));
            this.AutoRepairButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AutoRepairButton.Location = new System.Drawing.Point(12, 122);
            this.AutoRepairButton.Margin = new System.Windows.Forms.Padding(0);
            this.AutoRepairButton.Name = "AutoRepairButton";
            this.AutoRepairButton.Size = new System.Drawing.Size(213, 50);
            this.AutoRepairButton.TabIndex = 2;
            this.AutoRepairButton.Text = "       ТО / Ремонт";
            this.AutoRepairButton.UseVisualStyleBackColor = true;
            this.AutoRepairButton.Click += new System.EventHandler(this.AutoRepairButton_Click);
            // 
            // AvtoButton
            // 
            this.AvtoButton.FlatAppearance.BorderSize = 0;
            this.AvtoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AvtoButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AvtoButton.ForeColor = System.Drawing.Color.White;
            this.AvtoButton.Image = ((System.Drawing.Image)(resources.GetObject("AvtoButton.Image")));
            this.AvtoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AvtoButton.Location = new System.Drawing.Point(12, 72);
            this.AvtoButton.Margin = new System.Windows.Forms.Padding(0);
            this.AvtoButton.Name = "AvtoButton";
            this.AvtoButton.Size = new System.Drawing.Size(213, 50);
            this.AvtoButton.TabIndex = 1;
            this.AvtoButton.Text = "       Автомобили";
            this.AvtoButton.UseVisualStyleBackColor = true;
            this.AvtoButton.Click += new System.EventHandler(this.AvtoButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(225, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(825, 10);
            this.panel2.TabIndex = 1;
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.FlatAppearance.BorderSize = 0;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.Image = ((System.Drawing.Image)(resources.GetObject("MinimizeButton.Image")));
            this.MinimizeButton.Location = new System.Drawing.Point(971, 13);
            this.MinimizeButton.Margin = new System.Windows.Forms.Padding(0);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(35, 35);
            this.MinimizeButton.TabIndex = 1;
            this.MinimizeButton.UseVisualStyleBackColor = true;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Image = ((System.Drawing.Image)(resources.GetObject("CloseButton.Image")));
            this.CloseButton.Location = new System.Drawing.Point(1006, 13);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(35, 35);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.addCarForm);
            this.panel3.Controls.Add(this.CarsListView);
            this.panel3.Location = new System.Drawing.Point(231, 51);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(809, 285);
            this.panel3.TabIndex = 2;
            // 
            // addCarForm
            // 
            this.addCarForm.BackColor = System.Drawing.Color.LightSteelBlue;
            this.addCarForm.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.addCarForm.Location = new System.Drawing.Point(-6, 0);
            this.addCarForm.Name = "addCarForm";
            this.addCarForm.Size = new System.Drawing.Size(816, 285);
            this.addCarForm.TabIndex = 1;
            this.addCarForm.VisibleChanged += new System.EventHandler(this.addCarForm_VisibleChanged);
            // 
            // CarsListView
            // 
            this.CarsListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CarsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.CarsListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CarsListView.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CarsListView.ForeColor = System.Drawing.Color.RoyalBlue;
            this.CarsListView.FullRowSelect = true;
            this.CarsListView.GridLines = true;
            this.CarsListView.HideSelection = false;
            this.CarsListView.Location = new System.Drawing.Point(0, 0);
            this.CarsListView.Name = "CarsListView";
            this.CarsListView.Size = new System.Drawing.Size(809, 285);
            this.CarsListView.TabIndex = 0;
            this.CarsListView.UseCompatibleStateImageBehavior = false;
            this.CarsListView.View = System.Windows.Forms.View.Details;
            this.CarsListView.SelectedIndexChanged += new System.EventHandler(this.CarsListView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Парковый №";
            this.columnHeader1.Width = 110;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Марка ТС";
            this.columnHeader2.Width = 130;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Модель ТС";
            this.columnHeader3.Width = 140;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Гос. номер";
            this.columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Год выпуска";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Пробег, км";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Дата ТО";
            this.columnHeader7.Width = 100;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel4.Controls.Add(this.NonServiceRecordSaveButton);
            this.panel4.Controls.Add(this.AddServiceRecordInFileButton);
            this.panel4.Controls.Add(this.addCarServiceRecord);
            this.panel4.Controls.Add(this.OpenCarServiceRecordForm_Button);
            this.panel4.Controls.Add(this.historyTOCarsForm);
            this.panel4.Controls.Add(this.InsDateLabel);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.InsLabel);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.LicenseDateLabel);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.LicenseLabel);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.CarPriceLabel);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.PTSLabel);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.SORLabel);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(230, 416);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(810, 222);
            this.panel4.TabIndex = 3;
            // 
            // NonServiceRecordSaveButton
            // 
            this.NonServiceRecordSaveButton.FlatAppearance.BorderSize = 2;
            this.NonServiceRecordSaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NonServiceRecordSaveButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NonServiceRecordSaveButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.NonServiceRecordSaveButton.Location = new System.Drawing.Point(651, 186);
            this.NonServiceRecordSaveButton.Name = "NonServiceRecordSaveButton";
            this.NonServiceRecordSaveButton.Size = new System.Drawing.Size(117, 31);
            this.NonServiceRecordSaveButton.TabIndex = 17;
            this.NonServiceRecordSaveButton.Text = "Отмена";
            this.NonServiceRecordSaveButton.UseVisualStyleBackColor = true;
            this.NonServiceRecordSaveButton.Click += new System.EventHandler(this.NonServiceRecordSaveButton_Click);
            // 
            // AddServiceRecordInFileButton
            // 
            this.AddServiceRecordInFileButton.FlatAppearance.BorderSize = 2;
            this.AddServiceRecordInFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddServiceRecordInFileButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddServiceRecordInFileButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.AddServiceRecordInFileButton.Location = new System.Drawing.Point(528, 186);
            this.AddServiceRecordInFileButton.Name = "AddServiceRecordInFileButton";
            this.AddServiceRecordInFileButton.Size = new System.Drawing.Size(117, 31);
            this.AddServiceRecordInFileButton.TabIndex = 16;
            this.AddServiceRecordInFileButton.Text = "Добавить";
            this.AddServiceRecordInFileButton.UseVisualStyleBackColor = true;
            this.AddServiceRecordInFileButton.Click += new System.EventHandler(this.AddServiceRecordInFileButton_Click);
            // 
            // addCarServiceRecord
            // 
            this.addCarServiceRecord.BackColor = System.Drawing.Color.LightSteelBlue;
            this.addCarServiceRecord.Location = new System.Drawing.Point(0, 0);
            this.addCarServiceRecord.Name = "addCarServiceRecord";
            this.addCarServiceRecord.Size = new System.Drawing.Size(810, 222);
            this.addCarServiceRecord.TabIndex = 15;
            this.addCarServiceRecord.VisibleChanged += new System.EventHandler(this.addCarServiceRecord_VisibleChanged);
            // 
            // AddServiceRecordButton
            // 
            this.OpenCarServiceRecordForm_Button.FlatAppearance.BorderSize = 2;
            this.OpenCarServiceRecordForm_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenCarServiceRecordForm_Button.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenCarServiceRecordForm_Button.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.OpenCarServiceRecordForm_Button.Location = new System.Drawing.Point(651, 171);
            this.OpenCarServiceRecordForm_Button.Name = "AddServiceRecordButton";
            this.OpenCarServiceRecordForm_Button.Size = new System.Drawing.Size(149, 35);
            this.OpenCarServiceRecordForm_Button.TabIndex = 14;
            this.OpenCarServiceRecordForm_Button.Text = "Добавить запись";
            this.OpenCarServiceRecordForm_Button.UseVisualStyleBackColor = true;
            this.OpenCarServiceRecordForm_Button.Visible = false;
            this.OpenCarServiceRecordForm_Button.Click += new System.EventHandler(this.OpenCarServiceRecordForm_Button_Click);
            // 
            // historyTOCarsForm
            // 
            this.historyTOCarsForm.Location = new System.Drawing.Point(0, 0);
            this.historyTOCarsForm.Name = "historyTOCarsForm";
            this.historyTOCarsForm.Size = new System.Drawing.Size(810, 222);
            this.historyTOCarsForm.TabIndex = 10;
            // 
            // InsDateLabel
            // 
            this.InsDateLabel.AutoSize = true;
            this.InsDateLabel.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InsDateLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.InsDateLabel.Location = new System.Drawing.Point(542, 110);
            this.InsDateLabel.Name = "InsDateLabel";
            this.InsDateLabel.Size = new System.Drawing.Size(0, 19);
            this.InsDateLabel.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(374, 110);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(131, 19);
            this.label13.TabIndex = 12;
            this.label13.Text = "Полис ОСАГО до:";
            // 
            // InsLabel
            // 
            this.InsLabel.AutoSize = true;
            this.InsLabel.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InsLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.InsLabel.Location = new System.Drawing.Point(542, 77);
            this.InsLabel.Name = "InsLabel";
            this.InsLabel.Size = new System.Drawing.Size(0, 19);
            this.InsLabel.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(374, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(134, 19);
            this.label11.TabIndex = 10;
            this.label11.Text = "№ Полиса ОСАГО";
            // 
            // LicenseDateLabel
            // 
            this.LicenseDateLabel.AutoSize = true;
            this.LicenseDateLabel.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LicenseDateLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.LicenseDateLabel.Location = new System.Drawing.Point(542, 46);
            this.LicenseDateLabel.Name = "LicenseDateLabel";
            this.LicenseDateLabel.Size = new System.Drawing.Size(0, 19);
            this.LicenseDateLabel.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(374, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 19);
            this.label9.TabIndex = 8;
            this.label9.Text = "Лицензия такси до:";
            // 
            // LicenseLabel
            // 
            this.LicenseLabel.AutoSize = true;
            this.LicenseLabel.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LicenseLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.LicenseLabel.Location = new System.Drawing.Point(542, 15);
            this.LicenseLabel.Name = "LicenseLabel";
            this.LicenseLabel.Size = new System.Drawing.Size(0, 19);
            this.LicenseLabel.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(374, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "№ Лицензии такси";
            // 
            // CarPriceLabel
            // 
            this.CarPriceLabel.AutoSize = true;
            this.CarPriceLabel.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CarPriceLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.CarPriceLabel.Location = new System.Drawing.Point(170, 91);
            this.CarPriceLabel.Name = "CarPriceLabel";
            this.CarPriceLabel.Size = new System.Drawing.Size(0, 19);
            this.CarPriceLabel.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(21, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Цена покупки ТС";
            // 
            // PTSLabel
            // 
            this.PTSLabel.AutoSize = true;
            this.PTSLabel.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PTSLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.PTSLabel.Location = new System.Drawing.Point(80, 53);
            this.PTSLabel.Name = "PTSLabel";
            this.PTSLabel.Size = new System.Drawing.Size(0, 19);
            this.PTSLabel.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(21, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "ПТС";
            // 
            // SORLabel
            // 
            this.SORLabel.AutoSize = true;
            this.SORLabel.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SORLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.SORLabel.Location = new System.Drawing.Point(80, 15);
            this.SORLabel.Name = "SORLabel";
            this.SORLabel.Size = new System.Drawing.Size(0, 19);
            this.SORLabel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(21, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "СОР";
            // 
            // AddCarButton
            // 
            this.AddCarButton.FlatAppearance.BorderSize = 0;
            this.AddCarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCarButton.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddCarButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.AddCarButton.Location = new System.Drawing.Point(710, 353);
            this.AddCarButton.Margin = new System.Windows.Forms.Padding(0);
            this.AddCarButton.Name = "AddCarButton";
            this.AddCarButton.Size = new System.Drawing.Size(110, 44);
            this.AddCarButton.TabIndex = 4;
            this.AddCarButton.Text = "Добавить";
            this.AddCarButton.UseVisualStyleBackColor = true;
            this.AddCarButton.Click += new System.EventHandler(this.AddCarButton_Click);
            // 
            // RenameCarButton
            // 
            this.RenameCarButton.FlatAppearance.BorderSize = 0;
            this.RenameCarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RenameCarButton.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RenameCarButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.RenameCarButton.Location = new System.Drawing.Point(820, 353);
            this.RenameCarButton.Margin = new System.Windows.Forms.Padding(0);
            this.RenameCarButton.Name = "RenameCarButton";
            this.RenameCarButton.Size = new System.Drawing.Size(110, 44);
            this.RenameCarButton.TabIndex = 5;
            this.RenameCarButton.Text = "Изменить";
            this.RenameCarButton.UseVisualStyleBackColor = true;
            this.RenameCarButton.Click += new System.EventHandler(this.RenameCarButton_Click);
            // 
            // DelCarButton
            // 
            this.DelCarButton.FlatAppearance.BorderSize = 0;
            this.DelCarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DelCarButton.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DelCarButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.DelCarButton.Location = new System.Drawing.Point(930, 353);
            this.DelCarButton.Margin = new System.Windows.Forms.Padding(0);
            this.DelCarButton.Name = "DelCarButton";
            this.DelCarButton.Size = new System.Drawing.Size(110, 44);
            this.DelCarButton.TabIndex = 6;
            this.DelCarButton.Text = "Удалить";
            this.DelCarButton.UseVisualStyleBackColor = true;
            this.DelCarButton.Click += new System.EventHandler(this.DelCarButton_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.panel5.Location = new System.Drawing.Point(241, 408);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(777, 2);
            this.panel5.TabIndex = 7;
            // 
            // AddCarOnDBbutton
            // 
            this.AddCarOnDBbutton.FlatAppearance.BorderSize = 0;
            this.AddCarOnDBbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCarOnDBbutton.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddCarOnDBbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.AddCarOnDBbutton.Location = new System.Drawing.Point(798, 322);
            this.AddCarOnDBbutton.Margin = new System.Windows.Forms.Padding(0);
            this.AddCarOnDBbutton.Name = "AddCarOnDBbutton";
            this.AddCarOnDBbutton.Size = new System.Drawing.Size(110, 75);
            this.AddCarOnDBbutton.TabIndex = 8;
            this.AddCarOnDBbutton.Text = "Сохранить";
            this.AddCarOnDBbutton.UseVisualStyleBackColor = true;
            this.AddCarOnDBbutton.Visible = false;
            this.AddCarOnDBbutton.Click += new System.EventHandler(this.AddCarOnDB_Button_Click);
            // 
            // NoSaveOnDBbutton
            // 
            this.NoSaveOnDBbutton.FlatAppearance.BorderSize = 0;
            this.NoSaveOnDBbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NoSaveOnDBbutton.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NoSaveOnDBbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.NoSaveOnDBbutton.Location = new System.Drawing.Point(908, 322);
            this.NoSaveOnDBbutton.Margin = new System.Windows.Forms.Padding(0);
            this.NoSaveOnDBbutton.Name = "NoSaveOnDBbutton";
            this.NoSaveOnDBbutton.Size = new System.Drawing.Size(110, 75);
            this.NoSaveOnDBbutton.TabIndex = 9;
            this.NoSaveOnDBbutton.Text = "Отмена";
            this.NoSaveOnDBbutton.UseVisualStyleBackColor = true;
            this.NoSaveOnDBbutton.Visible = false;
            this.NoSaveOnDBbutton.Click += new System.EventHandler(this.NoSaveOnDBbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1050, 650);
            this.Controls.Add(this.NoSaveOnDBbutton);
            this.Controls.Add(this.AddCarOnDBbutton);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.DelCarButton);
            this.Controls.Add(this.RenameCarButton);
            this.Controls.Add(this.AddCarButton);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.MinimizeButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        public void HideButton()
        {
            NonServiceRecordSaveButton.Hide();
            AddServiceRecordInFileButton.Hide();
        }
        public void ShowButton()
        {
            NonServiceRecordSaveButton.Show();
            AddServiceRecordInFileButton.Show();

            NonServiceRecordSaveButton.BringToFront();
            AddServiceRecordInFileButton.BringToFront();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AvtoButton;
        private System.Windows.Forms.Button AutoRepairButton;
        private System.Windows.Forms.Button WorkingsDaysButton;
        private System.Windows.Forms.Button DriversButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button IncomeButton;
        private System.Windows.Forms.Panel YellowPanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView CarsListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label SORLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label InsDateLabel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label InsLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label LicenseDateLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LicenseLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label CarPriceLabel;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label PTSLabel;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button AddCarButton;
        public System.Windows.Forms.Button RenameCarButton;
        public System.Windows.Forms.Button DelCarButton;
        private System.Windows.Forms.Panel panel5;
        private AddCarForm addCarForm;
        public System.Windows.Forms.Button AddCarOnDBbutton;
        public System.Windows.Forms.Button NoSaveOnDBbutton;
        private HistoryTOCarsForm historyTOCarsForm;
        public System.Windows.Forms.Button OpenCarServiceRecordForm_Button;
        private AddCarServiceRecord addCarServiceRecord;
        private System.Windows.Forms.Button NonServiceRecordSaveButton;
        private System.Windows.Forms.Button AddServiceRecordInFileButton;
    }
}

