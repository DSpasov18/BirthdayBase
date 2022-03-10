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
    public partial class BirthdayGuySerach : Form
    {
        public BirthdayGuySerach()
        {
            InitializeComponent();
        }

        private void buttonMake_Click(object sender, EventArgs e)
        {
            BirthInfoDao dao = new BirthInfoDao();

            dataGridView.DataSource =
                dao.FindByName(textFilter.Text)
                .DefaultView;

            dataGridView.Columns[3].Width = 250;
        }
    }
}
