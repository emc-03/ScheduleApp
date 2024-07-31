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
    public partial class ApptType : Form
    {
        public ApptType()
        {
            InitializeComponent();
        }

        private void ApptType_Load(object sender, EventArgs e)
        {

        }

        private void CreateCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            //calendarForm calendar = new calendarForm();
            //calendar.Show();
        }
    }
}
