
namespace ScheduleApp
{
    partial class calendarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(calendarForm));
            this.upCancelButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.deleteAppointmentButton = new System.Windows.Forms.Button();
            this.allApptRadio = new System.Windows.Forms.RadioButton();
            this.dayViewRadio = new System.Windows.Forms.RadioButton();
            this.monthRadioButton = new System.Windows.Forms.RadioButton();
            this.weekRadioButton = new System.Windows.Forms.RadioButton();
            this.searchApptButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.appointmentDataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.apptViewLabel = new System.Windows.Forms.Label();
            this.apptTaskLabel = new System.Windows.Forms.Label();
            this.updateApptButton = new System.Windows.Forms.Button();
            this.createApptButton = new System.Windows.Forms.Button();
            this.customerDataButton = new System.Windows.Forms.Button();
            this.bindingWeekList = new System.Windows.Forms.BindingSource(this.components);
            this.bindingMonthList = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingWeekList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingMonthList)).BeginInit();
            this.SuspendLayout();
            // 
            // upCancelButton
            // 
            this.upCancelButton.BackColor = System.Drawing.Color.Black;
            this.upCancelButton.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upCancelButton.ForeColor = System.Drawing.Color.IndianRed;
            this.upCancelButton.Location = new System.Drawing.Point(732, 598);
            this.upCancelButton.Name = "upCancelButton";
            this.upCancelButton.Size = new System.Drawing.Size(183, 80);
            this.upCancelButton.TabIndex = 32;
            this.upCancelButton.Text = "Close";
            this.upCancelButton.UseVisualStyleBackColor = false;
            this.upCancelButton.Click += new System.EventHandler(this.upCancelButton_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.deleteAppointmentButton);
            this.panel1.Controls.Add(this.allApptRadio);
            this.panel1.Controls.Add(this.dayViewRadio);
            this.panel1.Controls.Add(this.monthRadioButton);
            this.panel1.Controls.Add(this.weekRadioButton);
            this.panel1.Controls.Add(this.searchApptButton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.appointmentDataGrid);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.apptViewLabel);
            this.panel1.Controls.Add(this.apptTaskLabel);
            this.panel1.Controls.Add(this.updateApptButton);
            this.panel1.Controls.Add(this.createApptButton);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(905, 579);
            this.panel1.TabIndex = 34;
            // 
            // deleteAppointmentButton
            // 
            this.deleteAppointmentButton.BackColor = System.Drawing.Color.Black;
            this.deleteAppointmentButton.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteAppointmentButton.ForeColor = System.Drawing.Color.IndianRed;
            this.deleteAppointmentButton.Location = new System.Drawing.Point(15, 353);
            this.deleteAppointmentButton.Name = "deleteAppointmentButton";
            this.deleteAppointmentButton.Size = new System.Drawing.Size(157, 60);
            this.deleteAppointmentButton.TabIndex = 60;
            this.deleteAppointmentButton.Text = "Delete";
            this.deleteAppointmentButton.UseVisualStyleBackColor = false;
            this.deleteAppointmentButton.Click += new System.EventHandler(this.deleteAppointmentButton_Click);
            // 
            // allApptRadio
            // 
            this.allApptRadio.AutoSize = true;
            this.allApptRadio.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allApptRadio.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.allApptRadio.Location = new System.Drawing.Point(38, 123);
            this.allApptRadio.Name = "allApptRadio";
            this.allApptRadio.Size = new System.Drawing.Size(139, 20);
            this.allApptRadio.TabIndex = 59;
            this.allApptRadio.TabStop = true;
            this.allApptRadio.Text = "All Appointments";
            this.allApptRadio.UseVisualStyleBackColor = true;
            // 
            // dayViewRadio
            // 
            this.dayViewRadio.AutoSize = true;
            this.dayViewRadio.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayViewRadio.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.dayViewRadio.Location = new System.Drawing.Point(38, 45);
            this.dayViewRadio.Name = "dayViewRadio";
            this.dayViewRadio.Size = new System.Drawing.Size(110, 20);
            this.dayViewRadio.TabIndex = 58;
            this.dayViewRadio.Text = "Selected Day";
            this.dayViewRadio.UseVisualStyleBackColor = true;
            this.dayViewRadio.CheckedChanged += new System.EventHandler(this.dayViewRadio_CheckedChanged);
            // 
            // monthRadioButton
            // 
            this.monthRadioButton.AutoSize = true;
            this.monthRadioButton.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthRadioButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.monthRadioButton.Location = new System.Drawing.Point(38, 97);
            this.monthRadioButton.Name = "monthRadioButton";
            this.monthRadioButton.Size = new System.Drawing.Size(120, 20);
            this.monthRadioButton.TabIndex = 57;
            this.monthRadioButton.TabStop = true;
            this.monthRadioButton.Text = "Current Month";
            this.monthRadioButton.UseVisualStyleBackColor = true;
            this.monthRadioButton.CheckedChanged += new System.EventHandler(this.monthRadioButton_CheckedChanged);
            // 
            // weekRadioButton
            // 
            this.weekRadioButton.AutoSize = true;
            this.weekRadioButton.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weekRadioButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.weekRadioButton.Location = new System.Drawing.Point(38, 71);
            this.weekRadioButton.Name = "weekRadioButton";
            this.weekRadioButton.Size = new System.Drawing.Size(115, 20);
            this.weekRadioButton.TabIndex = 56;
            this.weekRadioButton.Text = "Current Week";
            this.weekRadioButton.UseVisualStyleBackColor = true;
            this.weekRadioButton.CheckedChanged += new System.EventHandler(this.weekRadioButton_CheckedChanged);
            // 
            // searchApptButton
            // 
            this.searchApptButton.BackColor = System.Drawing.Color.Black;
            this.searchApptButton.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchApptButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.searchApptButton.Location = new System.Drawing.Point(776, 32);
            this.searchApptButton.Name = "searchApptButton";
            this.searchApptButton.Size = new System.Drawing.Size(123, 33);
            this.searchApptButton.TabIndex = 55;
            this.searchApptButton.Text = "Search";
            this.searchApptButton.UseVisualStyleBackColor = false;
            this.searchApptButton.Click += new System.EventHandler(this.searchApptButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(644, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 54;
            this.label2.Text = "Customer ID ";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(742, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 26);
            this.textBox1.TabIndex = 53;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(169, 38);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(296, 29);
            this.dateTimePicker1.TabIndex = 52;
            // 
            // appointmentDataGrid
            // 
            this.appointmentDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appointmentDataGrid.Location = new System.Drawing.Point(230, 167);
            this.appointmentDataGrid.MultiSelect = false;
            this.appointmentDataGrid.Name = "appointmentDataGrid";
            this.appointmentDataGrid.Size = new System.Drawing.Size(669, 380);
            this.appointmentDataGrid.TabIndex = 51;
            this.appointmentDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.appointmentDataGrid_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(477, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 34);
            this.label1.TabIndex = 50;
            this.label1.Text = "Appointment List ";
            // 
            // apptViewLabel
            // 
            this.apptViewLabel.AutoSize = true;
            this.apptViewLabel.Font = new System.Drawing.Font("Myanmar Text", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apptViewLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.apptViewLabel.Location = new System.Drawing.Point(14, 8);
            this.apptViewLabel.Name = "apptViewLabel";
            this.apptViewLabel.Size = new System.Drawing.Size(182, 34);
            this.apptViewLabel.TabIndex = 40;
            this.apptViewLabel.Text = "Appointment View";
            // 
            // apptTaskLabel
            // 
            this.apptTaskLabel.AutoSize = true;
            this.apptTaskLabel.Font = new System.Drawing.Font("Myanmar Text", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apptTaskLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.apptTaskLabel.Location = new System.Drawing.Point(9, 149);
            this.apptTaskLabel.Name = "apptTaskLabel";
            this.apptTaskLabel.Size = new System.Drawing.Size(187, 34);
            this.apptTaskLabel.TabIndex = 49;
            this.apptTaskLabel.Text = "Appointment Tasks";
            this.apptTaskLabel.Click += new System.EventHandler(this.apptTaskLabel_Click);
            // 
            // updateApptButton
            // 
            this.updateApptButton.BackColor = System.Drawing.Color.Black;
            this.updateApptButton.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateApptButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.updateApptButton.Location = new System.Drawing.Point(19, 186);
            this.updateApptButton.Name = "updateApptButton";
            this.updateApptButton.Size = new System.Drawing.Size(162, 60);
            this.updateApptButton.TabIndex = 41;
            this.updateApptButton.Text = "Update Appt";
            this.updateApptButton.UseVisualStyleBackColor = false;
            this.updateApptButton.Click += new System.EventHandler(this.updateApptButton_Click);
            // 
            // createApptButton
            // 
            this.createApptButton.BackColor = System.Drawing.Color.Black;
            this.createApptButton.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createApptButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.createApptButton.Location = new System.Drawing.Point(15, 267);
            this.createApptButton.Name = "createApptButton";
            this.createApptButton.Size = new System.Drawing.Size(162, 60);
            this.createApptButton.TabIndex = 43;
            this.createApptButton.Text = "Create Appt";
            this.createApptButton.UseVisualStyleBackColor = false;
            this.createApptButton.Click += new System.EventHandler(this.createApptButton_Click);
            // 
            // customerDataButton
            // 
            this.customerDataButton.BackColor = System.Drawing.Color.Black;
            this.customerDataButton.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerDataButton.ForeColor = System.Drawing.Color.IndianRed;
            this.customerDataButton.Location = new System.Drawing.Point(16, 598);
            this.customerDataButton.Name = "customerDataButton";
            this.customerDataButton.Size = new System.Drawing.Size(189, 80);
            this.customerDataButton.TabIndex = 48;
            this.customerDataButton.Text = " Customer Information ";
            this.customerDataButton.UseVisualStyleBackColor = false;
            this.customerDataButton.Click += new System.EventHandler(this.customerDataButton_Click);
            // 
            // bindingWeekList
            // 
            this.bindingWeekList.CurrentChanged += new System.EventHandler(this.bindingWeekList_CurrentChanged);
            // 
            // bindingMonthList
            // 
            this.bindingMonthList.CurrentChanged += new System.EventHandler(this.bindingMonthList_CurrentChanged);
            // 
            // calendarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(927, 690);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.upCancelButton);
            this.Controls.Add(this.customerDataButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "calendarForm";
            this.Text = "Calendar";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingWeekList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingMonthList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button upCancelButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource bindingWeekList;
        private System.Windows.Forms.Label apptViewLabel;
        private System.Windows.Forms.BindingSource bindingMonthList;
        private System.Windows.Forms.Button createApptButton;
        private System.Windows.Forms.Button updateApptButton;
        private System.Windows.Forms.Button customerDataButton;
        private System.Windows.Forms.Label apptTaskLabel;
        private System.Windows.Forms.RadioButton monthRadioButton;
        private System.Windows.Forms.RadioButton weekRadioButton;
        private System.Windows.Forms.Button searchApptButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView appointmentDataGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton dayViewRadio;
        private System.Windows.Forms.RadioButton allApptRadio;
        private System.Windows.Forms.Button deleteAppointmentButton;
    }
}