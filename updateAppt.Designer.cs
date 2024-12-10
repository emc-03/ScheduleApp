
namespace ScheduleApp
{
    partial class UpdateAppointmentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateAppointmentForm));
            this.upApptCancelB = new System.Windows.Forms.Button();
            this.updateApptButton = new System.Windows.Forms.Button();
            this.updateTitleInput = new System.Windows.Forms.TextBox();
            this.updateTitleLabel = new System.Windows.Forms.Label();
            this.updateDescriptionInput = new System.Windows.Forms.TextBox();
            this.updateDescriptionLable = new System.Windows.Forms.Label();
            this.updateLocationInput = new System.Windows.Forms.TextBox();
            this.updateLocationLabel = new System.Windows.Forms.Label();
            this.updateContactLabel = new System.Windows.Forms.Label();
            this.updateContactInput = new System.Windows.Forms.TextBox();
            this.updateLinkInput = new System.Windows.Forms.TextBox();
            this.createLinkLabel = new System.Windows.Forms.Label();
            this.updateEndTimeInput = new System.Windows.Forms.DateTimePicker();
            this.updateEndTimeLabel = new System.Windows.Forms.Label();
            this.updateStartTimeInput = new System.Windows.Forms.DateTimePicker();
            this.updateStartTimeLabel = new System.Windows.Forms.Label();
            this.updateDateTimeSelect = new System.Windows.Forms.DateTimePicker();
            this.updateDateTimeLabel = new System.Windows.Forms.Label();
            this.updateTypeLabel = new System.Windows.Forms.Label();
            this.updateApptType = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // upApptCancelB
            // 
            this.upApptCancelB.BackColor = System.Drawing.Color.Black;
            this.upApptCancelB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upApptCancelB.ForeColor = System.Drawing.Color.IndianRed;
            this.upApptCancelB.Location = new System.Drawing.Point(322, 440);
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
            this.updateApptButton.Location = new System.Drawing.Point(12, 440);
            this.updateApptButton.Name = "updateApptButton";
            this.updateApptButton.Size = new System.Drawing.Size(123, 60);
            this.updateApptButton.TabIndex = 62;
            this.updateApptButton.Text = "UPDATE";
            this.updateApptButton.UseVisualStyleBackColor = false;
            this.updateApptButton.Click += new System.EventHandler(this.updateButton_Click);
            
            // 
            // updateTitleInput
            // 
            this.updateTitleInput.AcceptsTab = true;
            this.updateTitleInput.Location = new System.Drawing.Point(109, 20);
            this.updateTitleInput.Name = "updateTitleInput";
            this.updateTitleInput.Size = new System.Drawing.Size(266, 20);
            this.updateTitleInput.TabIndex = 0;
            this.updateTitleInput.TextChanged += new System.EventHandler(this.updateTitleInput_TextChanged);
            // 
            // updateTitleLabel
            // 
            this.updateTitleLabel.AutoSize = true;
            this.updateTitleLabel.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateTitleLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.updateTitleLabel.Location = new System.Drawing.Point(7, 20);
            this.updateTitleLabel.Name = "updateTitleLabel";
            this.updateTitleLabel.Size = new System.Drawing.Size(47, 29);
            this.updateTitleLabel.TabIndex = 64;
            this.updateTitleLabel.Text = "Title";
            // 
            // updateDescriptionInput
            // 
            this.updateDescriptionInput.AcceptsTab = true;
            this.updateDescriptionInput.Location = new System.Drawing.Point(109, 46);
            this.updateDescriptionInput.Multiline = true;
            this.updateDescriptionInput.Name = "updateDescriptionInput";
            this.updateDescriptionInput.Size = new System.Drawing.Size(266, 53);
            this.updateDescriptionInput.TabIndex = 1;
            this.updateDescriptionInput.TextChanged += new System.EventHandler(this.updateDescriptionInput_TextChanged);
            // 
            // updateDescriptionLable
            // 
            this.updateDescriptionLable.AutoSize = true;
            this.updateDescriptionLable.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateDescriptionLable.ForeColor = System.Drawing.Color.Gainsboro;
            this.updateDescriptionLable.Location = new System.Drawing.Point(7, 61);
            this.updateDescriptionLable.Name = "updateDescriptionLable";
            this.updateDescriptionLable.Size = new System.Drawing.Size(101, 29);
            this.updateDescriptionLable.TabIndex = 66;
            this.updateDescriptionLable.Text = "Description";
            // 
            // updateLocationInput
            // 
            this.updateLocationInput.AcceptsTab = true;
            this.updateLocationInput.Location = new System.Drawing.Point(109, 114);
            this.updateLocationInput.Name = "updateLocationInput";
            this.updateLocationInput.Size = new System.Drawing.Size(266, 20);
            this.updateLocationInput.TabIndex = 2;
            this.updateLocationInput.TextChanged += new System.EventHandler(this.updateLocationInput_TextChanged);
            // 
            // updateLocationLabel
            // 
            this.updateLocationLabel.AutoSize = true;
            this.updateLocationLabel.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateLocationLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.updateLocationLabel.Location = new System.Drawing.Point(7, 111);
            this.updateLocationLabel.Name = "updateLocationLabel";
            this.updateLocationLabel.Size = new System.Drawing.Size(79, 29);
            this.updateLocationLabel.TabIndex = 68;
            this.updateLocationLabel.Text = "Location";
            // 
            // updateContactLabel
            // 
            this.updateContactLabel.AutoSize = true;
            this.updateContactLabel.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateContactLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.updateContactLabel.Location = new System.Drawing.Point(7, 147);
            this.updateContactLabel.Name = "updateContactLabel";
            this.updateContactLabel.Size = new System.Drawing.Size(70, 27);
            this.updateContactLabel.TabIndex = 70;
            this.updateContactLabel.Text = "Contact ";
            // 
            // updateContactInput
            // 
            this.updateContactInput.AcceptsTab = true;
            this.updateContactInput.Location = new System.Drawing.Point(109, 149);
            this.updateContactInput.Name = "updateContactInput";
            this.updateContactInput.Size = new System.Drawing.Size(212, 20);
            this.updateContactInput.TabIndex = 3;
            this.updateContactInput.TextChanged += new System.EventHandler(this.updateContactInput_TextChanged);
            // 
            // updateLinkInput
            // 
            this.updateLinkInput.AcceptsTab = true;
            this.updateLinkInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateLinkInput.Location = new System.Drawing.Point(109, 181);
            this.updateLinkInput.Name = "updateLinkInput";
            this.updateLinkInput.Size = new System.Drawing.Size(212, 22);
            this.updateLinkInput.TabIndex = 4;
            this.updateLinkInput.TextChanged += new System.EventHandler(this.createLinkInput_TextChanged);
            // 
            // createLinkLabel
            // 
            this.createLinkLabel.AutoSize = true;
            this.createLinkLabel.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createLinkLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.createLinkLabel.Location = new System.Drawing.Point(7, 174);
            this.createLinkLabel.Name = "createLinkLabel";
            this.createLinkLabel.Size = new System.Drawing.Size(45, 29);
            this.createLinkLabel.TabIndex = 72;
            this.createLinkLabel.Text = "Link";
            // 
            // updateEndTimeInput
            // 
            this.updateEndTimeInput.CustomFormat = "hh:mm tt";
            this.updateEndTimeInput.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateEndTimeInput.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.updateEndTimeInput.Location = new System.Drawing.Point(151, 328);
            this.updateEndTimeInput.Name = "updateEndTimeInput";
            this.updateEndTimeInput.ShowUpDown = true;
            this.updateEndTimeInput.Size = new System.Drawing.Size(144, 24);
            this.updateEndTimeInput.TabIndex = 7;
            this.updateEndTimeInput.ValueChanged += new System.EventHandler(this.updateEndTimeInput_ValueChanged);
            
            // 
            // updateEndTimeLabel
            // 
            this.updateEndTimeLabel.AutoSize = true;
            this.updateEndTimeLabel.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateEndTimeLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.updateEndTimeLabel.Location = new System.Drawing.Point(7, 323);
            this.updateEndTimeLabel.Name = "updateEndTimeLabel";
            this.updateEndTimeLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.updateEndTimeLabel.Size = new System.Drawing.Size(84, 29);
            this.updateEndTimeLabel.TabIndex = 78;
            this.updateEndTimeLabel.Text = "End Time";
            // 
            // updateStartTimeInput
            // 
            this.updateStartTimeInput.CustomFormat = "hh:mm tt";
            this.updateStartTimeInput.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateStartTimeInput.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.updateStartTimeInput.Location = new System.Drawing.Point(151, 292);
            this.updateStartTimeInput.Name = "updateStartTimeInput";
            this.updateStartTimeInput.ShowUpDown = true;
            this.updateStartTimeInput.Size = new System.Drawing.Size(144, 24);
            this.updateStartTimeInput.TabIndex = 6;
            this.updateStartTimeInput.ValueChanged += new System.EventHandler(this.updateStartTimeInput_ValueChanged);
            
            // 
            // updateStartTimeLabel
            // 
            this.updateStartTimeLabel.AutoSize = true;
            this.updateStartTimeLabel.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateStartTimeLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.updateStartTimeLabel.Location = new System.Drawing.Point(7, 292);
            this.updateStartTimeLabel.Name = "updateStartTimeLabel";
            this.updateStartTimeLabel.Size = new System.Drawing.Size(91, 29);
            this.updateStartTimeLabel.TabIndex = 76;
            this.updateStartTimeLabel.Text = "Start Time";
            // 
            // updateDateTimeSelect
            // 
            this.updateDateTimeSelect.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateDateTimeSelect.Location = new System.Drawing.Point(86, 256);
            this.updateDateTimeSelect.Name = "updateDateTimeSelect";
            this.updateDateTimeSelect.Size = new System.Drawing.Size(274, 24);
            this.updateDateTimeSelect.TabIndex = 5;
            this.updateDateTimeSelect.ValueChanged += new System.EventHandler(this.updateDateTimeSelect_ValueChanged);
          
            // 
            // updateDateTimeLabel
            // 
            this.updateDateTimeLabel.AutoSize = true;
            this.updateDateTimeLabel.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateDateTimeLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.updateDateTimeLabel.Location = new System.Drawing.Point(7, 258);
            this.updateDateTimeLabel.Name = "updateDateTimeLabel";
            this.updateDateTimeLabel.Size = new System.Drawing.Size(53, 29);
            this.updateDateTimeLabel.TabIndex = 74;
            this.updateDateTimeLabel.Text = "Date ";
            // 
            // updateTypeLabel
            // 
            this.updateTypeLabel.AutoSize = true;
            this.updateTypeLabel.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateTypeLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.updateTypeLabel.Location = new System.Drawing.Point(7, 364);
            this.updateTypeLabel.Name = "updateTypeLabel";
            this.updateTypeLabel.Size = new System.Drawing.Size(144, 27);
            this.updateTypeLabel.TabIndex = 81;
            this.updateTypeLabel.Text = "Appointment Type";
            // 
            // updateApptType
            // 
            this.updateApptType.AcceptsTab = true;
            this.updateApptType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateApptType.Location = new System.Drawing.Point(157, 364);
            this.updateApptType.Name = "updateApptType";
            this.updateApptType.Size = new System.Drawing.Size(212, 22);
            this.updateApptType.TabIndex = 8;
            this.updateApptType.TextChanged += new System.EventHandler(this.updateApptType_TextChanged);
            // 
            // UpdateAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(457, 519);
            this.Controls.Add(this.updateApptType);
            this.Controls.Add(this.updateTypeLabel);
            this.Controls.Add(this.updateEndTimeInput);
            this.Controls.Add(this.updateEndTimeLabel);
            this.Controls.Add(this.updateStartTimeInput);
            this.Controls.Add(this.updateStartTimeLabel);
            this.Controls.Add(this.updateDateTimeSelect);
            this.Controls.Add(this.updateDateTimeLabel);
            this.Controls.Add(this.updateLinkInput);
            this.Controls.Add(this.createLinkLabel);
            this.Controls.Add(this.updateContactLabel);
            this.Controls.Add(this.updateContactInput);
            this.Controls.Add(this.updateLocationInput);
            this.Controls.Add(this.updateLocationLabel);
            this.Controls.Add(this.updateDescriptionInput);
            this.Controls.Add(this.updateDescriptionLable);
            this.Controls.Add(this.updateTitleInput);
            this.Controls.Add(this.updateTitleLabel);
            this.Controls.Add(this.upApptCancelB);
            this.Controls.Add(this.updateApptButton);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdateAppointmentForm";
            this.Text = "Update Appt ";
            this.Load += new System.EventHandler(this.updateAppt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button upApptCancelB;
        private System.Windows.Forms.Button updateApptButton;
        private System.Windows.Forms.TextBox updateTitleInput;
        private System.Windows.Forms.Label updateTitleLabel;
        private System.Windows.Forms.TextBox updateDescriptionInput;
        private System.Windows.Forms.Label updateDescriptionLable;
        private System.Windows.Forms.TextBox updateLocationInput;
        private System.Windows.Forms.Label updateLocationLabel;
        private System.Windows.Forms.Label updateContactLabel;
        private System.Windows.Forms.TextBox updateContactInput;
        private System.Windows.Forms.TextBox updateLinkInput;
        private System.Windows.Forms.Label createLinkLabel;
        private System.Windows.Forms.DateTimePicker updateEndTimeInput;
        private System.Windows.Forms.Label updateEndTimeLabel;
        private System.Windows.Forms.DateTimePicker updateStartTimeInput;
        private System.Windows.Forms.Label updateStartTimeLabel;
        private System.Windows.Forms.DateTimePicker updateDateTimeSelect;
        private System.Windows.Forms.Label updateDateTimeLabel;
        private System.Windows.Forms.Label updateTypeLabel;
        private System.Windows.Forms.TextBox updateApptType;
    }
}