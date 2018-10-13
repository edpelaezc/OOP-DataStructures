using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_1096917
{
    /// <summary>
    /// Clase Message
    /// </summary>
    class Message
    {
        private string email;
        private string text;
        private string hour;
        private string status;
        private string send;

        /// <summary>
        /// Constructor de la clase.
        /// </summary>
        /// <param name="mEmail">Email del contacto que envío el mensaje.</param>
        /// <param name="mText">Texto que el contacto nos envío.</param>
        /// <param name="mHour">Hora a la que el contacto envío el mensaje.</param>
        /// <param name="mStatus">Estado del mensaje: 1 = leído, 0 = no leído </param>
        /// <param name="mSend">Indica quien envío el mensaje</param>
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

        public string toString()
        {
            return getHour() + " " + getText() + ". " + getStatus();
        }
    }
}
