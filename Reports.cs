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
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void userReport_Click(object sender, EventArgs e)
        {
            try
            {
                UserReportMain userReport = new UserReportMain();
                userReport.Show();
                this.Hide();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Failed to open User Report: {ex.Message}");
            }
          

        }

        private void exitReport_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }


        private void monthlyreport_Click(object sender, EventArgs e)
        {
            try
            {
                MonthlyReportMain monthlyReportForm = new MonthlyReportMain();
                monthlyReportForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to open Monthly report: {ex.Message}");
                
            }
            
           
        }


        private void createByReport_Click(object sender, EventArgs e)
        {
            try
            {
                CreateByReportMain createByReport = new CreateByReportMain();
                createByReport.Show();
                this.Hide();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Failed to open CreateBy Report: {ex.Message}");
            }
         
        }
    }
}
