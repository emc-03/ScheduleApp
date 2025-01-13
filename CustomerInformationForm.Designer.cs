
using System;

namespace ScheduleApp
{
    partial class CustomerInformationForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerInformationForm));
            this.custButtonPanel1 = new System.Windows.Forms.Panel();
            this.deleteCustButton = new System.Windows.Forms.Button();
            this.updateCustomerButton = new System.Windows.Forms.Button();
            this.newCustomer = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridCustomer = new System.Windows.Forms.DataGridView();
            this.customberDataLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.postalCodeLabel = new System.Windows.Forms.Label();
            this.postalCodeInput = new System.Windows.Forms.TextBox();
            this.addressInput2 = new System.Windows.Forms.TextBox();
            this.addCustomerLabel = new System.Windows.Forms.Label();
            this.countryInput = new System.Windows.Forms.TextBox();
            this.Country = new System.Windows.Forms.Label();
            this.cityInput = new System.Windows.Forms.TextBox();
            this.cityNameLabel = new System.Windows.Forms.Label();
            this.addressInput = new System.Windows.Forms.TextBox();
            this.lnameInput = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.phoneInput = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.fnameInput = new System.Windows.Forms.TextBox();
            this.lastNameLable = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.apptLookup = new System.Windows.Forms.Button();
            this.customerDataSource = new System.Windows.Forms.BindingSource(this.components);
            this.custButtonPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCustomer)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataSource)).BeginInit();
            this.SuspendLayout();
            // 
            // custButtonPanel1
            // 
            this.custButtonPanel1.Controls.Add(this.deleteCustButton);
            this.custButtonPanel1.Controls.Add(this.updateCustomerButton);
            this.custButtonPanel1.Location = new System.Drawing.Point(606, 502);
            this.custButtonPanel1.Name = "custButtonPanel1";
            this.custButtonPanel1.Size = new System.Drawing.Size(688, 84);
            this.custButtonPanel1.TabIndex = 0;
            this.custButtonPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.custButtonPanel1_Paint);
            // 
            // deleteCustButton
            // 
            this.deleteCustButton.AutoSize = true;
            this.deleteCustButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.deleteCustButton.BackColor = System.Drawing.Color.Black;
            this.deleteCustButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteCustButton.ForeColor = System.Drawing.Color.LightCoral;
            this.deleteCustButton.Location = new System.Drawing.Point(586, 19);
            this.deleteCustButton.Name = "deleteCustButton";
            this.deleteCustButton.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.deleteCustButton.Size = new System.Drawing.Size(93, 49);
            this.deleteCustButton.TabIndex = 2;
            this.deleteCustButton.Text = "Delete";
            this.deleteCustButton.UseVisualStyleBackColor = false;
            this.deleteCustButton.Click += new System.EventHandler(this.deleteCustButton_Click);
            // 
            // updateCustomerButton
            // 
            this.updateCustomerButton.AutoSize = true;
            this.updateCustomerButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.updateCustomerButton.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.updateCustomerButton.Location = new System.Drawing.Point(17, 19);
            this.updateCustomerButton.Name = "updateCustomerButton";
            this.updateCustomerButton.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.updateCustomerButton.Size = new System.Drawing.Size(99, 49);
            this.updateCustomerButton.TabIndex = 3;
            this.updateCustomerButton.Text = "Update";
            this.updateCustomerButton.Click += new System.EventHandler(this.updateCustomerButton_Click);
            // 
            // newCustomer
            // 
            this.newCustomer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.newCustomer.BackColor = System.Drawing.Color.Black;
            this.newCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newCustomer.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newCustomer.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.newCustomer.Location = new System.Drawing.Point(35, 506);
            this.newCustomer.Name = "newCustomer";
            this.newCustomer.Size = new System.Drawing.Size(330, 49);
            this.newCustomer.TabIndex = 0;
            this.newCustomer.Text = "Add Customer";
            this.newCustomer.UseVisualStyleBackColor = false;
            this.newCustomer.Click += new System.EventHandler(this.newCustomer_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.dataGridCustomer);
            this.panel1.Location = new System.Drawing.Point(606, 128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(679, 362);
            this.panel1.TabIndex = 1;
            // 
            // dataGridCustomer
            // 
            this.dataGridCustomer.AllowUserToResizeColumns = false;
            this.dataGridCustomer.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridCustomer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridCustomer.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridCustomer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridCustomer.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridCustomer.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dataGridCustomer.GridColor = System.Drawing.SystemColors.ControlText;
            this.dataGridCustomer.Location = new System.Drawing.Point(0, 0);
            this.dataGridCustomer.Name = "dataGridCustomer";
            this.dataGridCustomer.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridCustomer.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridCustomer.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridCustomer.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridCustomer.Size = new System.Drawing.Size(679, 362);
            this.dataGridCustomer.StandardTab = true;
            this.dataGridCustomer.TabIndex = 0;
            this.dataGridCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCustomer_CellContentClick);
            // 
            // customberDataLabel
            // 
            this.customberDataLabel.AutoSize = true;
            this.customberDataLabel.Font = new System.Drawing.Font("Myanmar Text", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customberDataLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.customberDataLabel.Location = new System.Drawing.Point(860, 72);
            this.customberDataLabel.Name = "customberDataLabel";
            this.customberDataLabel.Size = new System.Drawing.Size(185, 39);
            this.customberDataLabel.TabIndex = 2;
            this.customberDataLabel.Text = "CUSTOMER LIST";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.postalCodeLabel);
            this.panel2.Controls.Add(this.postalCodeInput);
            this.panel2.Controls.Add(this.addressInput2);
            this.panel2.Controls.Add(this.addCustomerLabel);
            this.panel2.Controls.Add(this.countryInput);
            this.panel2.Controls.Add(this.Country);
            this.panel2.Controls.Add(this.cityInput);
            this.panel2.Controls.Add(this.cityNameLabel);
            this.panel2.Controls.Add(this.addressInput);
            this.panel2.Controls.Add(this.lnameInput);
            this.panel2.Controls.Add(this.addressLabel);
            this.panel2.Controls.Add(this.phoneInput);
            this.panel2.Controls.Add(this.phoneLabel);
            this.panel2.Controls.Add(this.fnameInput);
            this.panel2.Controls.Add(this.lastNameLable);
            this.panel2.Controls.Add(this.firstNameLabel);
            this.panel2.Controls.Add(this.newCustomer);
            this.panel2.Location = new System.Drawing.Point(35, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(426, 578);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // postalCodeLabel
            // 
            this.postalCodeLabel.AutoSize = true;
            this.postalCodeLabel.Location = new System.Drawing.Point(24, 407);
            this.postalCodeLabel.Name = "postalCodeLabel";
            this.postalCodeLabel.Size = new System.Drawing.Size(107, 29);
            this.postalCodeLabel.TabIndex = 18;
            this.postalCodeLabel.Text = "Postal Code ";
            // 
            // postalCodeInput
            // 
            this.postalCodeInput.AcceptsTab = true;
            this.postalCodeInput.Location = new System.Drawing.Point(154, 398);
            this.postalCodeInput.Name = "postalCodeInput";
            this.postalCodeInput.Size = new System.Drawing.Size(211, 38);
            this.postalCodeInput.TabIndex = 6;
            // 
            // addressInput2
            // 
            this.addressInput2.AcceptsTab = true;
            this.addressInput2.Location = new System.Drawing.Point(154, 286);
            this.addressInput2.Name = "addressInput2";
            this.addressInput2.Size = new System.Drawing.Size(198, 38);
            this.addressInput2.TabIndex = 4;
            this.addressInput2.TextChanged += new System.EventHandler(this.addressInput2_TextChanged);
            // 
            // addCustomerLabel
            // 
            this.addCustomerLabel.AutoSize = true;
            this.addCustomerLabel.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCustomerLabel.Location = new System.Drawing.Point(109, 19);
            this.addCustomerLabel.Name = "addCustomerLabel";
            this.addCustomerLabel.Size = new System.Drawing.Size(163, 34);
            this.addCustomerLabel.TabIndex = 15;
            this.addCustomerLabel.Text = "ADD CUSTOMER";
            // 
            // countryInput
            // 
            this.countryInput.AcceptsTab = true;
            this.countryInput.Location = new System.Drawing.Point(154, 443);
            this.countryInput.Name = "countryInput";
            this.countryInput.Size = new System.Drawing.Size(211, 38);
            this.countryInput.TabIndex = 7;
            // 
            // Country
            // 
            this.Country.AutoSize = true;
            this.Country.Location = new System.Drawing.Point(24, 452);
            this.Country.Name = "Country";
            this.Country.Size = new System.Drawing.Size(78, 29);
            this.Country.TabIndex = 11;
            this.Country.Text = "Country ";
            // 
            // cityInput
            // 
            this.cityInput.AcceptsTab = true;
            this.cityInput.Location = new System.Drawing.Point(154, 354);
            this.cityInput.Name = "cityInput";
            this.cityInput.Size = new System.Drawing.Size(185, 38);
            this.cityInput.TabIndex = 5;
            // 
            // cityNameLabel
            // 
            this.cityNameLabel.AutoSize = true;
            this.cityNameLabel.Location = new System.Drawing.Point(30, 362);
            this.cityNameLabel.Name = "cityNameLabel";
            this.cityNameLabel.Size = new System.Drawing.Size(47, 29);
            this.cityNameLabel.TabIndex = 9;
            this.cityNameLabel.Text = "City ";
            // 
            // addressInput
            // 
            this.addressInput.AcceptsTab = true;
            this.addressInput.Location = new System.Drawing.Point(154, 242);
            this.addressInput.Name = "addressInput";
            this.addressInput.Size = new System.Drawing.Size(198, 38);
            this.addressInput.TabIndex = 3;
            this.addressInput.TextChanged += new System.EventHandler(this.addressInput_TextChanged);
            // 
            // lnameInput
            // 
            this.lnameInput.AcceptsTab = true;
            this.lnameInput.Location = new System.Drawing.Point(162, 124);
            this.lnameInput.Name = "lnameInput";
            this.lnameInput.Size = new System.Drawing.Size(240, 38);
            this.lnameInput.TabIndex = 1;
            this.lnameInput.TextChanged += new System.EventHandler(this.lnameInput_TextChanged);
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(20, 251);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(126, 29);
            this.addressLabel.TabIndex = 7;
            this.addressLabel.Text = "Street Address ";
            // 
            // phoneInput
            // 
            this.phoneInput.AcceptsTab = true;
            this.phoneInput.Location = new System.Drawing.Point(162, 172);
            this.phoneInput.Name = "phoneInput";
            this.phoneInput.Size = new System.Drawing.Size(240, 38);
            this.phoneInput.TabIndex = 2;
            this.phoneInput.TextChanged += new System.EventHandler(this.phoneInput_TextChanged);
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(20, 181);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(133, 29);
            this.phoneLabel.TabIndex = 5;
            this.phoneLabel.Text = "Phone Number ";
            // 
            // fnameInput
            // 
            this.fnameInput.AcceptsTab = true;
            this.fnameInput.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnameInput.Location = new System.Drawing.Point(163, 76);
            this.fnameInput.Name = "fnameInput";
            this.fnameInput.Size = new System.Drawing.Size(237, 38);
            this.fnameInput.TabIndex = 0;
            this.fnameInput.TextChanged += new System.EventHandler(this.fnameInput_TextChanged);
            // 
            // lastNameLable
            // 
            this.lastNameLable.AutoSize = true;
            this.lastNameLable.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLable.Location = new System.Drawing.Point(20, 128);
            this.lastNameLable.Name = "lastNameLable";
            this.lastNameLable.Size = new System.Drawing.Size(91, 27);
            this.lastNameLable.TabIndex = 3;
            this.lastNameLable.Text = "Last Name ";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.Location = new System.Drawing.Point(24, 80);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(93, 27);
            this.firstNameLabel.TabIndex = 1;
            this.firstNameLabel.Text = "First Name ";
            // 
            // exitButton
            // 
            this.exitButton.AutoSize = true;
            this.exitButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.exitButton.BackColor = System.Drawing.Color.Black;
            this.exitButton.Font = new System.Drawing.Font("Myanmar Text", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.IndianRed;
            this.exitButton.Location = new System.Drawing.Point(1178, 618);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(116, 49);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Log Out ";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.apptLookup);
            this.panel3.Location = new System.Drawing.Point(32, 596);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(426, 91);
            this.panel3.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.button1.Location = new System.Drawing.Point(248, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 65);
            this.button1.TabIndex = 62;
            this.button1.Text = "Reports";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.reportForm_Click);
            // 
            // apptLookup
            // 
            this.apptLookup.AutoSize = true;
            this.apptLookup.BackColor = System.Drawing.Color.CornflowerBlue;
            this.apptLookup.ForeColor = System.Drawing.Color.Black;
            this.apptLookup.Location = new System.Drawing.Point(17, 15);
            this.apptLookup.Name = "apptLookup";
            this.apptLookup.Size = new System.Drawing.Size(197, 65);
            this.apptLookup.TabIndex = 0;
            this.apptLookup.Text = "Appointment Calendar";
            this.apptLookup.UseVisualStyleBackColor = false;
            this.apptLookup.Click += new System.EventHandler(this.apptLookup_Click);
            // 
            // CustomerInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1330, 696);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.customberDataLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.custButtonPanel1);
            this.Controls.Add(this.panel2);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.MinimumSize = new System.Drawing.Size(26, 60);
            this.Name = "CustomerInformationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CUSTOMER INFORMATION";
            this.Load += new System.EventHandler(this.CustomerInformationForm_Load);
            this.custButtonPanel1.ResumeLayout(false);
            this.custButtonPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCustomer)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataSource)).EndInit();
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
        private System.Windows.Forms.Panel panel2;
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
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button apptLookup;
        private System.Windows.Forms.Label addCustomerLabel;
        private System.Windows.Forms.TextBox addressInput2;
        private System.Windows.Forms.Label postalCodeLabel;
        private System.Windows.Forms.TextBox postalCodeInput;
        private System.Windows.Forms.DataGridView dataGridCustomer;
        private System.Windows.Forms.Button button1;
    }
}