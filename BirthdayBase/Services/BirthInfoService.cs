using BirthdayBase.DataAccess;
using BirthdayBase.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayBase.Services
{
    internal class BirthInfoDao
    {
        BirthdayContext context;

        public BirthInfoDao() : this(new BirthdayContext())
        {
            
        }
        public BirthInfoDao(BirthdayContext context)
        {
            this.context = context;
        }

        public void InsertBirthday(string Name, string FathersName, string Sirname, DateTime BirthDate)
        {
            context.Birthdays.Add(new BirthInfo()
            {
                Name = Name,
                FathersName = FathersName,
                Sirname = Sirname,
                Birthday = BirthDate
            });

            context.SaveChanges();
        }

        public DataTable GetAllFromDateToDate(DateTime From, DateTime To)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Име");
            dataTable.Columns.Add("Презиме");
            dataTable.Columns.Add("Фамилия");
            dataTable.Columns.Add("Рожден ден");

            List<BirthInfo> birthList = context.Birthdays.ToList();
            birthList =  birthList.Where(b => CheckInterval(b.Birthday, From, To)).ToList();

            foreach(BirthInfo bi in birthList)
            {
                dataTable.Rows.Add(
                    bi.Name,
                    bi.FathersName,
                    bi.Sirname,
                    bi.Birthday
                );
            }

            return dataTable;
        }

        public DataTable FindByName(string Name)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Име");
            dataTable.Columns.Add("Презиме");
            dataTable.Columns.Add("Фамилия");
            dataTable.Columns.Add("Рожден ден");

            List<BirthInfo> birthList = context.Birthdays.ToList();
            Name = Name.Trim().ToLower();
            birthList = birthList
                .Where(
                    b => b.Name.ToLower().Contains(Name) ||
                    b.FathersName.ToLower().Contains(Name) || 
                    b.Sirname.ToLower().Contains(Name)).ToList();

            foreach (BirthInfo bi in birthList)
            {
                dataTable.Rows.Add(
                    bi.Name,
                    bi.FathersName,
                    bi.Sirname,
                    bi.Birthday
                );
            }

            return dataTable;
        }
        private bool CheckInterval(DateTime Birthday, DateTime From, DateTime To)
        {
            Birthday = new DateTime(2004, Birthday.Month, Birthday.Day);
            From = new DateTime(2004, From.Month, From.Day);
            To = new DateTime(2004, To.Month, To.Day);

            return Birthday >= From && Birthday <= To;
        }
    }
}
