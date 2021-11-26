using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnsanKaynaklari.entity
{
    class Mission
    {
        static int ID_counter = 0;

        private DateTime _DeadLine;
        private string _Description;
        private int _ID;


        public DateTime DeadLine { get => _DeadLine; set => _DeadLine = value; }
        public string Description { get => _Description; set => _Description = value; }
        public int ID { get => _ID; set => _ID = value; }
    }
}
