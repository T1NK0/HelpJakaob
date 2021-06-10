using System;
using System.Collections.Generic;
using System.Text;

namespace HelpJakaob
{
    /// <summary>
    /// Creates an ENUM for us to use to define the message type (SMTP or VMessage)
    /// </summary>
    public enum MessageCarrier { Smtp, VMessage }

    /// <summary>
    /// Creates a message depending on the user input. (To, From, message(body), subject and cc)
    /// </summary>
    class Message
    {
        string to, from, body, subject, cc;
        bool isHtml;

        public Message(string to, string from, string body, string subject, string cc, bool isHtml)
        {
            this.to = to;
            this.from = from;
            this.body = body;
            this.subject = subject;
            this.cc = cc;
            this.isHtml = isHtml;
        }

        public string To { get => to; set => to = value; }
        public string From { get => from; set => from = value; }
        public string Body { get => body; set => body = value; }
        public string Subject { get => subject; set => subject = value; }
        public string Cc { get => cc; set => cc = value; }
        public bool IsHTML {
            get { return isHtml; }
            set { isHtml = value; }
        }
    }
}
