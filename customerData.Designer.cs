
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerInformationForm));
            this.customerDataSource = new System.Windows.Forms.BindingSource(this.components);
            this.custButtonPanel1 = new System.Windows.Forms.Panel();
            this.deleteCustButton = new System.Windows.Forms.Button();
            this.updateCustomerButton = new System.Windows.Forms.Button();
            this.newCustomer = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridCustomer = new System.Windows.Forms.DataGridView();
            this.customberDataLabel = new System.Windows.Forms.Label();
            this.customerSearch = new System.Windows.Forms.Button();
            this.custSearchBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.postalCodeLabel = new System.Windows.Forms.Label();
            this.postalCodeInput = new System.Windows.Forms.TextBox();
            this.addressInput2 = new System.Windows.Forms.TextBox();
            this.addCustomerLabel = new System.Windows.Forms.Label();
            this.custIdInput = new System.Windows.Forms.TextBox();
            this.customerID = new System.Windows.Forms.Label();
            this.countryInput = new System.Windows.Forms.TextBox();
            this.Country = new System.Windows.Forms.Label();
            this.cityInput = new System.Windows.Forms.TextBox();
            this.cityNameLabel = new System.Windows.Forms.Label();
            this.addressInput = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.phoneInput = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.fnameInput = new System.Windows.Forms.TextBox();
            this.lastNameLable = new System.Windows.Forms.Label();
            this.lnameInput = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.apptLookup = new System.Windows.Forms.Button();
            this.apptList = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataSource)).BeginInit();
            this.custButtonPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCustomer)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // custButtonPanel1
            // 
            this.custButtonPanel1.Controls.Add(this.deleteCustButton);
            this.custButtonPanel1.Controls.Add(this.updateCustomerButton);
            this.custButtonPanel1.Location = new System.Drawing.Point(412, 345);
            this.custButtonPanel1.Name = "custButtonPanel1";
            this.custButtonPanel1.Size = new System.Drawing.Size(730, 64);
            this.custButtonPanel1.TabIndex = 0;
            this.custButtonPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.custButtonPanel1_Paint);
            // 
            // deleteCustButton
            // 
            this.deleteCustButton.BackColor = System.Drawing.Color.Black;
            this.deleteCustButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteCustButton.ForeColor = System.Drawing.Color.LightCoral;
            this.deleteCustButton.Location = new System.Drawing.Point(615, 13);
            this.deleteCustButton.Name = "deleteCustButton";
            this.deleteCustButton.Size = new System.Drawing.Size(105, 35);
            this.deleteCustButton.TabIndex = 2;
            this.deleteCustButton.Text = "Delete";
            this.deleteCustButton.UseVisualStyleBackColor = false;
            this.deleteCustButton.Click += new System.EventHandler(this.deleteCustButton_Click);
            // 
            // updateCustomerButton
            // 
            this.updateCustomerButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.updateCustomerButton.Location = new System.Drawing.Point(15, 13);
            this.updateCustomerButton.Name = "updateCustomerButton";
            this.updateCustomerButton.Size = new System.Drawing.Size(108, 35);
            this.updateCustomerButton.TabIndex = 3;
            this.updateCustomerButton.Text = "Update";
            this.updateCustomerButton.Click += new System.EventHandler(this.updateCustomerButton_Click);
            // 
            // newCustomer
            // 
            this.newCustomer.BackColor = System.Drawing.Color.Black;
            this.newCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newCustomer.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newCustomer.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.newCustomer.Location = new System.Drawing.Point(43, 600);
            this.newCustomer.Name = "newCustomer";
            this.newCustomer.Size = new System.Drawing.Size(301, 62);
            this.newCustomer.TabIndex = 0;
            this.newCustomer.Text = "Add Customer";
            this.newCustomer.UseVisualStyleBackColor = false;
            this.newCustomer.Click += new System.EventHandler(this.newCustomer_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridCustomer);
            this.panel1.Location = new System.Drawing.Point(412, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(730, 254);
            this.panel1.TabIndex = 1;
            // 
            // dataGridCustomer
            // 
            this.dataGridCustomer.AllowUserToResizeColumns = false;
            this.dataGridCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridCustomer.Location = new System.Drawing.Point(0, 0);
            this.dataGridCustomer.Name = "dataGridCustomer";
            this.dataGridCustomer.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dataGridCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridCustomer.Size = new System.Drawing.Size(730, 254);
            this.dataGridCustomer.TabIndex = 0;
            this.dataGridCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCustomer_CellContentClick);
            // 
            // customberDataLabel
            // 
            this.customberDataLabel.AutoSize = true;
            this.customberDataLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.customberDataLabel.Location = new System.Drawing.Point(412, 36);
            this.customberDataLabel.Name = "customberDataLabel";
            this.customberDataLabel.Size = new System.Drawing.Size(177, 29);
            this.customberDataLabel.TabIndex = 2;
            this.customberDataLabel.Text = "Current Customer List";
            // 
            // customerSearch
            // 
            this.customerSearch.BackColor = System.Drawing.Color.Black;
            this.customerSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customerSearch.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerSearch.ForeColor = System.Drawing.Color.Gainsboro;
            this.customerSearch.Location = new System.Drawing.Point(1073, 35);
            this.customerSearch.Name = "customerSearch";
            this.customerSearch.Size = new System.Drawing.Size(69, 28);
            this.customerSearch.TabIndex = 3;
            this.customerSearch.Text = "SEARCH";
            this.customerSearch.UseVisualStyleBackColor = false;
            this.customerSearch.Click += new System.EventHandler(this.customerSearch_Click);
            // 
            // custSearchBox
            // 
            this.custSearchBox.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custSearchBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.custSearchBox.Location = new System.Drawing.Point(920, 39);
            this.custSearchBox.Name = "custSearchBox";
            this.custSearchBox.Size = new System.Drawing.Size(147, 22);
            this.custSearchBox.TabIndex = 4;
            this.custSearchBox.Text = "customer id";
            this.custSearchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.custSearchBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.custSearchBox_MouseClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.postalCodeLabel);
            this.panel2.Controls.Add(this.postalCodeInput);
            this.panel2.Controls.Add(this.addressInput2);
            this.panel2.Controls.Add(this.addCustomerLabel);
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
            // postalCodeLabel
            // 
            this.postalCodeLabel.AutoSize = true;
            this.postalCodeLabel.Location = new System.Drawing.Point(16, 448);
            this.postalCodeLabel.Name = "postalCodeLabel";
            this.postalCodeLabel.Size = new System.Drawing.Size(111, 29);
            this.postalCodeLabel.TabIndex = 18;
            this.postalCodeLabel.Text = "Postal Code :";
            // 
            // postalCodeInput
            // 
            this.postalCodeInput.Location = new System.Drawing.Point(133, 445);
            this.postalCodeInput.Name = "postalCodeInput";
            this.postalCodeInput.Size = new System.Drawing.Size(202, 38);
            this.postalCodeInput.TabIndex = 17;
            // 
            // addressInput2
            // 
            this.addressInput2.Location = new System.Drawing.Point(133, 320);
            this.addressInput2.Name = "addressInput2";
            this.addressInput2.Size = new System.Drawing.Size(223, 38);
            this.addressInput2.TabIndex = 16;
            // 
            // addCustomerLabel
            // 
            this.addCustomerLabel.AutoSize = true;
            this.addCustomerLabel.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCustomerLabel.Location = new System.Drawing.Point(89, 17);
            this.addCustomerLabel.Name = "addCustomerLabel";
            this.addCustomerLabel.Size = new System.Drawing.Size(143, 34);
            this.addCustomerLabel.TabIndex = 15;
            this.addCustomerLabel.Text = "Add Customer";
            // 
            // custIdInput
            // 
            this.custIdInput.Location = new System.Drawing.Point(133, 167);
            this.custIdInput.Name = "custIdInput";
            this.custIdInput.ReadOnly = true;
            this.custIdInput.Size = new System.Drawing.Size(223, 38);
            this.custIdInput.TabIndex = 14;
            this.custIdInput.TextChanged += new System.EventHandler(this.custIdInput_TextChanged);
            // 
            // customerID
            // 
            this.customerID.AutoSize = true;
            this.customerID.Location = new System.Drawing.Point(16, 176);
            this.customerID.Name = "customerID";
            this.customerID.Size = new System.Drawing.Size(111, 29);
            this.customerID.TabIndex = 13;
            this.customerID.Text = "Customer ID:";
            // 
            // countryInput
            // 
            this.countryInput.Location = new System.Drawing.Point(133, 508);
            this.countryInput.Name = "countryInput";
            this.countryInput.Size = new System.Drawing.Size(202, 38);
            this.countryInput.TabIndex = 12;
            // 
            // Country
            // 
            this.Country.AutoSize = true;
            this.Country.Location = new System.Drawing.Point(37, 511);
            this.Country.Name = "Country";
            this.Country.Size = new System.Drawing.Size(82, 29);
            this.Country.TabIndex = 11;
            this.Country.Text = "Country :";
            // 
            // cityInput
            // 
            this.cityInput.Location = new System.Drawing.Point(133, 379);
            this.cityInput.Name = "cityInput";
            this.cityInput.Size = new System.Drawing.Size(202, 38);
            this.cityInput.TabIndex = 10;
            // 
            // cityNameLabel
            // 
            this.cityNameLabel.AutoSize = true;
            this.cityNameLabel.Location = new System.Drawing.Point(68, 382);
            this.cityNameLabel.Name = "cityNameLabel";
            this.cityNameLabel.Size = new System.Drawing.Size(51, 29);
            this.cityNameLabel.TabIndex = 9;
            this.cityNameLabel.Text = "City :";
            // 
            // addressInput
            // 
            this.addressInput.Location = new System.Drawing.Point(133, 273);
            this.addressInput.Name = "addressInput";
            this.addressInput.Size = new System.Drawing.Size(223, 38);
            this.addressInput.TabIndex = 8;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(1, 276);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(130, 29);
            this.addressLabel.TabIndex = 7;
            this.addressLabel.Text = "Street Address :";
            // 
            // phoneInput
            // 
            this.phoneInput.Location = new System.Drawing.Point(133, 217);
            this.phoneInput.Name = "phoneInput";
            this.phoneInput.Size = new System.Drawing.Size(223, 38);
            this.phoneInput.TabIndex = 6;
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(-5, 226);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(137, 29);
            this.phoneLabel.TabIndex = 5;
            this.phoneLabel.Text = "Phone Number :";
            // 
            // fnameInput
            // 
            this.fnameInput.Location = new System.Drawing.Point(1, 106);
            this.fnameInput.Name = "fnameInput";
            this.fnameInput.Size = new System.Drawing.Size(168, 38);
            this.fnameInput.TabIndex = 4;
            this.fnameInput.TextChanged += new System.EventHandler(this.fnameInput_TextChanged);
            // 
            // lastNameLable
            // 
            this.lastNameLable.AutoSize = true;
            this.lastNameLable.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLable.Location = new System.Drawing.Point(219, 76);
            this.lastNameLable.Name = "lastNameLable";
            this.lastNameLable.Size = new System.Drawing.Size(91, 27);
            this.lastNameLable.TabIndex = 3;
            this.lastNameLable.Text = "Last Name ";
            // 
            // lnameInput
            // 
            this.lnameInput.Location = new System.Drawing.Point(188, 106);
            this.lnameInput.Name = "lnameInput";
            this.lnameInput.Size = new System.Drawing.Size(168, 38);
            this.lnameInput.TabIndex = 2;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.Location = new System.Drawing.Point(22, 76);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(93, 27);
            this.firstNameLabel.TabIndex = 1;
            this.firstNameLabel.Text = "First Name ";
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Black;
            this.exitButton.Location = new System.Drawing.Point(1027, 653);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(126, 51);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Log Out ";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.apptLookup);
            this.panel3.Location = new System.Drawing.Point(526, 466);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(541, 147);
            this.panel3.TabIndex = 7;
            // 
            // apptLookup
            // 
            this.apptLookup.BackColor = System.Drawing.Color.CornflowerBlue;
            this.apptLookup.ForeColor = System.Drawing.Color.Black;
            this.apptLookup.Location = new System.Drawing.Point(42, 38);
            this.apptLookup.Name = "apptLookup";
            this.apptLookup.Size = new System.Drawing.Size(463, 67);
            this.apptLookup.TabIndex = 0;
            this.apptLookup.Text = "Appointment Calendar";
            this.apptLookup.UseVisualStyleBackColor = false;
            this.apptLookup.Click += new System.EventHandler(this.apptLookup_Click);
            // 
            // apptList
            // 
            this.apptList.AutoSize = true;
            this.apptList.Location = new System.Drawing.Point(693, 434);
            this.apptList.Name = "apptList";
            this.apptList.Size = new System.Drawing.Size(199, 29);
            this.apptList.TabIndex = 8;
            this.apptList.Text = "Customer Appointments";
            // 
            // customerData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1165, 716);
            this.Controls.Add(this.apptList);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.custSearchBox);
            this.Controls.Add(this.customerSearch);
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
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCustomer)).EndInit();
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
        private System.Windows.Forms.Button customerSearch;
        private System.Windows.Forms.TextBox custSearchBox;
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
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button apptLookup;
        private System.Windows.Forms.Label apptList;
        private System.Windows.Forms.DataGridView dataGridCustomer;
        private System.Windows.Forms.Label addCustomerLabel;
        private System.Windows.Forms.TextBox addressInput2;
        private System.Windows.Forms.Label postalCodeLabel;
        private System.Windows.Forms.TextBox postalCodeInput;
    }
}