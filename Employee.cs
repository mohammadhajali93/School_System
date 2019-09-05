using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekaz
{
    class Employee
    {

        private String id;
        private String name;
        private String salary;
        private String start_date;
        private String end_date;
        private String role;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Salary { get => salary; set => salary = value; }
        public string Start_date { get => start_date; set => start_date = value; }
        public string End_date { get => end_date; set => end_date = value; }
        public string Role { get => role; set => role = value; }
    }
}
