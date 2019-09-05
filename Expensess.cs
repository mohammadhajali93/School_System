using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekaz
{
    class Expensess
    {
        private String id;
        private String name_exp;
        private String date_exp;
        private String new_type_exp;
        private String name_consumer;
        private String month;
        private String year;
        private String day;



        public string Id { get => id; set => id = value; }
        public string Name_exp { get => name_exp; set => name_exp = value; }
        public string Date_exp { get => date_exp; set => date_exp = value; }
        public string New_type_exp { get => new_type_exp; set => new_type_exp = value; }
        public string Name_consumer { get => name_consumer; set => name_consumer = value; }
        public string Month { get => month; set => month = value; }
        public string Year { get => year; set => year = value; }
        public string Day { get => day; set => day = value; }
    }
}
