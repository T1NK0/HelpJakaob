using System;

namespace HelpJakaob
{
    class Program
    {
        static void Main(string[] args)
        {
            list<Message> messages = new list<Message>;

            Message message = new Message("Lars Larsen", "Erik Hansen", "Hello Lars Larsen. This is a test to see if the mail system works!", "Tidsstyrings project", "Jens Pilfinger", true);


            Console.WriteLine(message.To);
            
        }
    }
