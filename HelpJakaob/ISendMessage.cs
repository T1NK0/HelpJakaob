using System;
using System.Collections.Generic;
using System.Text;

namespace HelpJakaob
{
    public interface ISendMessage
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="type">Define the message type</param>
        /// <param name="m">Define the message</param>
        /// <param name="isHTML">Define if the message is HTML</param>
        public void SendMessage(MessageCarrier type, Message m, bool isHTML);

        //Define a send all message method
        public void SendMessageToAll(MessageCarrier type, string[] to, Message m, bool isHTML);
    }
}
