using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tyuiu.iipb_22_2.SoloviovIA.marketplace
{
    public class Salesman
    {
        private readonly string name;
        private readonly DateTime date;

        public Salesman(string name, DateTime date)
        {
            this.name = name;
            this.date = date;
        }
        public string Name {
            get {
                return name; 
            }
        }
        public DateTime Date
        {
            get
            {
                return date;
            }
        }

    }
}
