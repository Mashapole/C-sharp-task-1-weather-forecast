namespace Assignment1
{
    partial class Multiple_Selection
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.lsbCities = new System.Windows.Forms.ListBox();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.rtbReport = new System.Windows.Forms.RichTextBox();
            this.rtbHighestAndLowest = new System.Windows.Forms.RichTextBox();
            this.grpMultiple = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.grpMultiple.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDisplay);
            this.panel1.Controls.Add(this.dtpStart);
            this.panel1.Controls.Add(this.dtpEnd);
            this.panel1.Controls.Add(this.lsbCities);
            this.panel1.Controls.Add(this.lblStart);
            this.panel1.Controls.Add(this.lblEnd);
            this.panel1.Controls.Add(this.lblCity);
            this.panel1.Location = new System.Drawing.Point(18, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 204);
            this.panel1.TabIndex = 0;
            // 
            // btnDisplay
            // 
            this.btnDisplay.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplay.Location = new System.Drawing.Point(109, 157);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(157, 35);
            this.btnDisplay.TabIndex = 7;
            this.btnDisplay.Text = "View Report";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(651, 375);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(148, 40);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dtpStart
            // 
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Location = new System.Drawing.Point(109, 92);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(157, 20);
            this.dtpStart.TabIndex = 5;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnd.Location = new System.Drawing.Point(109, 118);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(157, 20);
            this.dtpEnd.TabIndex = 4;
            // 
            // lsbCities
            // 
            this.lsbCities.FormattingEnabled = true;
            this.lsbCities.Location = new System.Drawing.Point(109, 8);
            this.lsbCities.Name = "lsbCities";
            this.lsbCities.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lsbCities.Size = new System.Drawing.Size(157, 69);
            this.lsbCities.TabIndex = 3;
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.Location = new System.Drawing.Point(8, 92);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(62, 20);
            this.lblStart.TabIndex = 2;
            this.lblStart.Text = "Start Date:";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnd.Location = new System.Drawing.Point(8, 125);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(55, 20);
            this.lblEnd.TabIndex = 1;
            this.lblEnd.Text = "End Date:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(8, 21);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(33, 20);
            this.lblCity.TabIndex = 0;
            this.lblCity.Text = "City:";
            // 
            // rtbReport
            // 
            this.rtbReport.Location = new System.Drawing.Point(422, 25);
            this.rtbReport.Name = "rtbReport";
            this.rtbReport.Size = new System.Drawing.Size(377, 195);
            this.rtbReport.TabIndex = 9;
            this.rtbReport.Text = "";
            // 
            // rtbHighestAndLowest
            // 
            this.rtbHighestAndLowest.Location = new System.Drawing.Point(422, 226);
            this.rtbHighestAndLowest.Name = "rtbHighestAndLowest";
            this.rtbHighestAndLowest.Size = new System.Drawing.Size(377, 133);
            this.rtbHighestAndLowest.TabIndex = 8;
            this.rtbHighestAndLowest.Text = "";
            // 
            // grpMultiple
            // 
            this.grpMultiple.Controls.Add(this.panel1);
            this.grpMultiple.Location = new System.Drawing.Point(54, 25);
            this.grpMultiple.Name = "grpMultiple";
            this.grpMultiple.Size = new System.Drawing.Size(323, 259);
            this.grpMultiple.TabIndex = 10;
            this.grpMultiple.TabStop = false;
            this.grpMultiple.Text = "Multiple Selection Cities";
            // 
            // Multiple_Selection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Violet;
            this.ClientSize = new System.Drawing.Size(811, 427);
            this.Controls.Add(this.grpMultiple);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.rtbHighestAndLowest);
            this.Controls.Add(this.rtbReport);
            this.Name = "Multiple_Selection";
            this.Text = "Multiple_Selection";
            this.Load += new System.EventHandler(this.Multiple_Selection_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpMultiple.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.ListBox lsbCities;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.RichTextBox rtbReport;
        private System.Windows.Forms.RichTextBox rtbHighestAndLowest;
        private System.Windows.Forms.GroupBox grpMultiple;
    }
}