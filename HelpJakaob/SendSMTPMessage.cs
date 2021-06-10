using System;
using System.Collections.Generic;
using System.Text;

namespace HelpJakaob
{
    /// <summary>
    /// Sends a message as VMessage, since it only access this class if it is a SMTP type (from ISendMessage)
    /// </summary>
    class SendSMTPMessage : ISendMessage
    {
        public void SendMessage(MessageCarrier type, Message m, bool isHTML)
        {
            if (isHTML)
                m.Body = ConvertBodyToHTML(m.Body);
            else return m;
            //her implementeres alt koden til at sende via Smtp
        }

        public void SendMessageToAll(MessageCarrier type, string[] to, Message m, bool isHTML)
        {
            if (isHTML)
                m.Body = ConvertBodyToHTML(m.Body);
            else return m;
            //her implementeres alt koden til at sende via Smtp
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="plainText">returns the </param>
        /// <returns>Returns the text as plaintext (html)</returns>
        public override string ConvertBodyToHTML(string plainText)
        {
            return "" + plainText + "";
        }
    }
}
