using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_1096917
{
    class News
    {
        private string name;
        private string activity;

        public string getName()
        {
            return name;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public string getActivity()
        {
            return activity;
        }
        public void setActivity(string activity)
        {
            this.activity = activity;
        }

        public string toString()
        {
            return name + ", " + activity;
        }
    }
}
