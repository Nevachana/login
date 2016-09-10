using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace security
{
    public class Key
    {
        public int ID { get; private set; }
        public string VALUE { get; private set; }
        public Key(string value, int id)
        {
            this.VALUE = value;
            this.ID = id;
        }
    }
}
