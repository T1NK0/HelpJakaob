using System;
using System.Collections.Generic;
using System.Text;

namespace HelpJakaob
{
    /// <summary>
    /// Sends a message as VMessage, since it only access this class if it is a VMessage type (from ISendMessage)
    /// </summary>
    class SendVMessage : ISendMessage, ITextConverter
    {
        public void SendMessage(MessageCarrier type, Message m, bool isHTML)
        {
            if (isHTML)
                m.Body = ConvertBodyToHTML(m.Body);
            //her implementeres alt koden til at sende via VMessage
        }

        public void SendMessageToAll(MessageCarrier type, string[] to, Message m, bool isHTML)
        {
            if (isHTML)
                m.Body = ConvertBodyToHTML(m.Body);
            //her implementeres alt koden til at sende via VMessage
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="plainText"></param>
        /// <returns></returns>
        public override string ConvertBodyToHTML(string plainText)
        {
            return "" + plainText + "";
        }
    }
}
