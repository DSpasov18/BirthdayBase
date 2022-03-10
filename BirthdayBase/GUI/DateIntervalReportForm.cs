using BirthdayBase.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BirthdayBase
{
    public partial class DateIntervalReportForm : Form
    {
        public DateIntervalReportForm()
        {
            InitializeComponent();
        }

        private void buttonMake_Click(object sender, EventArgs e)
        {
            BirthInfoDao dao = new BirthInfoDao();

            dataGridView.DataSource =
                dao.GetAllFromDateToDate(dateFrom.Value, dateTo.Value)
                .DefaultView;

            dataGridView.Columns[3].Width = 250;
        }
    }
}
