using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinalPA2018_1096917
{
    class Cliente
    {
        private int ID;
        private string name;
        private string phone;
        private string age;
        private string address;


        public Cliente(int iD, string name, string phone, string age, string address)
        {            
            this.ID = iD;
            this.name = name;
            this.phone = phone;
            this.age = age;
            this.address = address;
        }

        public int getID()
        {
            return ID;
        }

        public void setID(int iD)
        {
            this.ID = iD;
        }

        public string getName()
        {
            return name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string getPhone()
        {
            return phone;
        }

        public void setPhone(string phone)
        {
            this.phone = phone;
        }

        public string getAge()
        {
            return age;
        }

        public void setAge(string age)
        {
            this.age = age;
        }

        public string getAddress()
        {
            return address;
        }

        public void setAddress(string address)
        {
            this.address = address;
        }

        public string toString()
        {
            return ID + "," + name + "," + phone + "," + age + "," + address;
        }
    }
}
