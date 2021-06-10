using System;
using System.Collections.Generic;
using System.Text;

namespace HelpJakaob
{
    class SendSMTPMessage
    {
        public void sendSMTPMessage(MessageCarrier type, Message m, bool isHTML)
        {
            //herinde sendes der en email ud til modtageren
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

        //public void sendMessage(MessageCarrier type, Message m, bool isHTML)
        //{
        //    //herinde sendes der en email ud til modtageren
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
