using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_1096917
{
    class Message
    {
        private string contact;
        private string chat;

        public string getContact()
        {
            return contact;
        }
        public void setContact(string contact)
        {
            this.contact = contact;
        }
        public string getChat()
        {
            return chat;
        }
        public void setChat(string chat)
        {
            this.chat = chat;
        }
    }
}
