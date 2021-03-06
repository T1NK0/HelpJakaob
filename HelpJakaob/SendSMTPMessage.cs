using System;
using System.Collections.Generic;
using System.Text;

namespace HelpJakaob
{
    /// <summary>
    /// Sends a message as VMessage, since it only access this class if it is a SMTP type (from ISendMessage)
    /// </summary>
    class SendSMTPMessage : TextConverter, ISendMessage
    {
        public void SendMessage(Message m)
        {
                m.Body = ConvertBodyToHTML(m.Body);
            //her implementeres alt koden til at sende via Smtp
        }

        public void SendMessageToAll(string[] to, Message m)
        {
                m.Body = ConvertBodyToHTML(m.Body);
            //her implementeres alt koden til at sende via Smtp
        }
    }
}
