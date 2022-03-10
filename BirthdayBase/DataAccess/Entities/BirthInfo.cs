using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayBase.DataAccess.Entities
{
    internal class BirthInfo : Common
    {
        public string Name { get; set; }
        public string FathersName { get; set; }
        public string Sirname { get; set; }
        public DateTime Birthday { get; set; }
    }
}
