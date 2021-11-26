using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnsanKaynaklari.entity
{
    class Worker:Employee
    {
        public List<Mission> Missions { get; set; }

        public Worker()
        {
            Missions = new List<Mission>();
        }

        public Worker(string fullname,string phoneNumber,float salaryPerHour,float workingHours,float totalSalary,Address address,Department department):base(fullname, phoneNumber, salaryPerHour, workingHours, totalSalary, address, department)
        {
            FullName = fullname;

        }
        
        public void Assign(Mission mission)
        {
            Missions.Add(mission);
        }

        


    }
}
