using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnsanKaynaklari.entity
{
    class Department
    {
        static int ID_counter = 0;

        private int _ID;
        private string _Name;
        private Manager _HeadOf;
        public int ID { get => _ID; }
        public string Name { get => _Name; set => _Name = value; }
        public Manager HeadOf { get => _HeadOf; set => _HeadOf = value; }

        public List<Employee> Employees = new List<Employee>();
        public Department()
        {

        }
        public Department(int id,string name,Manager headOf)
        {
            int ID = id;
            string Name = name;
            HeadOf = headOf;
            Employees = new List<Employee>();
        }
    }
    
    
}
