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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            AddBirthday addBirthday = new AddBirthday();
            addBirthday.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateIntervalReportForm dateIntervalForm = new DateIntervalReportForm();
            dateIntervalForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BirthdayGuySerach birthdayGuySerach = new BirthdayGuySerach();
            birthdayGuySerach.Show();
        }
    }
}
