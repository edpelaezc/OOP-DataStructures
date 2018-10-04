using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class Messages : User
    {        
        string chat;

        public void setChat(string chat)
        {
            this.chat = chat;
        }

        public string getChat()
        {
            return this.chat;
        }

        public new string toString()
        {
            return this.toString() + "\n[CHAT]: " + this.getChat();
        }
    }
}
