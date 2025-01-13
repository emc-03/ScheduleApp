
namespace ScheduleApp
{
    partial class CountryReportMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.exitReport_Button = new System.Windows.Forms.Button();
            this.dataCountryReport = new System.Windows.Forms.DataGridView();
            this.selectedCountryLabel = new System.Windows.Forms.Label();
            this.customerDropDown = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataCountryReport)).BeginInit();
            this.SuspendLayout();
            // 
            // exitReport_Button
            // 
            this.exitReport_Button.AutoSize = true;
            this.exitReport_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.exitReport_Button.BackColor = System.Drawing.Color.Black;
            this.exitReport_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitReport_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitReport_Button.ForeColor = System.Drawing.Color.LightCoral;
            this.exitReport_Button.Location = new System.Drawing.Point(498, 394);
            this.exitReport_Button.Name = "exitReport_Button";
            this.exitReport_Button.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.exitReport_Button.Size = new System.Drawing.Size(71, 44);
            this.exitReport_Button.TabIndex = 5;
            this.exitReport_Button.Text = "Exit";
            this.exitReport_Button.UseVisualStyleBackColor = false;
            this.exitReport_Button.Click += new System.EventHandler(this.exitReport_Button_Click);
            // 
            // dataCountryReport
            // 
            this.dataCountryReport.AllowUserToResizeColumns = false;
            this.dataCountryReport.AllowUserToResizeRows = false;
            this.dataCountryReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCountryReport.Location = new System.Drawing.Point(12, 66);
            this.dataCountryReport.Name = "dataCountryReport";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataCountryReport.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataCountryReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataCountryReport.Size = new System.Drawing.Size(557, 300);
            this.dataCountryReport.TabIndex = 6;
            this.dataCountryReport.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCreateByReport_CellContentClick);
            // 
            // selectedCountryLabel
            // 
            this.selectedCountryLabel.AutoSize = true;
            this.selectedCountryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedCountryLabel.Location = new System.Drawing.Point(22, 20);
            this.selectedCountryLabel.Name = "selectedCountryLabel";
            this.selectedCountryLabel.Size = new System.Drawing.Size(94, 16);
            this.selectedCountryLabel.TabIndex = 8;
            this.selectedCountryLabel.Text = "Select Country";
            // 
            // customerDropDown
            // 
            this.customerDropDown.FormattingEnabled = true;
            this.customerDropDown.Location = new System.Drawing.Point(12, 39);
            this.customerDropDown.Name = "customerDropDown";
            this.customerDropDown.Size = new System.Drawing.Size(121, 21);
            this.customerDropDown.TabIndex = 7;
            this.customerDropDown.SelectedIndexChanged += new System.EventHandler(this.countryDropDown_SelectedIndexChanged);
            // 
            // CountryReportMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(587, 450);
            this.Controls.Add(this.selectedCountryLabel);
            this.Controls.Add(this.customerDropDown);
            this.Controls.Add(this.dataCountryReport);
            this.Controls.Add(this.exitReport_Button);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Name = "CountryReportMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Country Report";
            this.Load += new System.EventHandler(this.CountryReportMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataCountryReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitReport_Button;
        private System.Windows.Forms.DataGridView dataCountryReport;
        private System.Windows.Forms.Label selectedCountryLabel;
        private System.Windows.Forms.ComboBox customerDropDown;
    }
}