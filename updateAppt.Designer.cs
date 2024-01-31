
namespace ScheduleApp
{
    partial class updateAppt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(updateAppt));
            this.upApptCancelB = new System.Windows.Forms.Button();
            this.updateApptButton = new System.Windows.Forms.Button();
            this.dateTimeUpdate2 = new System.Windows.Forms.DateTimePicker();
            this.dateTime = new System.Windows.Forms.Label();
            this.upApptTypeBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.upfnLabel = new System.Windows.Forms.Label();
            this.UplnameInput = new System.Windows.Forms.TextBox();
            this.uplnLabel = new System.Windows.Forms.Label();
            this.UpfnameInput = new System.Windows.Forms.TextBox();
            this.UpcustIdInput = new System.Windows.Forms.TextBox();
            this.upCustomerIDLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // upApptCancelB
            // 
            this.upApptCancelB.BackColor = System.Drawing.Color.Black;
            this.upApptCancelB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upApptCancelB.ForeColor = System.Drawing.Color.IndianRed;
            this.upApptCancelB.Location = new System.Drawing.Point(243, 308);
            this.upApptCancelB.Name = "upApptCancelB";
            this.upApptCancelB.Size = new System.Drawing.Size(123, 60);
            this.upApptCancelB.TabIndex = 63;
            this.upApptCancelB.Text = "CANCEL";
            this.upApptCancelB.UseVisualStyleBackColor = false;
            this.upApptCancelB.Click += new System.EventHandler(this.upCancelButton_Click);
            // 
            // updateApptButton
            // 
            this.updateApptButton.BackColor = System.Drawing.Color.Black;
            this.updateApptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateApptButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.updateApptButton.Location = new System.Drawing.Point(36, 308);
            this.updateApptButton.Name = "updateApptButton";
            this.updateApptButton.Size = new System.Drawing.Size(123, 60);
            this.updateApptButton.TabIndex = 62;
            this.updateApptButton.Text = "UPDATE";
            this.updateApptButton.UseVisualStyleBackColor = false;
            this.updateApptButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // dateTimeUpdate2
            // 
            this.dateTimeUpdate2.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeUpdate2.Location = new System.Drawing.Point(94, 225);
            this.dateTimeUpdate2.Name = "dateTimeUpdate2";
            this.dateTimeUpdate2.Size = new System.Drawing.Size(262, 35);
            this.dateTimeUpdate2.TabIndex = 61;
            this.dateTimeUpdate2.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTime
            // 
            this.dateTime.AutoSize = true;
            this.dateTime.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime.ForeColor = System.Drawing.Color.Gainsboro;
            this.dateTime.Location = new System.Drawing.Point(8, 230);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(61, 29);
            this.dateTime.TabIndex = 60;
            this.dateTime.Text = "Date : ";
            this.dateTime.Click += new System.EventHandler(this.dateTime_Click);
            // 
            // upApptTypeBox
            // 
            this.upApptTypeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upApptTypeBox.Location = new System.Drawing.Point(178, 174);
            this.upApptTypeBox.Name = "upApptTypeBox";
            this.upApptTypeBox.Size = new System.Drawing.Size(178, 22);
            this.upApptTypeBox.TabIndex = 59;
            this.upApptTypeBox.TextChanged += new System.EventHandler(this.apptTypeBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(8, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 29);
            this.label1.TabIndex = 58;
            this.label1.Text = "Appointment Type :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // upfnLabel
            // 
            this.upfnLabel.AutoSize = true;
            this.upfnLabel.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upfnLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.upfnLabel.Location = new System.Drawing.Point(12, 80);
            this.upfnLabel.Name = "upfnLabel";
            this.upfnLabel.Size = new System.Drawing.Size(97, 27);
            this.upfnLabel.TabIndex = 54;
            this.upfnLabel.Text = "First Name :";
            this.upfnLabel.Click += new System.EventHandler(this.upfnLabel_Click);
            // 
            // UplnameInput
            // 
            this.UplnameInput.Location = new System.Drawing.Point(186, 110);
            this.UplnameInput.Name = "UplnameInput";
            this.UplnameInput.ReadOnly = true;
            this.UplnameInput.Size = new System.Drawing.Size(131, 20);
            this.UplnameInput.TabIndex = 55;
            this.UplnameInput.TextChanged += new System.EventHandler(this.UplnameInput_TextChanged);
            // 
            // uplnLabel
            // 
            this.uplnLabel.AutoSize = true;
            this.uplnLabel.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uplnLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.uplnLabel.Location = new System.Drawing.Point(181, 80);
            this.uplnLabel.Name = "uplnLabel";
            this.uplnLabel.Size = new System.Drawing.Size(95, 27);
            this.uplnLabel.TabIndex = 56;
            this.uplnLabel.Text = "Last Name :";
            this.uplnLabel.Click += new System.EventHandler(this.uplnLabel_Click);
            // 
            // UpfnameInput
            // 
            this.UpfnameInput.Location = new System.Drawing.Point(17, 110);
            this.UpfnameInput.Name = "UpfnameInput";
            this.UpfnameInput.ReadOnly = true;
            this.UpfnameInput.Size = new System.Drawing.Size(131, 20);
            this.UpfnameInput.TabIndex = 57;
            this.UpfnameInput.TextChanged += new System.EventHandler(this.UpfnameInput_TextChanged);
            // 
            // UpcustIdInput
            // 
            this.UpcustIdInput.Location = new System.Drawing.Point(139, 28);
            this.UpcustIdInput.Name = "UpcustIdInput";
            this.UpcustIdInput.ReadOnly = true;
            this.UpcustIdInput.Size = new System.Drawing.Size(178, 20);
            this.UpcustIdInput.TabIndex = 53;
            this.UpcustIdInput.TextChanged += new System.EventHandler(this.UpcustIdInput_TextChanged);
            // 
            // upCustomerIDLabel
            // 
            this.upCustomerIDLabel.AutoSize = true;
            this.upCustomerIDLabel.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upCustomerIDLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.upCustomerIDLabel.Location = new System.Drawing.Point(12, 25);
            this.upCustomerIDLabel.Name = "upCustomerIDLabel";
            this.upCustomerIDLabel.Size = new System.Drawing.Size(111, 29);
            this.upCustomerIDLabel.TabIndex = 52;
            this.upCustomerIDLabel.Text = "Customer ID:";
            this.upCustomerIDLabel.Click += new System.EventHandler(this.upCustomerIDLabel_Click);
            // 
            // updateAppt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(392, 450);
            this.Controls.Add(this.upApptCancelB);
            this.Controls.Add(this.updateApptButton);
            this.Controls.Add(this.dateTimeUpdate2);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.upApptTypeBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.upfnLabel);
            this.Controls.Add(this.UplnameInput);
            this.Controls.Add(this.uplnLabel);
            this.Controls.Add(this.UpfnameInput);
            this.Controls.Add(this.UpcustIdInput);
            this.Controls.Add(this.upCustomerIDLabel);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "updateAppt";
            this.Text = "Update Appt ";
            this.Load += new System.EventHandler(this.updateAppt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button upApptCancelB;
        private System.Windows.Forms.Button updateApptButton;
        private System.Windows.Forms.DateTimePicker dateTimeUpdate2;
        private System.Windows.Forms.Label dateTime;
        private System.Windows.Forms.TextBox upApptTypeBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label upfnLabel;
        private System.Windows.Forms.TextBox UplnameInput;
        private System.Windows.Forms.Label uplnLabel;
        private System.Windows.Forms.TextBox UpfnameInput;
        private System.Windows.Forms.TextBox UpcustIdInput;
        private System.Windows.Forms.Label upCustomerIDLabel;
    }
}