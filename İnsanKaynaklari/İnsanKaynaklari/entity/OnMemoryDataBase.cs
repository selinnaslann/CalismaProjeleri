using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnsanKaynaklari.entity
{
    class OnMemoryDataBase
    {
        public static SortedDictionary<int, Employee> addresses = new SortedDictionary<int, Employee>();
        public static SortedDictionary<int, Employee> departments = new SortedDictionary<int, Employee>();
        public static SortedDictionary<int, Employee> employees = new SortedDictionary<int, Employee>();
        public static SortedDictionary<int, Employee> tasks = new SortedDictionary<int, Employee>();

    }
}
