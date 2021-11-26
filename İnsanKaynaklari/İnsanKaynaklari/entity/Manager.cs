using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnsanKaynaklari.entity
{
    class Manager:Employee
    {
        private string _DepartmantManages;
        private Rank _Rank;

        internal Rank Rank { get => _Rank; set => _Rank = value; }
        public string DepartmantManages { get => _DepartmantManages; set => _DepartmantManages = value; }
        public int SpanOfControl { get => _SpanOfControl; set => _SpanOfControl = value; }

        public Manager manager;

        private int _SpanOfControl;

        public Manager()
        {

        }
    }
}
