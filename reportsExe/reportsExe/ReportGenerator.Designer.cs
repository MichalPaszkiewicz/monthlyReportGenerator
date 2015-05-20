namespace reportsExe
{
    partial class ReportGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportGenerator));
            this.ReportGrid = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.January = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.February = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.March = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.April = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.May = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.June = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.July = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.August = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.September = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.October = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.November = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.December = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ReportGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ReportGrid
            // 
            resources.ApplyResources(this.ReportGrid, "ReportGrid");
            this.ReportGrid.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.ReportGrid.AllowUserToOrderColumns = true;
            this.ReportGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.ReportGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReportGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.January,
            this.February,
            this.March,
            this.April,
            this.May,
            this.June,
            this.July,
            this.August,
            this.September,
            this.October,
            this.November,
            this.December});
            this.ReportGrid.GridColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ReportGrid.Name = "ReportGrid";
            this.ReportGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Name
            // 
            resources.ApplyResources(this.Name, "Name");
            this.Name.Name = "Name";
            // 
            // January
            // 
            resources.ApplyResources(this.January, "January");
            this.January.Name = "January";
            // 
            // February
            // 
            resources.ApplyResources(this.February, "February");
            this.February.Name = "February";
            // 
            // March
            // 
            resources.ApplyResources(this.March, "March");
            this.March.Name = "March";
            // 
            // April
            // 
            resources.ApplyResources(this.April, "April");
            this.April.Name = "April";
            // 
            // May
            // 
            resources.ApplyResources(this.May, "May");
            this.May.Name = "May";
            // 
            // June
            // 
            resources.ApplyResources(this.June, "June");
            this.June.Name = "June";
            // 
            // July
            // 
            resources.ApplyResources(this.July, "July");
            this.July.Name = "July";
            // 
            // August
            // 
            resources.ApplyResources(this.August, "August");
            this.August.Name = "August";
            // 
            // September
            // 
            resources.ApplyResources(this.September, "September");
            this.September.Name = "September";
            // 
            // October
            // 
            resources.ApplyResources(this.October, "October");
            this.October.Name = "October";
            // 
            // November
            // 
            resources.ApplyResources(this.November, "November");
            this.November.Name = "November";
            // 
            // December
            // 
            resources.ApplyResources(this.December, "December");
            this.December.Name = "December";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ReportGenerator
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ReportGrid);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReportGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ReportGrid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn January;
        private System.Windows.Forms.DataGridViewTextBoxColumn February;
        private System.Windows.Forms.DataGridViewTextBoxColumn March;
        private System.Windows.Forms.DataGridViewTextBoxColumn April;
        private System.Windows.Forms.DataGridViewTextBoxColumn May;
        private System.Windows.Forms.DataGridViewTextBoxColumn June;
        private System.Windows.Forms.DataGridViewTextBoxColumn July;
        private System.Windows.Forms.DataGridViewTextBoxColumn August;
        private System.Windows.Forms.DataGridViewTextBoxColumn September;
        private System.Windows.Forms.DataGridViewTextBoxColumn October;
        private System.Windows.Forms.DataGridViewTextBoxColumn November;
        private System.Windows.Forms.DataGridViewTextBoxColumn December;
    }
}

