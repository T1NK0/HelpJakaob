using System;
using System.Collections.Generic;

namespace HelpJakaob
{
    /// <summary>
    /// I use this as a MessageController
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            List<Message> messages = new List<Message>();
            TextConverter textConverter = new TextConverter();
            Message message = new Message("Lars Larsen", "Erik Hansen", "Hello Lars Larsen. This is a test to see if the mail system works!", "Tidsstyrings project", "Jens Pilfinger", true);

            if (message.IsHTML)
            {
                textConverter.ConvertBodyToHTML(message.Body);
            }

            Console.WriteLine(message.To);

        }
    }
}