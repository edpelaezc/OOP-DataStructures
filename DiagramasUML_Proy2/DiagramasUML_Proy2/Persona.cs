using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagramasUML_Proy2
{
    class Persona
    {
        private string name;
        private int age;

        public string getName()
        {
            return name;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public int getAge()
        {
            return age;
        }
        public void setAge(int age)
        {
            this.age = age;
        }

        public string toString()
        {
            return "Persona [name=" + name + ", age=" + age + "]";
        }
    }
}
