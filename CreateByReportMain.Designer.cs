
namespace ScheduleApp
{
    partial class CreateByReportMain
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
            this.dataGridCreateByReport = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCreateByReport)).BeginInit();
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
            this.exitReport_Button.Location = new System.Drawing.Point(577, 394);
            this.exitReport_Button.Name = "exitReport_Button";
            this.exitReport_Button.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.exitReport_Button.Size = new System.Drawing.Size(71, 44);
            this.exitReport_Button.TabIndex = 5;
            this.exitReport_Button.Text = "Exit";
            this.exitReport_Button.UseVisualStyleBackColor = false;
            this.exitReport_Button.Click += new System.EventHandler(this.exitReport_Button_Click);
            // 
            // dataGridCreateByReport
            // 
            this.dataGridCreateByReport.AllowUserToResizeColumns = false;
            this.dataGridCreateByReport.AllowUserToResizeRows = false;
            this.dataGridCreateByReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCreateByReport.Location = new System.Drawing.Point(12, 12);
            this.dataGridCreateByReport.Name = "dataGridCreateByReport";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridCreateByReport.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridCreateByReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridCreateByReport.Size = new System.Drawing.Size(636, 354);
            this.dataGridCreateByReport.TabIndex = 6;
            this.dataGridCreateByReport.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCreateByReport_CellContentClick);
            // 
            // CreateByReportMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(661, 450);
            this.Controls.Add(this.dataGridCreateByReport);
            this.Controls.Add(this.exitReport_Button);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Name = "CreateByReportMain";
            this.Text = "CreateByReport";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCreateByReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitReport_Button;
        private System.Windows.Forms.DataGridView dataGridCreateByReport;
    }
}