using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_1096917
{
    class Contact
    {
        private string email;
        private string name;
        private string lastName;
        private string age;
        private string birthDate;
        private string status;

        public Contact(string cEmail, string cName, string cLastName, string cAge, string cBirthDate, string cStatus)
        {
            email = cEmail;
            name = cName;
            lastName = cLastName;
            age = cAge;
            birthDate = cBirthDate;
            status = cStatus;

            if (status == "1")
            {
                status = "Habilitado";
            }
            else if (status == "2")
            {
                status = "Bloqueado";
            }
            else
            {
                status = "Importante";
            }
        }

        public string getEmail()
        {
            return email;
        }

        public void setEmail(string email)
        {
            this.email = email;
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

        public string getStatus()
        {
            return status;
        }

        public void setStatus(string status)
        {
            this.status = status;
        }

        public string toString()
        {
            return "[INFORMACIÓN DEL CONTACTO]"
            + "\n[Nombre]: " + this.getName()
            + "\n[Apellido]: " + this.getLastName()
            + "\n[E-mail]: " + this.getEmail()
            + "\n[Edad]: " + this.getAge()
            + "\n[Estado]: " + this.getStatus()
            + "\n[Fecha de Nacimiento]: " + this.getBirthDate();            
        }
    }
}
