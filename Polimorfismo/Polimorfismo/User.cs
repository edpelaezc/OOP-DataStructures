using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class User
    {
        private string name;

        public void setName(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return this.name;
        }

        public string toString()
        {
            return "[NOMBRE]: " + this.getName();
        }
    }
}
