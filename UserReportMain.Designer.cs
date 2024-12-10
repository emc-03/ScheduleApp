
namespace ScheduleApp
{
    partial class UserReportMain
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
            this.exitReport_Button = new System.Windows.Forms.Button();
            this.userReportDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.userReportDataGrid)).BeginInit();
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
            this.exitReport_Button.Location = new System.Drawing.Point(521, 384);
            this.exitReport_Button.Name = "exitReport_Button";
            this.exitReport_Button.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.exitReport_Button.Size = new System.Drawing.Size(71, 44);
            this.exitReport_Button.TabIndex = 5;
            this.exitReport_Button.Text = "Exit";
            this.exitReport_Button.UseVisualStyleBackColor = false;
            // 
            // userReportDataGrid
            // 
            this.userReportDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userReportDataGrid.Location = new System.Drawing.Point(23, 25);
            this.userReportDataGrid.Name = "userReportDataGrid";
            this.userReportDataGrid.Size = new System.Drawing.Size(569, 353);
            this.userReportDataGrid.TabIndex = 6;
            this.userReportDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.userReportDataGrid_CellContentClick);
            // 
            // UserReportMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(612, 443);
            this.Controls.Add(this.userReportDataGrid);
            this.Controls.Add(this.exitReport_Button);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "UserReportMain";
            this.Text = "UserReportMain";
            this.Load += new System.EventHandler(this.UserReportMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userReportDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitReport_Button;
        private System.Windows.Forms.DataGridView userReportDataGrid;
    }
}