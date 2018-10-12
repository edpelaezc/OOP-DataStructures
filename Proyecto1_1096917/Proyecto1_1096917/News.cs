using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_1096917
{
    class News
    {
        private string email;
        private string type;
        private string path = @"C:\GitHub\OOP-DataStructures\Proyecto1_1096917\";
        private string text;

        public News(string nEmail, string nType, string nPath, string nText)
        {
            email = nEmail;
            type = nType;
            path += nPath;
            text = nText;
        }

        public string getEmail()
        {
            return email;
        }
        public void setEmail(string email)
        {
            this.email = email;
        }
        public string getType()
        {
            return type;
        }
        public void setType(string type)
        {
            this.type = type;
        }
        public string getPath()
        {
            return path;
        }
        public void setPath(string path)
        {
            this.path += path;
        }
        public string getText()
        {
            return text;
        }
        public void setText(string text)
        {
            this.text = text;
        }

        public string toString()
        {
            return getEmail() + "\n" + getType() + "\n" + getText();
        }
    }
}
