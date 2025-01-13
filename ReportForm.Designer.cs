
namespace ScheduleApp
{
    partial class ReportForm
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
            this.exitReport_Button = new System.Windows.Forms.Button();
            this.customerReport = new System.Windows.Forms.Button();
            this.userReport = new System.Windows.Forms.Button();
            this.monthlyreport = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
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
            this.exitReport_Button.Location = new System.Drawing.Point(221, 267);
            this.exitReport_Button.Name = "exitReport_Button";
            this.exitReport_Button.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.exitReport_Button.Size = new System.Drawing.Size(71, 44);
            this.exitReport_Button.TabIndex = 4;
            this.exitReport_Button.Text = "Exit";
            this.exitReport_Button.UseVisualStyleBackColor = false;
            this.exitReport_Button.Click += new System.EventHandler(this.exitReport_Button_Click);
            // 
            // customerReport
            // 
            this.customerReport.AutoSize = true;
            this.customerReport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.customerReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerReport.ForeColor = System.Drawing.Color.LemonChiffon;
            this.customerReport.Location = new System.Drawing.Point(72, 188);
            this.customerReport.Name = "customerReport";
            this.customerReport.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.customerReport.Size = new System.Drawing.Size(166, 44);
            this.customerReport.TabIndex = 5;
            this.customerReport.Text = "Country Report";
            this.customerReport.Click += new System.EventHandler(this.customerReport_Click);
            // 
            // userReport
            // 
            this.userReport.AutoSize = true;
            this.userReport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.userReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userReport.ForeColor = System.Drawing.Color.LemonChiffon;
            this.userReport.Location = new System.Drawing.Point(84, 69);
            this.userReport.Name = "userReport";
            this.userReport.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.userReport.Size = new System.Drawing.Size(140, 44);
            this.userReport.TabIndex = 6;
            this.userReport.Text = "User Report";
            this.userReport.Click += new System.EventHandler(this.userReport_Click);
            // 
            // monthlyreport
            // 
            this.monthlyreport.AutoSize = true;
            this.monthlyreport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.monthlyreport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthlyreport.ForeColor = System.Drawing.Color.LemonChiffon;
            this.monthlyreport.Location = new System.Drawing.Point(72, 128);
            this.monthlyreport.Name = "monthlyreport";
            this.monthlyreport.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.monthlyreport.Size = new System.Drawing.Size(167, 44);
            this.monthlyreport.TabIndex = 0;
            this.monthlyreport.Text = "Monthly Report";
            this.monthlyreport.Click += new System.EventHandler(this.monthlyreport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sans Serif Collection", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(34, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 37);
            this.label1.TabIndex = 7;
            this.label1.Text = "Select Report Option";
            this.label1.Click += new System.EventHandler(this.exitReport_Click);
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(315, 333);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthlyreport);
            this.Controls.Add(this.userReport);
            this.Controls.Add(this.exitReport_Button);
            this.Controls.Add(this.customerReport);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Name = "ReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitReport_Button;
        private System.Windows.Forms.Button customerReport;
        private System.Windows.Forms.Button userReport;
        private System.Windows.Forms.Button monthlyreport;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label1;
    }
}