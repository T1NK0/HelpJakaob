using System;
using System.Collections.Generic;
using System.Text;

namespace HelpJakaob
{
    //Creates an enum called MessageCarrier, which choses which type of message we want to send. (SMTP 
    public enum MessageCarrier { Smtp, VMessage }

    /// <summary>
    /// Creates a message depending on the user input.
    /// </summary>
    class Message
    {
        string to, from, body, subject, cc;

        public Message(string to, string from, string body, string subject, string cc)
        {
            this.to = to;
            this.from = from;
            this.body = body;
            this.subject = subject;
            this.cc = cc;
        }

        public string To { get => to; set => to = value; }
        public string From { get => from; set => from = value; }
        public string Body { get => body; set => body = value; }
        public string Subject { get => subject; set => subject = value; }
        public string Cc
        {
            get => cc; set => cc = value;
        }
    }
