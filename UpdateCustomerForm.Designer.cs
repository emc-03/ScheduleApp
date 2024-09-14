
namespace ScheduleApp
{
    public partial class UpdateCustomerForm
    {
        private System.Windows.Forms.TextBox UpcountryInput;
        private System.Windows.Forms.Label upCountryLabel;
        private System.Windows.Forms.TextBox UpcityInput;
        private System.Windows.Forms.Label upCityLabel;
        private System.Windows.Forms.TextBox UpaddressInput;
        private System.Windows.Forms.Label upAddressLabel;
        private System.Windows.Forms.TextBox Upaddress2Input;
        private System.Windows.Forms.TextBox UpPhoneInput;
        private System.Windows.Forms.Label upPhoneLabel;
        private System.Windows.Forms.TextBox UpfnameInput;
        private System.Windows.Forms.Label uplnLabel;
        private System.Windows.Forms.TextBox UplnameInput;
        private System.Windows.Forms.Label upfnLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button upCancelButton;
        private System.Windows.Forms.Button updateCButton;
        private System.Windows.Forms.Label updateHeader;
        private System.Windows.Forms.Label postalCLabel;
        private System.Windows.Forms.TextBox postalCodeInput;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateCustomerForm));
            //UpdateCustomerForm updateCustomerForm = this;
            this.UpcountryInput = new System.Windows.Forms.TextBox();
            this.upCountryLabel = new System.Windows.Forms.Label();
            this.UpcityInput = new System.Windows.Forms.TextBox();
            this.upCityLabel = new System.Windows.Forms.Label();
            this.UpaddressInput = new System.Windows.Forms.TextBox();
            this.upAddressLabel = new System.Windows.Forms.Label();
            this.Upaddress2Input = new System.Windows.Forms.TextBox();
            this.UpPhoneInput = new System.Windows.Forms.TextBox();
            this.upPhoneLabel = new System.Windows.Forms.Label();
            this.UpfnameInput = new System.Windows.Forms.TextBox();
            this.uplnLabel = new System.Windows.Forms.Label();
            this.UplnameInput = new System.Windows.Forms.TextBox();
            this.upfnLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.postalCLabel = new System.Windows.Forms.Label();
            this.postalCodeInput = new System.Windows.Forms.TextBox();
            this.upCancelButton = new System.Windows.Forms.Button();
            this.updateCButton = new System.Windows.Forms.Button();
            this.updateHeader = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UpcountryInput
            // 
            this.UpcountryInput.Location = new System.Drawing.Point(153, 440);
            this.UpcountryInput.Name = "UpcountryInput";
            this.UpcountryInput.Size = new System.Drawing.Size(202, 38);
            this.UpcountryInput.TabIndex = 26;
            //updateCustomerForm.UpcountryInput.Text = updateCustomerForm.customerToUpdate.Address.City.Country.Name;
            // 
            // upCountryLabel
            // 
            this.upCountryLabel.AutoSize = true;
            this.upCountryLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.upCountryLabel.Location = new System.Drawing.Point(50, 443);
            this.upCountryLabel.Name = "upCountryLabel";
            this.upCountryLabel.Size = new System.Drawing.Size(82, 29);
            this.upCountryLabel.TabIndex = 25;
            this.upCountryLabel.Text = "Country :";
            // 
            // UpcityInput
            // 
            this.UpcityInput.Location = new System.Drawing.Point(153, 319);
            this.UpcityInput.Name = "UpcityInput";
            this.UpcityInput.Size = new System.Drawing.Size(202, 38);
            this.UpcityInput.TabIndex = 24;
            //updateCustomerForm.UpcityInput.Text = updateCustomerForm.customerToUpdate.Address.City.Name;
            // 
            // upCityLabel
            // 
            this.upCityLabel.AutoSize = true;
            this.upCityLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.upCityLabel.Location = new System.Drawing.Point(81, 328);
            this.upCityLabel.Name = "upCityLabel";
            this.upCityLabel.Size = new System.Drawing.Size(51, 29);
            this.upCityLabel.TabIndex = 23;
            this.upCityLabel.Text = "City :";
            // 
            // UpaddressInput
            // 
            this.UpaddressInput.Location = new System.Drawing.Point(153, 214);
            this.UpaddressInput.Name = "UpaddressInput";
            this.UpaddressInput.Size = new System.Drawing.Size(223, 38);
            this.UpaddressInput.TabIndex = 22;
            //updateCustomerForm.UpaddressInput.Text = updateCustomerForm.customerToUpdate.Address.Address1;
            // 
            // upAddressLabel
            // 
            this.upAddressLabel.AutoSize = true;
            this.upAddressLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.upAddressLabel.Location = new System.Drawing.Point(10, 217);
            this.upAddressLabel.Name = "upAddressLabel";
            this.upAddressLabel.Size = new System.Drawing.Size(130, 29);
            this.upAddressLabel.TabIndex = 21;
            this.upAddressLabel.Text = "Street Address :";
            // 
            // Upaddress2Input
            // 
            this.Upaddress2Input.Location = new System.Drawing.Point(153, 267);
            this.Upaddress2Input.Name = "Upaddress2Input";
            this.Upaddress2Input.Size = new System.Drawing.Size(223, 38);
            this.Upaddress2Input.TabIndex = 22;
            //updateCustomerForm.Upaddress2Input.Text = updateCustomerForm.customerToUpdate.Address.Address2;
            // 
            // UpPhoneInput
            // 
            this.UpPhoneInput.Location = new System.Drawing.Point(153, 153);
            this.UpPhoneInput.Name = "UpPhoneInput";
            this.UpPhoneInput.Size = new System.Drawing.Size(223, 38);
            this.UpPhoneInput.TabIndex = 20;
            this.UpPhoneInput.TextChanged += new System.EventHandler(this.UpPhoneInput_TextChanged);
            //updateCustomerForm.UpPhoneInput.Text = updateCustomerForm.customerToUpdate.Address.PhoneNumber;
            // 
            // upPhoneLabel
            // 
            this.upPhoneLabel.AutoSize = true;
            this.upPhoneLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.upPhoneLabel.Location = new System.Drawing.Point(10, 162);
            this.upPhoneLabel.Name = "upPhoneLabel";
            this.upPhoneLabel.Size = new System.Drawing.Size(137, 29);
            this.upPhoneLabel.TabIndex = 19;
            this.upPhoneLabel.Text = "Phone Number :";
            // 
            // UpfnameInput
            // 
            this.UpfnameInput.Location = new System.Drawing.Point(8, 89);
            this.UpfnameInput.Name = "UpfnameInput";
            this.UpfnameInput.Size = new System.Drawing.Size(168, 38);
            this.UpfnameInput.TabIndex = 18;
            this.UpfnameInput.TextChanged += new System.EventHandler(this.UpfnameInput_TextChanged);
            //updateCustomerForm.UpfnameInput.Text = updateCustomerForm.customerToUpdate.FirstName;
            // 
            // uplnLabel
            // 
            this.uplnLabel.AutoSize = true;
            this.uplnLabel.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uplnLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.uplnLabel.Location = new System.Drawing.Point(257, 59);
            this.uplnLabel.Name = "uplnLabel";
            this.uplnLabel.Size = new System.Drawing.Size(91, 27);
            this.uplnLabel.TabIndex = 17;
            this.uplnLabel.Text = "Last Name ";
            // 
            // UplnameInput
            // 
            this.UplnameInput.Location = new System.Drawing.Point(205, 89);
            this.UplnameInput.Name = "UplnameInput";
            this.UplnameInput.Size = new System.Drawing.Size(168, 38);
            this.UplnameInput.TabIndex = 16;
            //updateCustomerForm.UplnameInput.Text = updateCustomerForm.customerToUpdate.LastName;
            // 
            // upfnLabel
            // 
            this.upfnLabel.AutoSize = true;
            this.upfnLabel.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upfnLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.upfnLabel.Location = new System.Drawing.Point(39, 59);
            this.upfnLabel.Name = "upfnLabel";
            this.upfnLabel.Size = new System.Drawing.Size(93, 27);
            this.upfnLabel.TabIndex = 15;
            this.upfnLabel.Text = "First Name ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.postalCLabel);
            this.panel1.Controls.Add(this.postalCodeInput);
            this.panel1.Controls.Add(this.upCancelButton);
            this.panel1.Controls.Add(this.updateCButton);
            this.panel1.Controls.Add(this.updateHeader);
            this.panel1.Controls.Add(this.upPhoneLabel);
            this.panel1.Controls.Add(this.upfnLabel);
            this.panel1.Controls.Add(this.UplnameInput);
            this.panel1.Controls.Add(this.UpcountryInput);
            this.panel1.Controls.Add(this.uplnLabel);
            this.panel1.Controls.Add(this.upCountryLabel);
            this.panel1.Controls.Add(this.UpfnameInput);
            this.panel1.Controls.Add(this.UpcityInput);
            this.panel1.Controls.Add(this.UpPhoneInput);
            this.panel1.Controls.Add(this.upCityLabel);
            this.panel1.Controls.Add(this.upAddressLabel);
            this.panel1.Controls.Add(this.UpaddressInput);
            this.panel1.Controls.Add(this.Upaddress2Input);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 607);
            this.panel1.TabIndex = 29;
            // 
            // postalCLabel
            // 
            this.postalCLabel.AutoSize = true;
            this.postalCLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.postalCLabel.Location = new System.Drawing.Point(25, 388);
            this.postalCLabel.Name = "postalCLabel";
            this.postalCLabel.Size = new System.Drawing.Size(111, 29);
            this.postalCLabel.TabIndex = 33;
            this.postalCLabel.Text = "Postal Code :";
            // 
            // postalCodeInput
            // 
            this.postalCodeInput.Location = new System.Drawing.Point(153, 379);
            this.postalCodeInput.Name = "postalCodeInput";
            this.postalCodeInput.Size = new System.Drawing.Size(202, 38);
            this.postalCodeInput.TabIndex = 32;
            //updateCustomerForm.postalCodeInput.Text = updateCustomerForm.customerToUpdate.Address.PostalCode;
            // 
            // upCancelButton
            // 
            this.upCancelButton.BackColor = System.Drawing.Color.Black;
            this.upCancelButton.ForeColor = System.Drawing.Color.IndianRed;
            this.upCancelButton.Location = new System.Drawing.Point(275, 531);
            this.upCancelButton.Name = "upCancelButton";
            this.upCancelButton.Size = new System.Drawing.Size(123, 60);
            this.upCancelButton.TabIndex = 31;
            this.upCancelButton.Text = "CANCEL";
            this.upCancelButton.UseVisualStyleBackColor = false;
            this.upCancelButton.Click += new System.EventHandler(this.upCancelButton_Click);
            // 
            // updateCButton
            // 
            this.updateCButton.BackColor = System.Drawing.Color.Black;
            this.updateCButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.updateCButton.Location = new System.Drawing.Point(21, 531);
            this.updateCButton.Name = "updateCButton";
            this.updateCButton.Size = new System.Drawing.Size(123, 60);
            this.updateCButton.TabIndex = 30;
            this.updateCButton.Text = "SAVE";
            this.updateCButton.UseVisualStyleBackColor = false;
            this.updateCButton.Click += new System.EventHandler(this.updateCButton_Click);
            // 
            // updateHeader
            // 
            this.updateHeader.AutoSize = true;
            this.updateHeader.ForeColor = System.Drawing.Color.Gainsboro;
            this.updateHeader.Location = new System.Drawing.Point(123, 8);
            this.updateHeader.Name = "updateHeader";
            this.updateHeader.Size = new System.Drawing.Size(166, 29);
            this.updateHeader.TabIndex = 29;
            this.updateHeader.Text = "UPDATE CUSTOMER";
            this.updateHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UpdateCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(429, 620);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.Name = "UpdateCustomerForm";
            this.Text = "Update Customer";
            this.Load += new System.EventHandler(this.UpdateCustomerForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

    }
}