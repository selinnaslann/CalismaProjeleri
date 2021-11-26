using İnsanKaynaklari.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnsanKaynaklari
{
    abstract class Employee
    {
        static int ID_counter = 0;

        private int _ID;
        private string _FullName;
        private string _PhoneNumber;
        private float _SalaryPerHour;
        private float _WorkingHours;
        public float TotalSalary;

        public int ID { get => _ID; }
        public string FullName { get => _FullName; set => _FullName = value; }
        public string PhoneNumber { get => _PhoneNumber; set => _PhoneNumber = value; }
        public float SalaryPerHour { get => _SalaryPerHour; set => _SalaryPerHour = value; }
        public float WorkingHours { get => _WorkingHours; set => _WorkingHours = value; }

        public Address address { get; set; }
        public Department department { get; set; 
        }
        
        public Employee()
        {

        }

        public Employee(string fullname, string phoneNumber, float salaryPerHour, float workingHours, float totalSalary, Address address, Department department)
        {


        }
        





    }
}
