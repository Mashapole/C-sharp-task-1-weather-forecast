namespace Assignment1
{
    partial class Single_City_Search
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.dTPEndDate = new System.Windows.Forms.DateTimePicker();
            this.dTPStartDate = new System.Windows.Forms.DateTimePicker();
            this.CMBCity = new System.Windows.Forms.ComboBox();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.rTbCityReport = new System.Windows.Forms.RichTextBox();
            this.btnView = new System.Windows.Forms.Button();
            this.lblStartAndEnd = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtp_StartDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpDate = new System.Windows.Forms.GroupBox();
            this.grpSingleCity = new System.Windows.Forms.GroupBox();
            this.rtfSingleCity = new System.Windows.Forms.RichTextBox();
            this.btnClearButton = new System.Windows.Forms.Button();
            this.btnClearField = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.grpDate.SuspendLayout();
            this.grpSingleCity.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDisplay);
            this.panel1.Controls.Add(this.dTPEndDate);
            this.panel1.Controls.Add(this.dTPStartDate);
            this.panel1.Controls.Add(this.CMBCity);
            this.panel1.Controls.Add(this.lblEndDate);
            this.panel1.Controls.Add(this.lblStartDate);
            this.panel1.Controls.Add(this.lblCity);
            this.panel1.Location = new System.Drawing.Point(72, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 161);
            this.panel1.TabIndex = 0;
            // 
            // btnDisplay
            // 
            this.btnDisplay.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplay.Location = new System.Drawing.Point(100, 126);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(156, 32);
            this.btnDisplay.TabIndex = 8;
            this.btnDisplay.Text = "View Report";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(12, 504);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(119, 39);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dTPEndDate
            // 
            this.dTPEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTPEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPEndDate.Location = new System.Drawing.Point(100, 76);
            this.dTPEndDate.Name = "dTPEndDate";
            this.dTPEndDate.Size = new System.Drawing.Size(156, 20);
            this.dTPEndDate.TabIndex = 5;
            // 
            // dTPStartDate
            // 
            this.dTPStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTPStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPStartDate.Location = new System.Drawing.Point(100, 46);
            this.dTPStartDate.Name = "dTPStartDate";
            this.dTPStartDate.Size = new System.Drawing.Size(156, 20);
            this.dTPStartDate.TabIndex = 4;
            // 
            // CMBCity
            // 
            this.CMBCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMBCity.FormattingEnabled = true;
            this.CMBCity.Location = new System.Drawing.Point(100, 11);
            this.CMBCity.Name = "CMBCity";
            this.CMBCity.Size = new System.Drawing.Size(156, 21);
            this.CMBCity.TabIndex = 3;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(27, 83);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(72, 16);
            this.lblEndDate.TabIndex = 2;
            this.lblEndDate.Text = "End Date";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(24, 53);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(77, 16);
            this.lblStartDate.TabIndex = 1;
            this.lblStartDate.Text = "Start Date";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(24, 19);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(38, 16);
            this.lblCity.TabIndex = 0;
            this.lblCity.Text = "City:";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(617, 504);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 39);
            this.button2.TabIndex = 7;
            this.button2.Text = "Continue";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // rTbCityReport
            // 
            this.rTbCityReport.Location = new System.Drawing.Point(12, 240);
            this.rTbCityReport.Name = "rTbCityReport";
            this.rTbCityReport.Size = new System.Drawing.Size(363, 213);
            this.rTbCityReport.TabIndex = 1;
            this.rTbCityReport.Text = "";
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(23, 145);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(228, 32);
            this.btnView.TabIndex = 10;
            this.btnView.Text = "View Report ";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // lblStartAndEnd
            // 
            this.lblStartAndEnd.AutoSize = true;
            this.lblStartAndEnd.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartAndEnd.Location = new System.Drawing.Point(101, 22);
            this.lblStartAndEnd.Name = "lblStartAndEnd";
            this.lblStartAndEnd.Size = new System.Drawing.Size(147, 20);
            this.lblStartAndEnd.TabIndex = 9;
            this.lblStartAndEnd.Text = "Search By Specifying Date:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtpEnd);
            this.panel2.Controls.Add(this.dtp_StartDate);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(23, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(228, 87);
            this.panel2.TabIndex = 8;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnd.Location = new System.Drawing.Point(81, 53);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(128, 20);
            this.dtpEnd.TabIndex = 3;
            // 
            // dtp_StartDate
            // 
            this.dtp_StartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_StartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_StartDate.Location = new System.Drawing.Point(84, 16);
            this.dtp_StartDate.Name = "dtp_StartDate";
            this.dtp_StartDate.Size = new System.Drawing.Size(125, 20);
            this.dtp_StartDate.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "End Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Start Date:";
            // 
            // grpDate
            // 
            this.grpDate.Controls.Add(this.panel2);
            this.grpDate.Controls.Add(this.lblStartAndEnd);
            this.grpDate.Controls.Add(this.btnView);
            this.grpDate.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDate.Location = new System.Drawing.Point(3, 12);
            this.grpDate.Name = "grpDate";
            this.grpDate.Size = new System.Drawing.Size(372, 197);
            this.grpDate.TabIndex = 11;
            this.grpDate.TabStop = false;
            this.grpDate.Text = "Data Search";
            // 
            // grpSingleCity
            // 
            this.grpSingleCity.Controls.Add(this.panel1);
            this.grpSingleCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSingleCity.Location = new System.Drawing.Point(392, 12);
            this.grpSingleCity.Name = "grpSingleCity";
            this.grpSingleCity.Size = new System.Drawing.Size(368, 197);
            this.grpSingleCity.TabIndex = 12;
            this.grpSingleCity.TabStop = false;
            this.grpSingleCity.Text = "Select City And  Start Date And also End Date";
            // 
            // rtfSingleCity
            // 
            this.rtfSingleCity.Location = new System.Drawing.Point(392, 240);
            this.rtfSingleCity.Name = "rtfSingleCity";
            this.rtfSingleCity.Size = new System.Drawing.Size(368, 213);
            this.rtfSingleCity.TabIndex = 13;
            this.rtfSingleCity.Text = "";
            // 
            // btnClearButton
            // 
            this.btnClearButton.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearButton.Location = new System.Drawing.Point(617, 459);
            this.btnClearButton.Name = "btnClearButton";
            this.btnClearButton.Size = new System.Drawing.Size(143, 39);
            this.btnClearButton.TabIndex = 14;
            this.btnClearButton.Text = "Clear Field";
            this.btnClearButton.UseVisualStyleBackColor = true;
            this.btnClearButton.Click += new System.EventHandler(this.btnClearButton_Click);
            // 
            // btnClearField
            // 
            this.btnClearField.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearField.Location = new System.Drawing.Point(12, 459);
            this.btnClearField.Name = "btnClearField";
            this.btnClearField.Size = new System.Drawing.Size(119, 39);
            this.btnClearField.TabIndex = 15;
            this.btnClearField.Text = "Clear Field";
            this.btnClearField.UseVisualStyleBackColor = true;
            this.btnClearField.Click += new System.EventHandler(this.btnClearField_Click);
            // 
            // Single_City_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Violet;
            this.ClientSize = new System.Drawing.Size(779, 548);
            this.Controls.Add(this.btnClearField);
            this.Controls.Add(this.btnClearButton);
            this.Controls.Add(this.rtfSingleCity);
            this.Controls.Add(this.grpSingleCity);
            this.Controls.Add(this.grpDate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.rTbCityReport);
            this.Controls.Add(this.button2);
            this.Name = "Single_City_Search";
            this.Text = "ComparingApplication";
            this.Load += new System.EventHandler(this.ComparingApplication_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.grpDate.ResumeLayout(false);
            this.grpDate.PerformLayout();
            this.grpSingleCity.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DateTimePicker dTPEndDate;
        private System.Windows.Forms.DateTimePicker dTPStartDate;
        private System.Windows.Forms.ComboBox CMBCity;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox rTbCityReport;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Label lblStartAndEnd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtp_StartDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpDate;
        private System.Windows.Forms.GroupBox grpSingleCity;
        private System.Windows.Forms.RichTextBox rtfSingleCity;
        private System.Windows.Forms.Button btnClearButton;
        private System.Windows.Forms.Button btnClearField;
    }
}