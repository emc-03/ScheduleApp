
namespace ScheduleApp
{
    partial class customerData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(customerData));
            this.customerDataSource = new System.Windows.Forms.BindingSource(this.components);
            this.custButtonPanel1 = new System.Windows.Forms.Panel();
            this.newCustomer = new System.Windows.Forms.Button();
            this.updateCustomerButton = new System.Windows.Forms.Button();
            this.deleteCustButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.customberDataLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lnameInput = new System.Windows.Forms.TextBox();
            this.fnameInput = new System.Windows.Forms.TextBox();
            this.lastNameLable = new System.Windows.Forms.Label();
            this.phoneInput = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.addressInput = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.cityInput = new System.Windows.Forms.TextBox();
            this.cityNameLabel = new System.Windows.Forms.Label();
            this.countryInput = new System.Windows.Forms.TextBox();
            this.Country = new System.Windows.Forms.Label();
            this.custIdInput = new System.Windows.Forms.TextBox();
            this.customerID = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.apptList = new System.Windows.Forms.Label();
            this.apptLookup = new System.Windows.Forms.Button();
            this.newAppt = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataSource)).BeginInit();
            this.custButtonPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // custButtonPanel1
            // 
            this.custButtonPanel1.Controls.Add(this.deleteCustButton);
            this.custButtonPanel1.Controls.Add(this.updateCustomerButton);
            this.custButtonPanel1.Location = new System.Drawing.Point(412, 348);
            this.custButtonPanel1.Name = "custButtonPanel1";
            this.custButtonPanel1.Size = new System.Drawing.Size(556, 64);
            this.custButtonPanel1.TabIndex = 0;
            this.custButtonPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.custButtonPanel1_Paint);
            // 
            // newCustomer
            // 
            this.newCustomer.BackColor = System.Drawing.Color.Black;
            this.newCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newCustomer.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.newCustomer.Location = new System.Drawing.Point(197, 618);
            this.newCustomer.Name = "newCustomer";
            this.newCustomer.Size = new System.Drawing.Size(181, 62);
            this.newCustomer.TabIndex = 0;
            this.newCustomer.Text = "Add Customer";
            this.newCustomer.UseVisualStyleBackColor = false;
            // 
            // updateCustomerButton
            // 
            this.updateCustomerButton.BackColor = System.Drawing.Color.Black;
            this.updateCustomerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateCustomerButton.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.updateCustomerButton.Location = new System.Drawing.Point(17, 17);
            this.updateCustomerButton.Name = "updateCustomerButton";
            this.updateCustomerButton.Size = new System.Drawing.Size(87, 31);
            this.updateCustomerButton.TabIndex = 1;
            this.updateCustomerButton.Text = "Update";
            this.updateCustomerButton.UseVisualStyleBackColor = false;
            // 
            // deleteCustButton
            // 
            this.deleteCustButton.BackColor = System.Drawing.Color.Black;
            this.deleteCustButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteCustButton.ForeColor = System.Drawing.Color.LightCoral;
            this.deleteCustButton.Location = new System.Drawing.Point(456, 17);
            this.deleteCustButton.Name = "deleteCustButton";
            this.deleteCustButton.Size = new System.Drawing.Size(87, 31);
            this.deleteCustButton.TabIndex = 2;
            this.deleteCustButton.Text = "Delete";
            this.deleteCustButton.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(412, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(556, 254);
            this.panel1.TabIndex = 1;
            // 
            // customberDataLabel
            // 
            this.customberDataLabel.AutoSize = true;
            this.customberDataLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.customberDataLabel.Location = new System.Drawing.Point(407, 36);
            this.customberDataLabel.Name = "customberDataLabel";
            this.customberDataLabel.Size = new System.Drawing.Size(177, 29);
            this.customberDataLabel.TabIndex = 2;
            this.customberDataLabel.Text = "Current Customer List";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Gainsboro;
            this.button1.Location = new System.Drawing.Point(899, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "SEARCH";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(746, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(147, 32);
            this.textBox1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.custIdInput);
            this.panel2.Controls.Add(this.customerID);
            this.panel2.Controls.Add(this.countryInput);
            this.panel2.Controls.Add(this.Country);
            this.panel2.Controls.Add(this.cityInput);
            this.panel2.Controls.Add(this.cityNameLabel);
            this.panel2.Controls.Add(this.addressInput);
            this.panel2.Controls.Add(this.addressLabel);
            this.panel2.Controls.Add(this.phoneInput);
            this.panel2.Controls.Add(this.phoneLabel);
            this.panel2.Controls.Add(this.fnameInput);
            this.panel2.Controls.Add(this.lastNameLable);
            this.panel2.Controls.Add(this.lnameInput);
            this.panel2.Controls.Add(this.firstNameLabel);
            this.panel2.Controls.Add(this.newCustomer);
            this.panel2.Location = new System.Drawing.Point(11, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(381, 683);
            this.panel2.TabIndex = 5;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.Location = new System.Drawing.Point(1, 37);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(97, 27);
            this.firstNameLabel.TabIndex = 1;
            this.firstNameLabel.Text = "First Name :";
            // 
            // lnameInput
            // 
            this.lnameInput.Location = new System.Drawing.Point(197, 67);
            this.lnameInput.Name = "lnameInput";
            this.lnameInput.Size = new System.Drawing.Size(168, 38);
            this.lnameInput.TabIndex = 2;
            // 
            // fnameInput
            // 
            this.fnameInput.Location = new System.Drawing.Point(1, 67);
            this.fnameInput.Name = "fnameInput";
            this.fnameInput.Size = new System.Drawing.Size(168, 38);
            this.fnameInput.TabIndex = 4;
            // 
            // lastNameLable
            // 
            this.lastNameLable.AutoSize = true;
            this.lastNameLable.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLable.Location = new System.Drawing.Point(192, 37);
            this.lastNameLable.Name = "lastNameLable";
            this.lastNameLable.Size = new System.Drawing.Size(95, 27);
            this.lastNameLable.TabIndex = 3;
            this.lastNameLable.Text = "Last Name :";
            // 
            // phoneInput
            // 
            this.phoneInput.Location = new System.Drawing.Point(142, 125);
            this.phoneInput.Name = "phoneInput";
            this.phoneInput.Size = new System.Drawing.Size(223, 38);
            this.phoneInput.TabIndex = 6;
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(-1, 128);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(137, 29);
            this.phoneLabel.TabIndex = 5;
            this.phoneLabel.Text = "Phone Number :";
            // 
            // addressInput
            // 
            this.addressInput.Location = new System.Drawing.Point(142, 175);
            this.addressInput.Name = "addressInput";
            this.addressInput.Size = new System.Drawing.Size(223, 38);
            this.addressInput.TabIndex = 8;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(6, 184);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(130, 29);
            this.addressLabel.TabIndex = 7;
            this.addressLabel.Text = "Street Address :";
            // 
            // cityInput
            // 
            this.cityInput.Location = new System.Drawing.Point(142, 241);
            this.cityInput.Name = "cityInput";
            this.cityInput.Size = new System.Drawing.Size(202, 38);
            this.cityInput.TabIndex = 10;
            // 
            // cityNameLabel
            // 
            this.cityNameLabel.AutoSize = true;
            this.cityNameLabel.Location = new System.Drawing.Point(85, 250);
            this.cityNameLabel.Name = "cityNameLabel";
            this.cityNameLabel.Size = new System.Drawing.Size(51, 29);
            this.cityNameLabel.TabIndex = 9;
            this.cityNameLabel.Text = "City :";
            // 
            // countryInput
            // 
            this.countryInput.Location = new System.Drawing.Point(142, 307);
            this.countryInput.Name = "countryInput";
            this.countryInput.Size = new System.Drawing.Size(202, 38);
            this.countryInput.TabIndex = 12;
            // 
            // Country
            // 
            this.Country.AutoSize = true;
            this.Country.Location = new System.Drawing.Point(54, 316);
            this.Country.Name = "Country";
            this.Country.Size = new System.Drawing.Size(82, 29);
            this.Country.TabIndex = 11;
            this.Country.Text = "Country :";
            // 
            // custIdInput
            // 
            this.custIdInput.Location = new System.Drawing.Point(120, 417);
            this.custIdInput.Name = "custIdInput";
            this.custIdInput.Size = new System.Drawing.Size(245, 38);
            this.custIdInput.TabIndex = 14;
            // 
            // customerID
            // 
            this.customerID.AutoSize = true;
            this.customerID.Location = new System.Drawing.Point(3, 426);
            this.customerID.Name = "customerID";
            this.customerID.Size = new System.Drawing.Size(111, 29);
            this.customerID.TabIndex = 13;
            this.customerID.Text = "Customer ID:";
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Black;
            this.cancelButton.Location = new System.Drawing.Point(850, 656);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(126, 51);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "CANCEL";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.newAppt);
            this.panel3.Controls.Add(this.apptLookup);
            this.panel3.Location = new System.Drawing.Point(412, 451);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(556, 188);
            this.panel3.TabIndex = 7;
            // 
            // apptList
            // 
            this.apptList.AutoSize = true;
            this.apptList.Location = new System.Drawing.Point(412, 419);
            this.apptList.Name = "apptList";
            this.apptList.Size = new System.Drawing.Size(199, 29);
            this.apptList.TabIndex = 8;
            this.apptList.Text = "Customer Appointments";
            // 
            // apptLookup
            // 
            this.apptLookup.BackColor = System.Drawing.Color.CornflowerBlue;
            this.apptLookup.ForeColor = System.Drawing.Color.Black;
            this.apptLookup.Location = new System.Drawing.Point(33, 33);
            this.apptLookup.Name = "apptLookup";
            this.apptLookup.Size = new System.Drawing.Size(210, 115);
            this.apptLookup.TabIndex = 0;
            this.apptLookup.Text = "Appointment Calendar";
            this.apptLookup.UseVisualStyleBackColor = false;
            // 
            // newAppt
            // 
            this.newAppt.BackColor = System.Drawing.Color.CornflowerBlue;
            this.newAppt.ForeColor = System.Drawing.Color.Black;
            this.newAppt.Location = new System.Drawing.Point(350, 17);
            this.newAppt.Name = "newAppt";
            this.newAppt.Size = new System.Drawing.Size(154, 66);
            this.newAppt.TabIndex = 1;
            this.newAppt.Text = "New Appointment";
            this.newAppt.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(350, 104);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 66);
            this.button2.TabIndex = 2;
            this.button2.Text = "Update Appointment";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // customerData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(991, 716);
            this.Controls.Add(this.apptList);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.customberDataLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.custButtonPanel1);
            this.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.Name = "customerData";
            this.Text = "CUSTOMER INFORMATION";
            ((System.ComponentModel.ISupportInitialize)(this.customerDataSource)).EndInit();
            this.custButtonPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource customerDataSource;
        private System.Windows.Forms.Panel custButtonPanel1;
        private System.Windows.Forms.Button deleteCustButton;
        private System.Windows.Forms.Button updateCustomerButton;
        private System.Windows.Forms.Button newCustomer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label customberDataLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox custIdInput;
        private System.Windows.Forms.Label customerID;
        private System.Windows.Forms.TextBox countryInput;
        private System.Windows.Forms.Label Country;
        private System.Windows.Forms.TextBox cityInput;
        private System.Windows.Forms.Label cityNameLabel;
        private System.Windows.Forms.TextBox addressInput;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox phoneInput;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.TextBox fnameInput;
        private System.Windows.Forms.Label lastNameLable;
        private System.Windows.Forms.TextBox lnameInput;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button newAppt;
        private System.Windows.Forms.Button apptLookup;
        private System.Windows.Forms.Label apptList;
        private System.Windows.Forms.Button button2;
    }
}