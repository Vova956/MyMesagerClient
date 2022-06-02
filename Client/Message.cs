using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Message
    {
        string text;
        int id;
        string nick;

        public Message()
        {
            text = "";
            id = -1;
            nick = "";
        }

        public Message(string text,string nick)
        {
            this.text = text;
            this.nick = nick;
        }

        public string getText() { return text; }

        public int getId() { return id; }

        public string getNick() { return nick; }

        public void setId(int id)
        {
            this.id = id;
        }

        public void setText(string text)
        {
            this.text = text;
        }

        public void setNick(string nick)
        {
            this.nick = nick;
        }

        override
        public string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(nick).Append(" : ").Append(text);
            return stringBuilder.ToString();
        }


    }
}
