namespace Covid_19
{
    partial class Dashboard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.listBoxUsers = new System.Windows.Forms.ListBox();
            this._Covid_19DataSet = new Covid_19._Covid_19DataSet();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.userTableAdapter = new Covid_19._Covid_19DataSetTableAdapters.UserTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownTemperature = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownOximeter = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownHeartrate = new System.Windows.Forms.NumericUpDown();
            this.buttonSave = new System.Windows.Forms.Button();
            this.dataGridViewUserReadings = new System.Windows.Forms.DataGridView();
            this.buttonSave2DB = new System.Windows.Forms.Button();
            this.caloriesLabel = new System.Windows.Forms.Label();
            this.distanceLabel = new System.Windows.Forms.Label();
            this.temperatureLabel = new System.Windows.Forms.Label();
            this.heartrateCartesianChart = new LiveCharts.WinForms.CartesianChart();
            this.oximeterCartesianChart = new LiveCharts.WinForms.CartesianChart();
            this.TemperatureCartesianChart = new LiveCharts.WinForms.CartesianChart();
            this.pictureBoxRefresh = new System.Windows.Forms.PictureBox();
            this.dateTimePickerReadingTime = new System.Windows.Forms.DateTimePicker();
            this.listBoxChartUsers = new System.Windows.Forms.ListBox();
            this.buttonRefreshUser = new System.Windows.Forms.Button();
            this.buttonDB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._Covid_19DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTemperature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOximeter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeartrate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserReadings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRefresh)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxUsers
            // 
            this.listBoxUsers.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this._Covid_19DataSet, "User.User", true));
            this.listBoxUsers.DataSource = this.userBindingSource;
            this.listBoxUsers.DisplayMember = "User";
            this.listBoxUsers.Font = new System.Drawing.Font("Consolas", 9.25F, System.Drawing.FontStyle.Bold);
            this.listBoxUsers.FormattingEnabled = true;
            this.listBoxUsers.ItemHeight = 14;
            this.listBoxUsers.Location = new System.Drawing.Point(12, 28);
            this.listBoxUsers.Name = "listBoxUsers";
            this.listBoxUsers.Size = new System.Drawing.Size(67, 88);
            this.listBoxUsers.TabIndex = 0;
            this.listBoxUsers.ValueMember = "User";
            // 
            // _Covid_19DataSet
            // 
            this._Covid_19DataSet.DataSetName = "_Covid_19DataSet";
            this._Covid_19DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "User";
            this.userBindingSource.DataSource = this._Covid_19DataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "User List";
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 9.25F);
            this.label2.Location = new System.Drawing.Point(84, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Temperature";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 9.25F);
            this.label3.Location = new System.Drawing.Point(85, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Oximeter";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 9.25F);
            this.label4.Location = new System.Drawing.Point(85, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Heartrate";
            // 
            // numericUpDownTemperature
            // 
            this.numericUpDownTemperature.DecimalPlaces = 1;
            this.numericUpDownTemperature.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.numericUpDownTemperature.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownTemperature.Location = new System.Drawing.Point(174, 23);
            this.numericUpDownTemperature.Maximum = new decimal(new int[] {
            110,
            0,
            0,
            0});
            this.numericUpDownTemperature.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownTemperature.Name = "numericUpDownTemperature";
            this.numericUpDownTemperature.Size = new System.Drawing.Size(46, 20);
            this.numericUpDownTemperature.TabIndex = 1;
            this.numericUpDownTemperature.Value = new decimal(new int[] {
            99,
            0,
            0,
            0});
            // 
            // numericUpDownOximeter
            // 
            this.numericUpDownOximeter.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.numericUpDownOximeter.Location = new System.Drawing.Point(174, 47);
            this.numericUpDownOximeter.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownOximeter.Name = "numericUpDownOximeter";
            this.numericUpDownOximeter.Size = new System.Drawing.Size(46, 20);
            this.numericUpDownOximeter.TabIndex = 2;
            this.numericUpDownOximeter.Value = new decimal(new int[] {
            98,
            0,
            0,
            0});
            // 
            // numericUpDownHeartrate
            // 
            this.numericUpDownHeartrate.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.numericUpDownHeartrate.Location = new System.Drawing.Point(174, 71);
            this.numericUpDownHeartrate.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownHeartrate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownHeartrate.Name = "numericUpDownHeartrate";
            this.numericUpDownHeartrate.Size = new System.Drawing.Size(46, 20);
            this.numericUpDownHeartrate.TabIndex = 3;
            this.numericUpDownHeartrate.Value = new decimal(new int[] {
            85,
            0,
            0,
            0});
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(88, 96);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(43, 20);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // dataGridViewUserReadings
            // 
            this.dataGridViewUserReadings.AllowUserToAddRows = false;
            this.dataGridViewUserReadings.AllowUserToDeleteRows = false;
            this.dataGridViewUserReadings.AllowUserToResizeColumns = false;
            this.dataGridViewUserReadings.AllowUserToResizeRows = false;
            this.dataGridViewUserReadings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewUserReadings.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewUserReadings.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewUserReadings.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridViewUserReadings.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUserReadings.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewUserReadings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Consolas", 7.75F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewUserReadings.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewUserReadings.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewUserReadings.Location = new System.Drawing.Point(227, 23);
            this.dataGridViewUserReadings.Name = "dataGridViewUserReadings";
            this.dataGridViewUserReadings.ReadOnly = true;
            this.dataGridViewUserReadings.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUserReadings.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewUserReadings.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewUserReadings.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewUserReadings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewUserReadings.Size = new System.Drawing.Size(424, 93);
            this.dataGridViewUserReadings.TabIndex = 8;
            // 
            // buttonSave2DB
            // 
            this.buttonSave2DB.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave2DB.Location = new System.Drawing.Point(137, 96);
            this.buttonSave2DB.Name = "buttonSave2DB";
            this.buttonSave2DB.Size = new System.Drawing.Size(57, 20);
            this.buttonSave2DB.TabIndex = 9;
            this.buttonSave2DB.Text = "Save2DB";
            this.buttonSave2DB.UseVisualStyleBackColor = true;
            this.buttonSave2DB.Click += new System.EventHandler(this.buttonSave2DB_Click);
            // 
            // caloriesLabel
            // 
            this.caloriesLabel.AutoSize = true;
            this.caloriesLabel.BackColor = System.Drawing.SystemColors.Info;
            this.caloriesLabel.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caloriesLabel.Location = new System.Drawing.Point(33, 491);
            this.caloriesLabel.Name = "caloriesLabel";
            this.caloriesLabel.Size = new System.Drawing.Size(112, 14);
            this.caloriesLabel.TabIndex = 14;
            this.caloriesLabel.Text = "Heartrate Graph";
            this.caloriesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // distanceLabel
            // 
            this.distanceLabel.AutoSize = true;
            this.distanceLabel.BackColor = System.Drawing.SystemColors.Info;
            this.distanceLabel.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.distanceLabel.Location = new System.Drawing.Point(33, 325);
            this.distanceLabel.Name = "distanceLabel";
            this.distanceLabel.Size = new System.Drawing.Size(105, 14);
            this.distanceLabel.TabIndex = 15;
            this.distanceLabel.Text = "Oximeter Graph";
            this.distanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // temperatureLabel
            // 
            this.temperatureLabel.AutoSize = true;
            this.temperatureLabel.BackColor = System.Drawing.SystemColors.Info;
            this.temperatureLabel.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temperatureLabel.Location = new System.Drawing.Point(33, 148);
            this.temperatureLabel.Name = "temperatureLabel";
            this.temperatureLabel.Size = new System.Drawing.Size(126, 14);
            this.temperatureLabel.TabIndex = 13;
            this.temperatureLabel.Text = "Temperature Graph";
            this.temperatureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // heartrateCartesianChart
            // 
            this.heartrateCartesianChart.Location = new System.Drawing.Point(0, 491);
            this.heartrateCartesianChart.Name = "heartrateCartesianChart";
            this.heartrateCartesianChart.Size = new System.Drawing.Size(1345, 160);
            this.heartrateCartesianChart.TabIndex = 10;
            this.heartrateCartesianChart.Text = "Calories";
            // 
            // oximeterCartesianChart
            // 
            this.oximeterCartesianChart.Location = new System.Drawing.Point(0, 325);
            this.oximeterCartesianChart.Name = "oximeterCartesianChart";
            this.oximeterCartesianChart.Size = new System.Drawing.Size(1345, 160);
            this.oximeterCartesianChart.TabIndex = 11;
            this.oximeterCartesianChart.Text = "Distance";
            // 
            // TemperatureCartesianChart
            // 
            this.TemperatureCartesianChart.Location = new System.Drawing.Point(0, 145);
            this.TemperatureCartesianChart.Name = "TemperatureCartesianChart";
            this.TemperatureCartesianChart.Size = new System.Drawing.Size(1345, 160);
            this.TemperatureCartesianChart.TabIndex = 12;
            this.TemperatureCartesianChart.Text = "Duration";
            // 
            // pictureBoxRefresh
            // 
            this.pictureBoxRefresh.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRefresh.Image")));
            this.pictureBoxRefresh.Location = new System.Drawing.Point(200, 96);
            this.pictureBoxRefresh.Name = "pictureBoxRefresh";
            this.pictureBoxRefresh.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRefresh.TabIndex = 16;
            this.pictureBoxRefresh.TabStop = false;
            this.pictureBoxRefresh.Click += new System.EventHandler(this.pictureBoxRefresh_Click);
            // 
            // dateTimePickerReadingTime
            // 
            this.dateTimePickerReadingTime.CustomFormat = "yyyy-MM-dd hh:mm tt";
            this.dateTimePickerReadingTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerReadingTime.Location = new System.Drawing.Point(657, 23);
            this.dateTimePickerReadingTime.Name = "dateTimePickerReadingTime";
            this.dateTimePickerReadingTime.Size = new System.Drawing.Size(151, 20);
            this.dateTimePickerReadingTime.TabIndex = 17;
            // 
            // listBoxChartUsers
            // 
            this.listBoxChartUsers.Font = new System.Drawing.Font("Consolas", 9.25F, System.Drawing.FontStyle.Bold);
            this.listBoxChartUsers.FormattingEnabled = true;
            this.listBoxChartUsers.ItemHeight = 14;
            this.listBoxChartUsers.Location = new System.Drawing.Point(1265, 23);
            this.listBoxChartUsers.Name = "listBoxChartUsers";
            this.listBoxChartUsers.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxChartUsers.Size = new System.Drawing.Size(67, 88);
            this.listBoxChartUsers.TabIndex = 0;
            // 
            // buttonRefreshUser
            // 
            this.buttonRefreshUser.Location = new System.Drawing.Point(1265, 116);
            this.buttonRefreshUser.Name = "buttonRefreshUser";
            this.buttonRefreshUser.Size = new System.Drawing.Size(67, 23);
            this.buttonRefreshUser.TabIndex = 18;
            this.buttonRefreshUser.Text = "Refresh";
            this.buttonRefreshUser.UseVisualStyleBackColor = true;
            this.buttonRefreshUser.Click += new System.EventHandler(this.buttonRefreshUser_Click);
            // 
            // buttonDB
            // 
            this.buttonDB.Location = new System.Drawing.Point(1228, 116);
            this.buttonDB.Name = "buttonDB";
            this.buttonDB.Size = new System.Drawing.Size(31, 23);
            this.buttonDB.TabIndex = 19;
            this.buttonDB.Text = "DB";
            this.buttonDB.UseVisualStyleBackColor = true;
            this.buttonDB.Click += new System.EventHandler(this.buttonDB_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 661);
            this.Controls.Add(this.buttonDB);
            this.Controls.Add(this.buttonRefreshUser);
            this.Controls.Add(this.dateTimePickerReadingTime);
            this.Controls.Add(this.pictureBoxRefresh);
            this.Controls.Add(this.caloriesLabel);
            this.Controls.Add(this.distanceLabel);
            this.Controls.Add(this.temperatureLabel);
            this.Controls.Add(this.heartrateCartesianChart);
            this.Controls.Add(this.oximeterCartesianChart);
            this.Controls.Add(this.TemperatureCartesianChart);
            this.Controls.Add(this.buttonSave2DB);
            this.Controls.Add(this.dataGridViewUserReadings);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.numericUpDownHeartrate);
            this.Controls.Add(this.numericUpDownOximeter);
            this.Controls.Add(this.numericUpDownTemperature);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxChartUsers);
            this.Controls.Add(this.listBoxUsers);
            this.Name = "Dashboard";
            this.Text = "Covid-19 Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this._Covid_19DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTemperature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOximeter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeartrate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserReadings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRefresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxUsers;
        private System.Windows.Forms.Label label1;
        private _Covid_19DataSet _Covid_19DataSet;
        private System.Windows.Forms.BindingSource userBindingSource;
        private _Covid_19DataSetTableAdapters.UserTableAdapter userTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownTemperature;
        private System.Windows.Forms.NumericUpDown numericUpDownOximeter;
        private System.Windows.Forms.NumericUpDown numericUpDownHeartrate;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.DataGridView dataGridViewUserReadings;
        private System.Windows.Forms.Button buttonSave2DB;
        private System.Windows.Forms.Label caloriesLabel;
        private System.Windows.Forms.Label distanceLabel;
        private System.Windows.Forms.Label temperatureLabel;
        private LiveCharts.WinForms.CartesianChart heartrateCartesianChart;
        private LiveCharts.WinForms.CartesianChart oximeterCartesianChart;
        private LiveCharts.WinForms.CartesianChart TemperatureCartesianChart;
        private System.Windows.Forms.PictureBox pictureBoxRefresh;
        private System.Windows.Forms.DateTimePicker dateTimePickerReadingTime;
        private System.Windows.Forms.ListBox listBoxChartUsers;
        private System.Windows.Forms.Button buttonRefreshUser;
        private System.Windows.Forms.Button buttonDB;
    }
}

