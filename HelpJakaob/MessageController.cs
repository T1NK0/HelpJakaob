﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HelpJakaob
{
    /// <summary>
    /// Will set what type of message we will send, and says if it's a message for one or all.
    /// </summary>
    class MessageController
    {
        //Define messageType (SMTP/VMessage)

        //Define Who will get message (All or one)

        /// <summary>
        /// Runs a SendMessage method, which returns the message as either SMTP or VMessage
        /// </summary>
        public void SendMessage()
        {
            switch (Message.MessageCarrier)
            {
                case MessageCarrier.Smtp:
                    return SendSMTPMessage;
                case MessageCarrier.VMessage:
                    return SendVMessage;
                break;
            }

            //Also converts the message to html if it's selected.
        }
    }
}
