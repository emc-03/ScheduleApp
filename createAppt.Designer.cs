
namespace ScheduleApp
{
    partial class CreateAppointmentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAppointmentForm));
            this.createTitleInput = new System.Windows.Forms.TextBox();
            this.createTitleLable = new System.Windows.Forms.Label();
            this.createContactInput = new System.Windows.Forms.TextBox();
            this.createLinkInput = new System.Windows.Forms.TextBox();
            this.createLinkLabel = new System.Windows.Forms.Label();
            this.createDateTimeLabel = new System.Windows.Forms.Label();
            this.createDateTimeSelect = new System.Windows.Forms.DateTimePicker();
            this.CreateCancelButton = new System.Windows.Forms.Button();
            this.createApptButton = new System.Windows.Forms.Button();
            this.createDescriptionInput = new System.Windows.Forms.TextBox();
            this.createDescriptionLable = new System.Windows.Forms.Label();
            this.createLocationInput = new System.Windows.Forms.TextBox();
            this.createLocationLabel = new System.Windows.Forms.Label();
            this.createContactLabel = new System.Windows.Forms.Label();
            this.createTypeLabel = new System.Windows.Forms.Label();
            this.createStartTimeInput = new System.Windows.Forms.DateTimePicker();
            this.createStartTimeLabel = new System.Windows.Forms.Label();
            this.createEndTimeInput = new System.Windows.Forms.DateTimePicker();
            this.createEndTimeLabel = new System.Windows.Forms.Label();
            this.createApptTypeInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // createTitleInput
            // 
            this.createTitleInput.Location = new System.Drawing.Point(115, 22);
            this.createTitleInput.Name = "createTitleInput";
            this.createTitleInput.Size = new System.Drawing.Size(266, 20);
            this.createTitleInput.TabIndex = 0;
            this.createTitleInput.TextChanged += new System.EventHandler(this.createIdInput_TextChanged);
            // 
            // createTitleLable
            // 
            this.createTitleLable.AutoSize = true;
            this.createTitleLable.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTitleLable.ForeColor = System.Drawing.Color.Gainsboro;
            this.createTitleLable.Location = new System.Drawing.Point(18, 22);
            this.createTitleLable.Name = "createTitleLable";
            this.createTitleLable.Size = new System.Drawing.Size(47, 29);
            this.createTitleLable.TabIndex = 37;
            this.createTitleLable.Text = "Title";
            this.createTitleLable.Click += new System.EventHandler(this.createTitleLable_Click);
            // 
            // createContactInput
            // 
            this.createContactInput.Location = new System.Drawing.Point(115, 158);
            this.createContactInput.Name = "createContactInput";
            this.createContactInput.Size = new System.Drawing.Size(212, 20);
            this.createContactInput.TabIndex = 3;
            this.createContactInput.TextChanged += new System.EventHandler(this.createFnameInput_TextChanged);
            // 
            // createLinkInput
            // 
            this.createLinkInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createLinkInput.Location = new System.Drawing.Point(116, 197);
            this.createLinkInput.Name = "createLinkInput";
            this.createLinkInput.Size = new System.Drawing.Size(212, 22);
            this.createLinkInput.TabIndex = 4;
            this.createLinkInput.TextChanged += new System.EventHandler(this.apptTypeBox_TextChanged);
            // 
            // createLinkLabel
            // 
            this.createLinkLabel.AutoSize = true;
            this.createLinkLabel.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createLinkLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.createLinkLabel.Location = new System.Drawing.Point(18, 196);
            this.createLinkLabel.Name = "createLinkLabel";
            this.createLinkLabel.Size = new System.Drawing.Size(45, 29);
            this.createLinkLabel.TabIndex = 43;
            this.createLinkLabel.Text = "Link";
            this.createLinkLabel.Click += new System.EventHandler(this.createLinkLabel_Click);
            // 
            // createDateTimeLabel
            // 
            this.createDateTimeLabel.AutoSize = true;
            this.createDateTimeLabel.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createDateTimeLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.createDateTimeLabel.Location = new System.Drawing.Point(18, 278);
            this.createDateTimeLabel.Name = "createDateTimeLabel";
            this.createDateTimeLabel.Size = new System.Drawing.Size(53, 29);
            this.createDateTimeLabel.TabIndex = 47;
            this.createDateTimeLabel.Text = "Date ";
            this.createDateTimeLabel.Click += new System.EventHandler(this.createDateTimeLabel_Click);
            // 
            // createDateTimeSelect
            // 
            this.createDateTimeSelect.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createDateTimeSelect.Location = new System.Drawing.Point(106, 276);
            this.createDateTimeSelect.Name = "createDateTimeSelect";
            this.createDateTimeSelect.Size = new System.Drawing.Size(276, 24);
            this.createDateTimeSelect.TabIndex = 5;
            this.createDateTimeSelect.ValueChanged += new System.EventHandler(this.createDateTimeSelect_ValueChanged);
            // 
            // CreateCancelButton
            // 
            this.CreateCancelButton.BackColor = System.Drawing.Color.Black;
            this.CreateCancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateCancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateCancelButton.ForeColor = System.Drawing.Color.IndianRed;
            this.CreateCancelButton.Location = new System.Drawing.Point(336, 477);
            this.CreateCancelButton.Name = "CreateCancelButton";
            this.CreateCancelButton.Size = new System.Drawing.Size(123, 60);
            this.CreateCancelButton.TabIndex = 10;
            this.CreateCancelButton.Text = "CANCEL";
            this.CreateCancelButton.UseVisualStyleBackColor = false;
            this.CreateCancelButton.Click += new System.EventHandler(this.CreateCancelButton_Click);
            // 
            // createApptButton
            // 
            this.createApptButton.BackColor = System.Drawing.Color.Black;
            this.createApptButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createApptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createApptButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.createApptButton.Location = new System.Drawing.Point(12, 477);
            this.createApptButton.Name = "createApptButton";
            this.createApptButton.Size = new System.Drawing.Size(123, 60);
            this.createApptButton.TabIndex = 9;
            this.createApptButton.Text = "SAVE";
            this.createApptButton.UseVisualStyleBackColor = false;
            this.createApptButton.Click += new System.EventHandler(this.createApptButton_Click);
            // 
            // createDescriptionInput
            // 
            this.createDescriptionInput.Location = new System.Drawing.Point(115, 54);
            this.createDescriptionInput.Multiline = true;
            this.createDescriptionInput.Name = "createDescriptionInput";
            this.createDescriptionInput.Size = new System.Drawing.Size(266, 53);
            this.createDescriptionInput.TabIndex = 1;
            this.createDescriptionInput.TextChanged += new System.EventHandler(this.createDescriptionInput_TextChanged);
            // 
            // createDescriptionLable
            // 
            this.createDescriptionLable.AutoSize = true;
            this.createDescriptionLable.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createDescriptionLable.ForeColor = System.Drawing.Color.Gainsboro;
            this.createDescriptionLable.Location = new System.Drawing.Point(16, 69);
            this.createDescriptionLable.Name = "createDescriptionLable";
            this.createDescriptionLable.Size = new System.Drawing.Size(101, 29);
            this.createDescriptionLable.TabIndex = 52;
            this.createDescriptionLable.Text = "Description";
            this.createDescriptionLable.Click += new System.EventHandler(this.createDescriptionLable_Click);
            // 
            // createLocationInput
            // 
            this.createLocationInput.Location = new System.Drawing.Point(116, 122);
            this.createLocationInput.Name = "createLocationInput";
            this.createLocationInput.Size = new System.Drawing.Size(266, 20);
            this.createLocationInput.TabIndex = 2;
            this.createLocationInput.TextChanged += new System.EventHandler(this.createLocationInput_TextChanged);
            // 
            // createLocationLabel
            // 
            this.createLocationLabel.AutoSize = true;
            this.createLocationLabel.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createLocationLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.createLocationLabel.Location = new System.Drawing.Point(16, 119);
            this.createLocationLabel.Name = "createLocationLabel";
            this.createLocationLabel.Size = new System.Drawing.Size(79, 29);
            this.createLocationLabel.TabIndex = 54;
            this.createLocationLabel.Text = "Location";
            this.createLocationLabel.Click += new System.EventHandler(this.createLocationLabel_Click);
            // 
            // createContactLabel
            // 
            this.createContactLabel.AutoSize = true;
            this.createContactLabel.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createContactLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.createContactLabel.Location = new System.Drawing.Point(18, 158);
            this.createContactLabel.Name = "createContactLabel";
            this.createContactLabel.Size = new System.Drawing.Size(70, 27);
            this.createContactLabel.TabIndex = 39;
            this.createContactLabel.Text = "Contact ";
            // 
            // createTypeLabel
            // 
            this.createTypeLabel.AutoSize = true;
            this.createTypeLabel.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTypeLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.createTypeLabel.Location = new System.Drawing.Point(16, 410);
            this.createTypeLabel.Name = "createTypeLabel";
            this.createTypeLabel.Size = new System.Drawing.Size(144, 27);
            this.createTypeLabel.TabIndex = 57;
            this.createTypeLabel.Text = "Appointment Type";
            this.createTypeLabel.Click += new System.EventHandler(this.createTypeLabel_Click);
            // 
            // createStartTimeInput
            // 
            this.createStartTimeInput.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createStartTimeInput.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.createStartTimeInput.Location = new System.Drawing.Point(166, 319);
            this.createStartTimeInput.Name = "createStartTimeInput";
            this.createStartTimeInput.Size = new System.Drawing.Size(144, 24);
            this.createStartTimeInput.TabIndex = 6;
            this.createStartTimeInput.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // createStartTimeLabel
            // 
            this.createStartTimeLabel.AutoSize = true;
            this.createStartTimeLabel.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createStartTimeLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.createStartTimeLabel.Location = new System.Drawing.Point(18, 319);
            this.createStartTimeLabel.Name = "createStartTimeLabel";
            this.createStartTimeLabel.Size = new System.Drawing.Size(91, 29);
            this.createStartTimeLabel.TabIndex = 58;
            this.createStartTimeLabel.Text = "Start Time";
            this.createStartTimeLabel.Click += new System.EventHandler(this.createStartTimeLabel_Click);
            // 
            // createEndTimeInput
            // 
            this.createEndTimeInput.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createEndTimeInput.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.createEndTimeInput.Location = new System.Drawing.Point(166, 358);
            this.createEndTimeInput.Name = "createEndTimeInput";
            this.createEndTimeInput.Size = new System.Drawing.Size(144, 24);
            this.createEndTimeInput.TabIndex = 7;
            this.createEndTimeInput.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // createEndTimeLabel
            // 
            this.createEndTimeLabel.AutoSize = true;
            this.createEndTimeLabel.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createEndTimeLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.createEndTimeLabel.Location = new System.Drawing.Point(18, 353);
            this.createEndTimeLabel.Name = "createEndTimeLabel";
            this.createEndTimeLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.createEndTimeLabel.Size = new System.Drawing.Size(84, 29);
            this.createEndTimeLabel.TabIndex = 60;
            this.createEndTimeLabel.Text = "End Time";
            this.createEndTimeLabel.Click += new System.EventHandler(this.createEndTimeLabel_Click);
            // 
            // createApptTypeInput
            // 
            this.createApptTypeInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createApptTypeInput.Location = new System.Drawing.Point(166, 410);
            this.createApptTypeInput.Name = "createApptTypeInput";
            this.createApptTypeInput.Size = new System.Drawing.Size(212, 22);
            this.createApptTypeInput.TabIndex = 8;
            this.createApptTypeInput.TabStop = false;
            this.createApptTypeInput.TextChanged += new System.EventHandler(this.createApptTypeInput_TextChanged);
            // 
            // CreateAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(471, 549);
            this.Controls.Add(this.createApptTypeInput);
            this.Controls.Add(this.createEndTimeInput);
            this.Controls.Add(this.createEndTimeLabel);
            this.Controls.Add(this.createStartTimeInput);
            this.Controls.Add(this.createStartTimeLabel);
            this.Controls.Add(this.createTypeLabel);
            this.Controls.Add(this.createLocationInput);
            this.Controls.Add(this.createLocationLabel);
            this.Controls.Add(this.createDescriptionInput);
            this.Controls.Add(this.createDescriptionLable);
            this.Controls.Add(this.CreateCancelButton);
            this.Controls.Add(this.createApptButton);
            this.Controls.Add(this.createDateTimeSelect);
            this.Controls.Add(this.createDateTimeLabel);
            this.Controls.Add(this.createLinkInput);
            this.Controls.Add(this.createLinkLabel);
            this.Controls.Add(this.createContactLabel);
            this.Controls.Add(this.createContactInput);
            this.Controls.Add(this.createTitleInput);
            this.Controls.Add(this.createTitleLable);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateAppointmentForm";
            this.Text = "Create Appointment";
            this.Load += new System.EventHandler(this.CreateAppointment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox createTitleInput;
        private System.Windows.Forms.TextBox createContactInput;
        private System.Windows.Forms.TextBox createLinkInput;
        private System.Windows.Forms.DateTimePicker createDateTimeSelect;
        private System.Windows.Forms.Button CreateCancelButton;
        private System.Windows.Forms.Button createApptButton;
        private System.Windows.Forms.Label createTitleLable;
        private System.Windows.Forms.Label createLinkLabel;
        private System.Windows.Forms.Label createDateTimeLabel;
        private System.Windows.Forms.TextBox createDescriptionInput;
        private System.Windows.Forms.Label createDescriptionLable;
        private System.Windows.Forms.TextBox createLocationInput;
        private System.Windows.Forms.Label createLocationLabel;
        private System.Windows.Forms.Label createContactLabel;
        private System.Windows.Forms.Label createTypeLabel;
        private System.Windows.Forms.DateTimePicker createStartTimeInput;
        private System.Windows.Forms.Label createStartTimeLabel;
        private System.Windows.Forms.DateTimePicker createEndTimeInput;
        private System.Windows.Forms.Label createEndTimeLabel;
        private System.Windows.Forms.TextBox createApptTypeInput;
    }
}