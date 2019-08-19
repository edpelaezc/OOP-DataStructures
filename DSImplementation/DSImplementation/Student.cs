using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSImplementation
{
    class Student
    {
        private int id;
        private string name;

        public Student(int id, string name) {
            this.id = id;
            this.name = name; 
        }

        public int getID() {
            return id;
        }

        public void setID(int idNumber) {
            id = idNumber;
        }

        public string getName()
        {
            return name;
        }

        public void setName(string studentName)
        {
            name = studentName;
        }
    }
}
