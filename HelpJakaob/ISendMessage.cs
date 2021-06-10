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
        void SendMessage(Message m);

        //Define a send all message method
        void SendMessageToAll(string[] to, Message m);
    }
}
