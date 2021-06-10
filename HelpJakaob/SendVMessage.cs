using System;
using System.Collections.Generic;
using System.Text;

namespace HelpJakaob
{
    class SendVMessage
    {

        public void sendVMessage(MessageCarrier type, string[] to, Message m, bool isHTML)
        {
            if (type.Equals(MessageCarrier.Smtp))
            {
                if (isHTML)
                    m.Body = ConvertBodyToHTML(m.Body);
                //her implementeres alt koden til at sende via Smtp
            }

            if (type.Equals(MessageCarrier.VMessage))
            {
                if (isHTML)
                    m.Body = ConvertBodyToHTML(m.Body);
                //her implementeres alt koden til at sende via VMessage
            }
        }

        //public void sendMessageToAll(MessageCarrier type, string[] to, Message m, bool isHTML)
        //{
        //    if (type.Equals(MessageCarrier.Smtp))
        //    {
        //        if (isHTML)
        //            m.Body = ConvertBodyToHTML(m.Body);
        //        //her implementeres alt koden til at sende via Smtp
        //    }

        //    if (type.Equals(MessageCarrier.VMessage))
        //    {
        //        if (isHTML)
        //            m.Body = ConvertBodyToHTML(m.Body);
        //        //her implementeres alt koden til at sende via VMessage
        //    }
        //}
    }
}
