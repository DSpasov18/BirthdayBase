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
    public partial class AddBirthday : Form
    {
        public AddBirthday()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            BirthInfoDao dao = new BirthInfoDao();
            dao.InsertBirthday(
                textName.Text,
                textFathersName.Text,
                textSirname.Text,
                dateBirth.Value
                );

            MessageBox.Show("Рожденикът е добавен успешно.");
        }

        private void AddBirthday_Load(object sender, EventArgs e)
        {

        }
    }
}
