
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
            UpdateCustomerForm updateCustomerForm = this;
            updateCustomerForm.UpcountryInput = new System.Windows.Forms.TextBox();
            updateCustomerForm.upCountryLabel = new System.Windows.Forms.Label();
            updateCustomerForm.UpcityInput = new System.Windows.Forms.TextBox();
            updateCustomerForm.upCityLabel = new System.Windows.Forms.Label();
            updateCustomerForm.UpaddressInput = new System.Windows.Forms.TextBox();
            updateCustomerForm.upAddressLabel = new System.Windows.Forms.Label();
            updateCustomerForm.Upaddress2Input = new System.Windows.Forms.TextBox();
            updateCustomerForm.UpPhoneInput = new System.Windows.Forms.TextBox();
            updateCustomerForm.upPhoneLabel = new System.Windows.Forms.Label();
            updateCustomerForm.UpfnameInput = new System.Windows.Forms.TextBox();
            updateCustomerForm.uplnLabel = new System.Windows.Forms.Label();
            updateCustomerForm.UplnameInput = new System.Windows.Forms.TextBox();
            updateCustomerForm.upfnLabel = new System.Windows.Forms.Label();
            updateCustomerForm.panel1 = new System.Windows.Forms.Panel();
            updateCustomerForm.postalCLabel = new System.Windows.Forms.Label();
            updateCustomerForm.postalCodeInput = new System.Windows.Forms.TextBox();
            updateCustomerForm.upCancelButton = new System.Windows.Forms.Button();
            updateCustomerForm.updateCButton = new System.Windows.Forms.Button();
            updateCustomerForm.updateHeader = new System.Windows.Forms.Label();
            updateCustomerForm.panel1.SuspendLayout();
            updateCustomerForm.SuspendLayout();
            // 
            // UpcountryInput
            // 
            updateCustomerForm.UpcountryInput.Location = new System.Drawing.Point(153, 440);
            updateCustomerForm.UpcountryInput.Name = "UpcountryInput";
            updateCustomerForm.UpcountryInput.Size = new System.Drawing.Size(202, 38);
            updateCustomerForm.UpcountryInput.TabIndex = 26;
            updateCustomerForm.UpcountryInput.Text = updateCustomerForm.customerToUpdate.Address.City.Country.Name;
            // 
            // upCountryLabel
            // 
            updateCustomerForm.upCountryLabel.AutoSize = true;
            updateCustomerForm.upCountryLabel.ForeColor = System.Drawing.Color.Gainsboro;
            updateCustomerForm.upCountryLabel.Location = new System.Drawing.Point(50, 443);
            updateCustomerForm.upCountryLabel.Name = "upCountryLabel";
            updateCustomerForm.upCountryLabel.Size = new System.Drawing.Size(82, 29);
            updateCustomerForm.upCountryLabel.TabIndex = 25;
            updateCustomerForm.upCountryLabel.Text = "Country :";
            // 
            // UpcityInput
            // 
            updateCustomerForm.UpcityInput.Location = new System.Drawing.Point(153, 319);
            updateCustomerForm.UpcityInput.Name = "UpcityInput";
            updateCustomerForm.UpcityInput.Size = new System.Drawing.Size(202, 38);
            updateCustomerForm.UpcityInput.TabIndex = 24;
            updateCustomerForm.UpcityInput.Text = updateCustomerForm.customerToUpdate.Address.City.Name;
            // 
            // upCityLabel
            // 
            updateCustomerForm.upCityLabel.AutoSize = true;
            updateCustomerForm.upCityLabel.ForeColor = System.Drawing.Color.Gainsboro;
            updateCustomerForm.upCityLabel.Location = new System.Drawing.Point(81, 328);
            updateCustomerForm.upCityLabel.Name = "upCityLabel";
            updateCustomerForm.upCityLabel.Size = new System.Drawing.Size(51, 29);
            updateCustomerForm.upCityLabel.TabIndex = 23;
            updateCustomerForm.upCityLabel.Text = "City :";
            // 
            // UpaddressInput
            // 
            updateCustomerForm.UpaddressInput.Location = new System.Drawing.Point(153, 214);
            updateCustomerForm.UpaddressInput.Name = "UpaddressInput";
            updateCustomerForm.UpaddressInput.Size = new System.Drawing.Size(223, 38);
            updateCustomerForm.UpaddressInput.TabIndex = 22;
            updateCustomerForm.UpaddressInput.Text = updateCustomerForm.customerToUpdate.Address.Address1;
            // 
            // upAddressLabel
            // 
            updateCustomerForm.upAddressLabel.AutoSize = true;
            updateCustomerForm.upAddressLabel.ForeColor = System.Drawing.Color.Gainsboro;
            updateCustomerForm.upAddressLabel.Location = new System.Drawing.Point(10, 217);
            updateCustomerForm.upAddressLabel.Name = "upAddressLabel";
            updateCustomerForm.upAddressLabel.Size = new System.Drawing.Size(130, 29);
            updateCustomerForm.upAddressLabel.TabIndex = 21;
            updateCustomerForm.upAddressLabel.Text = "Street Address :";
            // 
            // Upaddress2Input
            // 
            updateCustomerForm.Upaddress2Input.Location = new System.Drawing.Point(153, 267);
            updateCustomerForm.Upaddress2Input.Name = "Upaddress2Input";
            updateCustomerForm.Upaddress2Input.Size = new System.Drawing.Size(223, 38);
            updateCustomerForm.Upaddress2Input.TabIndex = 22;
            updateCustomerForm.Upaddress2Input.Text = updateCustomerForm.customerToUpdate.Address.Address2;
            // 
            // UpPhoneInput
            // 
            updateCustomerForm.UpPhoneInput.Location = new System.Drawing.Point(153, 153);
            updateCustomerForm.UpPhoneInput.Name = "UpPhoneInput";
            updateCustomerForm.UpPhoneInput.Size = new System.Drawing.Size(223, 38);
            updateCustomerForm.UpPhoneInput.TabIndex = 20;
            updateCustomerForm.UpPhoneInput.TextChanged += new System.EventHandler(updateCustomerForm.UpPhoneInput_TextChanged);
            updateCustomerForm.UpPhoneInput.Text = updateCustomerForm.customerToUpdate.Address.PhoneNumber;
            // 
            // upPhoneLabel
            // 
            updateCustomerForm.upPhoneLabel.AutoSize = true;
            updateCustomerForm.upPhoneLabel.ForeColor = System.Drawing.Color.Gainsboro;
            updateCustomerForm.upPhoneLabel.Location = new System.Drawing.Point(10, 162);
            updateCustomerForm.upPhoneLabel.Name = "upPhoneLabel";
            updateCustomerForm.upPhoneLabel.Size = new System.Drawing.Size(137, 29);
            updateCustomerForm.upPhoneLabel.TabIndex = 19;
            updateCustomerForm.upPhoneLabel.Text = "Phone Number :";
            // 
            // UpfnameInput
            // 
            updateCustomerForm.UpfnameInput.Location = new System.Drawing.Point(8, 89);
            updateCustomerForm.UpfnameInput.Name = "UpfnameInput";
            updateCustomerForm.UpfnameInput.Size = new System.Drawing.Size(168, 38);
            updateCustomerForm.UpfnameInput.TabIndex = 18;
            updateCustomerForm.UpfnameInput.TextChanged += new System.EventHandler(updateCustomerForm.UpfnameInput_TextChanged);
            updateCustomerForm.UpfnameInput.Text = updateCustomerForm.customerToUpdate.FirstName;
            // 
            // uplnLabel
            // 
            updateCustomerForm.uplnLabel.AutoSize = true;
            updateCustomerForm.uplnLabel.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            updateCustomerForm.uplnLabel.ForeColor = System.Drawing.Color.Gainsboro;
            updateCustomerForm.uplnLabel.Location = new System.Drawing.Point(257, 59);
            updateCustomerForm.uplnLabel.Name = "uplnLabel";
            updateCustomerForm.uplnLabel.Size = new System.Drawing.Size(91, 27);
            updateCustomerForm.uplnLabel.TabIndex = 17;
            updateCustomerForm.uplnLabel.Text = "Last Name ";
            // 
            // UplnameInput
            // 
            updateCustomerForm.UplnameInput.Location = new System.Drawing.Point(205, 89);
            updateCustomerForm.UplnameInput.Name = "UplnameInput";
            updateCustomerForm.UplnameInput.Size = new System.Drawing.Size(168, 38);
            updateCustomerForm.UplnameInput.TabIndex = 16;
            updateCustomerForm.UplnameInput.Text = updateCustomerForm.customerToUpdate.LastName;
            // 
            // upfnLabel
            // 
            updateCustomerForm.upfnLabel.AutoSize = true;
            updateCustomerForm.upfnLabel.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            updateCustomerForm.upfnLabel.ForeColor = System.Drawing.Color.Gainsboro;
            updateCustomerForm.upfnLabel.Location = new System.Drawing.Point(39, 59);
            updateCustomerForm.upfnLabel.Name = "upfnLabel";
            updateCustomerForm.upfnLabel.Size = new System.Drawing.Size(93, 27);
            updateCustomerForm.upfnLabel.TabIndex = 15;
            updateCustomerForm.upfnLabel.Text = "First Name ";
            // 
            // panel1
            // 
            updateCustomerForm.panel1.Controls.Add(updateCustomerForm.postalCLabel);
            updateCustomerForm.panel1.Controls.Add(updateCustomerForm.postalCodeInput);
            updateCustomerForm.panel1.Controls.Add(updateCustomerForm.upCancelButton);
            updateCustomerForm.panel1.Controls.Add(updateCustomerForm.updateCButton);
            updateCustomerForm.panel1.Controls.Add(updateCustomerForm.updateHeader);
            updateCustomerForm.panel1.Controls.Add(updateCustomerForm.upPhoneLabel);
            updateCustomerForm.panel1.Controls.Add(updateCustomerForm.upfnLabel);
            updateCustomerForm.panel1.Controls.Add(updateCustomerForm.UplnameInput);
            updateCustomerForm.panel1.Controls.Add(updateCustomerForm.UpcountryInput);
            updateCustomerForm.panel1.Controls.Add(updateCustomerForm.uplnLabel);
            updateCustomerForm.panel1.Controls.Add(updateCustomerForm.upCountryLabel);
            updateCustomerForm.panel1.Controls.Add(updateCustomerForm.UpfnameInput);
            updateCustomerForm.panel1.Controls.Add(updateCustomerForm.UpcityInput);
            updateCustomerForm.panel1.Controls.Add(updateCustomerForm.UpPhoneInput);
            updateCustomerForm.panel1.Controls.Add(updateCustomerForm.upCityLabel);
            updateCustomerForm.panel1.Controls.Add(updateCustomerForm.upAddressLabel);
            updateCustomerForm.panel1.Controls.Add(updateCustomerForm.UpaddressInput);
            updateCustomerForm.panel1.Controls.Add(updateCustomerForm.Upaddress2Input);
            updateCustomerForm.panel1.Location = new System.Drawing.Point(2, 1);
            updateCustomerForm.panel1.Name = "panel1";
            updateCustomerForm.panel1.Size = new System.Drawing.Size(424, 607);
            updateCustomerForm.panel1.TabIndex = 29;
            // 
            // postalCLabel
            // 
            updateCustomerForm.postalCLabel.AutoSize = true;
            updateCustomerForm.postalCLabel.ForeColor = System.Drawing.Color.Gainsboro;
            updateCustomerForm.postalCLabel.Location = new System.Drawing.Point(25, 388);
            updateCustomerForm.postalCLabel.Name = "postalCLabel";
            updateCustomerForm.postalCLabel.Size = new System.Drawing.Size(111, 29);
            updateCustomerForm.postalCLabel.TabIndex = 33;
            updateCustomerForm.postalCLabel.Text = "Postal Code :";
            // 
            // postalCodeInput
            // 
            updateCustomerForm.postalCodeInput.Location = new System.Drawing.Point(153, 379);
            updateCustomerForm.postalCodeInput.Name = "postalCodeInput";
            updateCustomerForm.postalCodeInput.Size = new System.Drawing.Size(202, 38);
            updateCustomerForm.postalCodeInput.TabIndex = 32;
            updateCustomerForm.postalCodeInput.Text = updateCustomerForm.customerToUpdate.Address.PostalCode;
            // 
            // upCancelButton
            // 
            updateCustomerForm.upCancelButton.BackColor = System.Drawing.Color.Black;
            updateCustomerForm.upCancelButton.ForeColor = System.Drawing.Color.IndianRed;
            updateCustomerForm.upCancelButton.Location = new System.Drawing.Point(275, 531);
            updateCustomerForm.upCancelButton.Name = "upCancelButton";
            updateCustomerForm.upCancelButton.Size = new System.Drawing.Size(123, 60);
            updateCustomerForm.upCancelButton.TabIndex = 31;
            updateCustomerForm.upCancelButton.Text = "CANCEL";
            updateCustomerForm.upCancelButton.UseVisualStyleBackColor = false;
            updateCustomerForm.upCancelButton.Click += new System.EventHandler(updateCustomerForm.upCancelButton_Click);
            // 
            // updateCButton
            // 
            updateCustomerForm.updateCButton.BackColor = System.Drawing.Color.Black;
            updateCustomerForm.updateCButton.ForeColor = System.Drawing.Color.DodgerBlue;
            updateCustomerForm.updateCButton.Location = new System.Drawing.Point(21, 531);
            updateCustomerForm.updateCButton.Name = "updateCButton";
            updateCustomerForm.updateCButton.Size = new System.Drawing.Size(123, 60);
            updateCustomerForm.updateCButton.TabIndex = 30;
            updateCustomerForm.updateCButton.Text = "SAVE";
            updateCustomerForm.updateCButton.UseVisualStyleBackColor = false;
            updateCustomerForm.updateCButton.Click += new System.EventHandler(updateCustomerForm.updateCButton_Click);
            // 
            // updateHeader
            // 
            updateCustomerForm.updateHeader.AutoSize = true;
            updateCustomerForm.updateHeader.ForeColor = System.Drawing.Color.Gainsboro;
            updateCustomerForm.updateHeader.Location = new System.Drawing.Point(123, 8);
            updateCustomerForm.updateHeader.Name = "updateHeader";
            updateCustomerForm.updateHeader.Size = new System.Drawing.Size(166, 29);
            updateCustomerForm.updateHeader.TabIndex = 29;
            updateCustomerForm.updateHeader.Text = "UPDATE CUSTOMER";
            updateCustomerForm.updateHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UpdateCustomerForm
            // 
            updateCustomerForm.AutoScaleDimensions = new System.Drawing.SizeF(10F, 29F);
            updateCustomerForm.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            updateCustomerForm.BackColor = System.Drawing.Color.Black;
            updateCustomerForm.ClientSize = new System.Drawing.Size(429, 620);
            updateCustomerForm.Controls.Add(updateCustomerForm.panel1);
            updateCustomerForm.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            updateCustomerForm.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            updateCustomerForm.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            updateCustomerForm.Name = "UpdateCustomerForm";
            updateCustomerForm.Text = "Update Customer";
            updateCustomerForm.Load += new System.EventHandler(updateCustomerForm.UpdateCustomerForm_Load);
            updateCustomerForm.panel1.ResumeLayout(false);
            updateCustomerForm.panel1.PerformLayout();
            updateCustomerForm.ResumeLayout(false);

        }

        #endregion

    }
}