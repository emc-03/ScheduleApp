using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScheduleApp
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void userReport_Click(object sender, EventArgs e)
        {
          
                UserReportMain userReport = new UserReportMain();
                userReport.Show();
                this.Hide();
        }

        private void exitReport_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void monthlyreport_Click(object sender, EventArgs e)
        {
            try
            {
                MonthlyCurrentYearReport monthlyReportForm = new MonthlyCurrentYearReport();
                monthlyReportForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to open Monthly report: {ex.Message}");
            }
        }

        private void customerReport_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerReportMain customerReport = new CustomerReportMain();
                customerReport.Show();
                this.Hide();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Failed to open Customer Report: {ex.Message}");
            }
        }

        private void exitReport_Button_Click(object sender, EventArgs e)
        {
                this.Close();
        }
        private void Form1_Load(object sender, EventArgs e) { }
    }
}
