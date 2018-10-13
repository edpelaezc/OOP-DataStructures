using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_1096917
{
    /// <summary>
    /// Clase "News". Tipo de dato utilizado para extraer las noticias de los archivos de texto.
    /// </summary>
    class News
    {
        private string email;
        private string type;
        private string path = "C:\\GitHub\\OOP-DataStructures\\Proyecto1_1096917\\";
        private string text;

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        /// <param name="nEmail">Email del usuario que publica en "newsfeed".</param>
        /// <param name="nType">Tipo de noticia, pueden ser: Estado, historia, acontecimiento, festividad general.</param>
        /// <param name="nPath">Dirección de la imagen que pertenece a la noticia.</param>
        /// <param name="nText">Texto de la notica.</param>
        public News(string nEmail, string nType, string nPath, string nText)
        {
            email = nEmail;
            type = nType;            
            text = nText;

            if (nPath != "-")
            {
                path += nPath;
            }
            else
            {
                path = "";
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
