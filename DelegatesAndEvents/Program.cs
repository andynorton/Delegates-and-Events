using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
   
    class Program
    {
        
        static void Main(string[] args)
        {

            Message msg = new Message();
            msg.msgHandler += OnMessageSent;
            msg.msgHandler += LogMessage;
            
            msg.Sender = "xxx@xxxx.com";
            msg.MessageContent = "hello world";
            msg.SendMessage();
            
            Console.ReadLine();
        }

        private static void LogMessage(object sender, MessageSentEventArgs args)
        {

            Console.WriteLine("Log message in db sent from {0}", sender.GetType());
        }

        private static void OnMessageSent(object sender, MessageSentEventArgs args)
        {
            Console.WriteLine("Message '{0}' sent to {1}", args.MessageContent, args.Sender);
        }

       
            
    }
}
