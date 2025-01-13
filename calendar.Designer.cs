
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(calendarForm));
            this.upCancelButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.apptViewLabel = new System.Windows.Forms.Label();
            this.allRadioButton = new System.Windows.Forms.RadioButton();
            this.dayRadioButton = new System.Windows.Forms.RadioButton();
            this.monthRadioButton = new System.Windows.Forms.RadioButton();
            this.weekRadioButton = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.appointmentDataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.apptTaskLabel = new System.Windows.Forms.Label();
            this.deleteAppointmentButton = new System.Windows.Forms.Button();
            this.updateApptButton = new System.Windows.Forms.Button();
            this.createApptButton = new System.Windows.Forms.Button();
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
            this.upCancelButton.Font = new System.Drawing.Font("Myanmar Text", 12.75F, System.Drawing.FontStyle.Bold);
            this.upCancelButton.ForeColor = System.Drawing.Color.IndianRed;
            this.upCancelButton.Location = new System.Drawing.Point(1110, 581);
            this.upCancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.upCancelButton.Name = "upCancelButton";
            this.upCancelButton.Size = new System.Drawing.Size(213, 74);
            this.upCancelButton.TabIndex = 32;
            this.upCancelButton.Text = "Close";
            this.upCancelButton.UseVisualStyleBackColor = false;
            this.upCancelButton.Click += new System.EventHandler(this.upCancelButton_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.apptViewLabel);
            this.panel1.Controls.Add(this.allRadioButton);
            this.panel1.Controls.Add(this.dayRadioButton);
            this.panel1.Controls.Add(this.monthRadioButton);
            this.panel1.Controls.Add(this.weekRadioButton);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.appointmentDataGrid);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.apptTaskLabel);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1310, 560);
            this.panel1.TabIndex = 34;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // apptViewLabel
            // 
            this.apptViewLabel.AutoSize = true;
            this.apptViewLabel.Font = new System.Drawing.Font("Myanmar Text", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apptViewLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.apptViewLabel.Location = new System.Drawing.Point(4, 9);
            this.apptViewLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.apptViewLabel.Name = "apptViewLabel";
            this.apptViewLabel.Size = new System.Drawing.Size(203, 34);
            this.apptViewLabel.TabIndex = 40;
            this.apptViewLabel.Text = "Appointment Display";
            this.apptViewLabel.Click += new System.EventHandler(this.apptViewLabel_Click);
            // 
            // allRadioButton
            // 
            this.allRadioButton.AutoSize = true;
            this.allRadioButton.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allRadioButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.allRadioButton.Location = new System.Drawing.Point(4, 272);
            this.allRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.allRadioButton.Name = "allRadioButton";
            this.allRadioButton.Size = new System.Drawing.Size(139, 20);
            this.allRadioButton.TabIndex = 59;
            this.allRadioButton.TabStop = true;
            this.allRadioButton.Text = "All Appointments";
            this.allRadioButton.UseVisualStyleBackColor = true;
            this.allRadioButton.CheckedChanged += new System.EventHandler(this.allApptRadio_CheckedChanged);
            // 
            // dayRadioButton
            // 
            this.dayRadioButton.AutoSize = true;
            this.dayRadioButton.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayRadioButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.dayRadioButton.Location = new System.Drawing.Point(4, 55);
            this.dayRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.dayRadioButton.Name = "dayRadioButton";
            this.dayRadioButton.Size = new System.Drawing.Size(110, 20);
            this.dayRadioButton.TabIndex = 58;
            this.dayRadioButton.Text = "Selected Day";
            this.dayRadioButton.UseVisualStyleBackColor = true;
            this.dayRadioButton.CheckedChanged += new System.EventHandler(this.dayViewRadio_CheckedChanged);
            // 
            // monthRadioButton
            // 
            this.monthRadioButton.AutoSize = true;
            this.monthRadioButton.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthRadioButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.monthRadioButton.Location = new System.Drawing.Point(4, 207);
            this.monthRadioButton.Margin = new System.Windows.Forms.Padding(4);
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
            this.weekRadioButton.Location = new System.Drawing.Point(4, 148);
            this.weekRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.weekRadioButton.Name = "weekRadioButton";
            this.weekRadioButton.Size = new System.Drawing.Size(115, 20);
            this.weekRadioButton.TabIndex = 56;
            this.weekRadioButton.Text = "Current Week";
            this.weekRadioButton.UseVisualStyleBackColor = true;
            this.weekRadioButton.CheckedChanged += new System.EventHandler(this.weekRadioButton_CheckedChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Cambria Math", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(27, 87);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(159, 26);
            this.dateTimePicker1.TabIndex = 52;
            this.dateTimePicker1.Value = new System.DateTime(2024, 11, 19, 0, 22, 52, 344);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // appointmentDataGrid
            // 
            this.appointmentDataGrid.AllowUserToResizeColumns = false;
            this.appointmentDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.appointmentDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.appointmentDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.appointmentDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.appointmentDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.appointmentDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.appointmentDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.appointmentDataGrid.Location = new System.Drawing.Point(209, 47);
            this.appointmentDataGrid.Margin = new System.Windows.Forms.Padding(4);
            this.appointmentDataGrid.Name = "appointmentDataGrid";
            this.appointmentDataGrid.ReadOnly = true;
            this.appointmentDataGrid.RowHeadersWidth = 62;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.appointmentDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.appointmentDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.appointmentDataGrid.Size = new System.Drawing.Size(1097, 435);
            this.appointmentDataGrid.TabIndex = 51;
            this.appointmentDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.appointmentDataGrid_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(709, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 34);
            this.label1.TabIndex = 50;
            this.label1.Text = "Appointment List ";
            // 
            // apptTaskLabel
            // 
            this.apptTaskLabel.AutoSize = true;
            this.apptTaskLabel.Font = new System.Drawing.Font("Myanmar Text", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apptTaskLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.apptTaskLabel.Location = new System.Drawing.Point(209, 526);
            this.apptTaskLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.apptTaskLabel.Name = "apptTaskLabel";
            this.apptTaskLabel.Size = new System.Drawing.Size(187, 34);
            this.apptTaskLabel.TabIndex = 49;
            this.apptTaskLabel.Text = "Appointment Tasks";
            this.apptTaskLabel.Click += new System.EventHandler(this.apptTaskLabel_Click);
            // 
            // deleteAppointmentButton
            // 
            this.deleteAppointmentButton.BackColor = System.Drawing.Color.Black;
            this.deleteAppointmentButton.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteAppointmentButton.ForeColor = System.Drawing.Color.IndianRed;
            this.deleteAppointmentButton.Location = new System.Drawing.Point(11, 590);
            this.deleteAppointmentButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteAppointmentButton.Name = "deleteAppointmentButton";
            this.deleteAppointmentButton.Size = new System.Drawing.Size(209, 74);
            this.deleteAppointmentButton.TabIndex = 60;
            this.deleteAppointmentButton.Text = "Delete";
            this.deleteAppointmentButton.UseVisualStyleBackColor = false;
            this.deleteAppointmentButton.Click += new System.EventHandler(this.deleteAppointmentButton_Click);
            // 
            // updateApptButton
            // 
            this.updateApptButton.BackColor = System.Drawing.Color.Black;
            this.updateApptButton.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateApptButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.updateApptButton.Location = new System.Drawing.Point(225, 590);
            this.updateApptButton.Margin = new System.Windows.Forms.Padding(4);
            this.updateApptButton.Name = "updateApptButton";
            this.updateApptButton.Size = new System.Drawing.Size(216, 74);
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
            this.createApptButton.Location = new System.Drawing.Point(446, 590);
            this.createApptButton.Margin = new System.Windows.Forms.Padding(4);
            this.createApptButton.Name = "createApptButton";
            this.createApptButton.Size = new System.Drawing.Size(216, 74);
            this.createApptButton.TabIndex = 43;
            this.createApptButton.Text = "Create Appt";
            this.createApptButton.UseVisualStyleBackColor = false;
            this.createApptButton.Click += new System.EventHandler(this.createApptButton_Click);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1333, 673);
            this.Controls.Add(this.deleteAppointmentButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.upCancelButton);
            this.Controls.Add(this.updateApptButton);
            this.Controls.Add(this.createApptButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "calendarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Username Disply";
            this.Load += new System.EventHandler(this.calendarForm_Load);
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
        private System.Windows.Forms.Label apptTaskLabel;
        private System.Windows.Forms.RadioButton monthRadioButton;
        private System.Windows.Forms.RadioButton weekRadioButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView appointmentDataGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton dayRadioButton;
        private System.Windows.Forms.RadioButton allRadioButton;
        private System.Windows.Forms.Button deleteAppointmentButton;
    }
}