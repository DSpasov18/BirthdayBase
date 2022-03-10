using BirthdayBase.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayBase.DataAccess
{
    internal class BirthdayContext : DbContext
    {
        public BirthdayContext() : base("BirthdayInfoContext")
        {
        }

        public DbSet<BirthInfo> Birthdays { get; set; }
    }
}
