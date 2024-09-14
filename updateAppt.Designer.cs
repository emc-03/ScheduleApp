
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
            this.upDateTime = new System.Windows.Forms.DateTimePicker();
            this.dateTime = new System.Windows.Forms.Label();
            this.upApptType = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.upHourBox = new System.Windows.Forms.TextBox();
            this.upMinuteBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // upApptCancelB
            // 
            this.upApptCancelB.BackColor = System.Drawing.Color.Black;
            this.upApptCancelB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upApptCancelB.ForeColor = System.Drawing.Color.IndianRed;
            this.upApptCancelB.Location = new System.Drawing.Point(364, 474);
            this.upApptCancelB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.upApptCancelB.Name = "upApptCancelB";
            this.upApptCancelB.Size = new System.Drawing.Size(184, 92);
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
            this.updateApptButton.Location = new System.Drawing.Point(26, 402);
            this.updateApptButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.updateApptButton.Name = "updateApptButton";
            this.updateApptButton.Size = new System.Drawing.Size(184, 92);
            this.updateApptButton.TabIndex = 62;
            this.updateApptButton.Text = "UPDATE";
            this.updateApptButton.UseVisualStyleBackColor = false;
            this.updateApptButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // upDateTime
            // 
            this.upDateTime.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upDateTime.Location = new System.Drawing.Point(156, 205);
            this.upDateTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.upDateTime.Name = "upDateTime";
            this.upDateTime.Size = new System.Drawing.Size(391, 35);
            this.upDateTime.TabIndex = 61;
            this.upDateTime.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTime
            // 
            this.dateTime.AutoSize = true;
            this.dateTime.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime.ForeColor = System.Drawing.Color.Gainsboro;
            this.dateTime.Location = new System.Drawing.Point(18, 205);
            this.dateTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(61, 29);
            this.dateTime.TabIndex = 60;
            this.dateTime.Text = "Date : ";
            this.dateTime.Click += new System.EventHandler(this.dateTime_Click);
            // 
            // upApptType
            // 
            this.upApptType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upApptType.Location = new System.Drawing.Point(282, 111);
            this.upApptType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.upApptType.Name = "upApptType";
            this.upApptType.Size = new System.Drawing.Size(265, 22);
            this.upApptType.TabIndex = 59;
            this.upApptType.TextChanged += new System.EventHandler(this.apptTypeBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(12, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 29);
            this.label1.TabIndex = 58;
            this.label1.Text = "Appointment Type :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.timeLabel.Location = new System.Drawing.Point(18, 298);
            this.timeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(63, 29);
            this.timeLabel.TabIndex = 64;
            this.timeLabel.Text = "Time : ";
            // 
            // upHourBox
            // 
            this.upHourBox.Location = new System.Drawing.Point(156, 312);
            this.upHourBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.upHourBox.Name = "upHourBox";
            this.upHourBox.Size = new System.Drawing.Size(148, 26);
            this.upHourBox.TabIndex = 65;
            // 
            // upMinuteBox
            // 
            this.upMinuteBox.Location = new System.Drawing.Point(340, 312);
            this.upMinuteBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.upMinuteBox.Name = "upMinuteBox";
            this.upMinuteBox.Size = new System.Drawing.Size(148, 26);
            this.upMinuteBox.TabIndex = 66;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(315, 308);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 29);
            this.label2.TabIndex = 67;
            this.label2.Text = " : ";
            // 
            // updateAppt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(588, 692);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.upMinuteBox);
            this.Controls.Add(this.upHourBox);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.upApptCancelB);
            this.Controls.Add(this.updateApptButton);
            this.Controls.Add(this.upDateTime);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.upApptType);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "updateAppt";
            this.Text = "Update Appt ";
            this.Load += new System.EventHandler(this.updateAppt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button upApptCancelB;
        private System.Windows.Forms.Button updateApptButton;
        private System.Windows.Forms.DateTimePicker upDateTime;
        private System.Windows.Forms.Label dateTime;
        private System.Windows.Forms.TextBox upApptType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.TextBox upHourBox;
        private System.Windows.Forms.TextBox upMinuteBox;
        private System.Windows.Forms.Label label2;
    }
}