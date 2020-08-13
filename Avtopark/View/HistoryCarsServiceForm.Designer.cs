namespace Avtopark
{
    partial class HistoryTOCarsForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.carsHistoryServiceListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // carsHistoryServiceListView
            // 
            this.carsHistoryServiceListView.BackColor = System.Drawing.Color.LightSteelBlue;
            this.carsHistoryServiceListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.carsHistoryServiceListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.carsHistoryServiceListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.carsHistoryServiceListView.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.carsHistoryServiceListView.GridLines = true;
            this.carsHistoryServiceListView.HideSelection = false;
            this.carsHistoryServiceListView.Location = new System.Drawing.Point(0, 0);
            this.carsHistoryServiceListView.Name = "carsHistoryServiceListView";
            this.carsHistoryServiceListView.Size = new System.Drawing.Size(810, 222);
            this.carsHistoryServiceListView.TabIndex = 0;
            this.carsHistoryServiceListView.UseCompatibleStateImageBehavior = false;
            this.carsHistoryServiceListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Дата ТО";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Проведенные работы";
            this.columnHeader2.Width = 545;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Общая стоимость ТО";
            this.columnHeader3.Width = 160;
            // 
            // HistoryTOCarsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.carsHistoryServiceListView);
            this.Name = "HistoryTOCarsForm";
            this.Size = new System.Drawing.Size(810, 222);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView carsHistoryServiceListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}
