
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
            this.apptViewLabel = new System.Windows.Forms.Label();
            this.apptTaskLabel = new System.Windows.Forms.Label();
            this.customerDataButton = new System.Windows.Forms.Button();
            this.updateApptButton = new System.Windows.Forms.Button();
            this.createApptButton = new System.Windows.Forms.Button();
            this.bindingWeekList = new System.Windows.Forms.BindingSource(this.components);
            this.bindingMonthList = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.appointmentDataGrid = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.searchApptButton = new System.Windows.Forms.Button();
            this.weekRadioButton = new System.Windows.Forms.RadioButton();
            this.monthRadioButton = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingWeekList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingMonthList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // upCancelButton
            // 
            this.upCancelButton.BackColor = System.Drawing.Color.Black;
            this.upCancelButton.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upCancelButton.ForeColor = System.Drawing.Color.IndianRed;
            this.upCancelButton.Location = new System.Drawing.Point(740, 645);
            this.upCancelButton.Name = "upCancelButton";
            this.upCancelButton.Size = new System.Drawing.Size(123, 60);
            this.upCancelButton.TabIndex = 32;
            this.upCancelButton.Text = "Close";
            this.upCancelButton.UseVisualStyleBackColor = false;
            this.upCancelButton.Click += new System.EventHandler(this.upCancelButton_Click);
            // 
            // panel1
            // 
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
            this.panel1.Size = new System.Drawing.Size(850, 611);
            this.panel1.TabIndex = 34;
            // 
            // apptViewLabel
            // 
            this.apptViewLabel.AutoSize = true;
            this.apptViewLabel.Font = new System.Drawing.Font("Myanmar Text", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apptViewLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.apptViewLabel.Location = new System.Drawing.Point(274, 477);
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
            this.apptTaskLabel.Location = new System.Drawing.Point(8, 77);
            this.apptTaskLabel.Name = "apptTaskLabel";
            this.apptTaskLabel.Size = new System.Drawing.Size(187, 34);
            this.apptTaskLabel.TabIndex = 49;
            this.apptTaskLabel.Text = "Appointment Tasks";
            this.apptTaskLabel.Click += new System.EventHandler(this.apptTaskLabel_Click);
            // 
            // customerDataButton
            // 
            this.customerDataButton.BackColor = System.Drawing.Color.Black;
            this.customerDataButton.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerDataButton.ForeColor = System.Drawing.Color.IndianRed;
            this.customerDataButton.Location = new System.Drawing.Point(13, 644);
            this.customerDataButton.Name = "customerDataButton";
            this.customerDataButton.Size = new System.Drawing.Size(378, 60);
            this.customerDataButton.TabIndex = 48;
            this.customerDataButton.Text = " Customer Information ";
            this.customerDataButton.UseVisualStyleBackColor = false;
            this.customerDataButton.Click += new System.EventHandler(this.customerDataButton_Click);
            // 
            // updateApptButton
            // 
            this.updateApptButton.BackColor = System.Drawing.Color.Black;
            this.updateApptButton.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateApptButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.updateApptButton.Location = new System.Drawing.Point(14, 134);
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
            this.createApptButton.Location = new System.Drawing.Point(14, 227);
            this.createApptButton.Name = "createApptButton";
            this.createApptButton.Size = new System.Drawing.Size(162, 60);
            this.createApptButton.TabIndex = 43;
            this.createApptButton.Text = "Create Appt";
            this.createApptButton.UseVisualStyleBackColor = false;
            this.createApptButton.Click += new System.EventHandler(this.createApptButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(433, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 34);
            this.label1.TabIndex = 50;
            this.label1.Text = "Appointment List ";
            // 
            // appointmentDataGrid
            // 
            this.appointmentDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appointmentDataGrid.Location = new System.Drawing.Point(201, 77);
            this.appointmentDataGrid.Name = "appointmentDataGrid";
            this.appointmentDataGrid.Size = new System.Drawing.Size(633, 380);
            this.appointmentDataGrid.TabIndex = 51;
            this.appointmentDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.appointmentDataGrid_CellContentClick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(542, 516);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(292, 29);
            this.dateTimePicker1.TabIndex = 52;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(674, 477);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 26);
            this.textBox1.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(576, 480);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 54;
            this.label2.Text = "Customer ID ";
            // 
            // searchApptButton
            // 
            this.searchApptButton.BackColor = System.Drawing.Color.Black;
            this.searchApptButton.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchApptButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.searchApptButton.Location = new System.Drawing.Point(686, 551);
            this.searchApptButton.Name = "searchApptButton";
            this.searchApptButton.Size = new System.Drawing.Size(150, 57);
            this.searchApptButton.TabIndex = 55;
            this.searchApptButton.Text = "Search";
            this.searchApptButton.UseVisualStyleBackColor = false;
            this.searchApptButton.Click += new System.EventHandler(this.searchApptButton_Click);
            // 
            // weekRadioButton
            // 
            this.weekRadioButton.AutoSize = true;
            this.weekRadioButton.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weekRadioButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.weekRadioButton.Location = new System.Drawing.Point(280, 515);
            this.weekRadioButton.Name = "weekRadioButton";
            this.weekRadioButton.Size = new System.Drawing.Size(102, 20);
            this.weekRadioButton.TabIndex = 56;
            this.weekRadioButton.Text = "Week View";
            this.weekRadioButton.UseVisualStyleBackColor = true;
            this.weekRadioButton.CheckedChanged += new System.EventHandler(this.weekRadioButton_CheckedChanged);
            // 
            // monthRadioButton
            // 
            this.monthRadioButton.AutoSize = true;
            this.monthRadioButton.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthRadioButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.monthRadioButton.Location = new System.Drawing.Point(280, 551);
            this.monthRadioButton.Name = "monthRadioButton";
            this.monthRadioButton.Size = new System.Drawing.Size(107, 20);
            this.monthRadioButton.TabIndex = 57;
            this.monthRadioButton.TabStop = true;
            this.monthRadioButton.Text = "Month View";
            this.monthRadioButton.UseVisualStyleBackColor = true;
            this.monthRadioButton.CheckedChanged += new System.EventHandler(this.monthRadioButton_CheckedChanged);
            // 
            // calendarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(875, 717);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.upCancelButton);
            this.Controls.Add(this.customerDataButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "calendarForm";
            this.Text = "Calendar";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingWeekList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingMonthList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDataGrid)).EndInit();
            this.ResumeLayout(false);

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
    }
}