using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_1096917
{
    class Message
    {
        private string email;
        private string text;
        private string hour;
        private string status;
        private string send;

        public Message(string mEmail, string mText, string mHour, string mStatus, string mSend)
        {
            email = mEmail;
            text = mText;
            hour = mHour;
            status = mStatus;
            send = mSend;

            if (status == "1")
            {
                status = "Leído";
            }
            else
            {
                status = "No leído";
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
        public string getText()
        {
            return text;
        }
        public void setText(string text)
        {
            this.text = text;
        }
        public string getHour()
        {
            return hour;
        }
        public void setHour(string hour)
        {
            this.hour = hour;
        }
        public string getStatus()
        {
            return status;
        }
        public void setStatus(string status )
        {
            this.status = status;
        }
        public string getSend()
        {
            return send;
        }
        public void setSend(string send)
        {
            this.send = send;
        }
    }
}
