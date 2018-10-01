using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_1096917
{
    class Contact
    {
        private string name;
        private string lastName;
        private string age;
        private string birthDate;        

        public Contact(string cName, string cLastName, string cAge, string cBirthDate)
        {
            name = cName;
            lastName = cLastName;
            age = cAge;
            birthDate = cBirthDate;
        }

        public string getName()
        {
            return name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string getLastName()
        {
            return lastName;
        }

        public void setLastName(string lastName)
        {
            this.lastName = lastName;
        }

        public string getAge()
        {
            return age;
        }

        public void setAge(string age)
        {
            this.age = age;
        }

        public string getBirthDate()
        {
            return birthDate;
        }

        public void setBirthDate(string birthDate)
        {
            this.birthDate = birthDate;
        }

        public string toString()
        {
            return "[Nombre]: " + this.getName()
            + "\n[Apellido]: " + this.getLastName()
            + "\n[Edad]: " + this.getAge()
            + "\n[Fecha de Nacimiento]: " + this.getBirthDate();            
        }
    }
}
