using System;
using System.Collections.Generic;
using System.Text;

namespace HelpJakaob
{
    class SendMessage
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="type">Define the message type</param>
        /// <param name="m">Define the message</param>
        /// <param name="isHTML">Define if the message is HTML</param>
        public void SendSingleMessage(MessageCarrier type, Message m, bool isHTML);

        //Define a send all message method
        public void SendMultipleMessages(MessageCarrier type, string[] to, Message m, bool isHTML);
    }
}
