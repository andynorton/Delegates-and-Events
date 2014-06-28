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
            msg.msgHandler = OnMessageReceived;
            msg.msgHandler += LogMessage;

            msg.Sender = "xxx";
            msg.MessageContent = "message xxx";
            msg.SendMessage();
            
            Console.ReadLine();
        }

        private static void OnMessageReceived(string messageFrom, string messageContent)
        {
            Console.WriteLine("Message sent to {0} : {1}", messageFrom, messageContent);
          
        }

        private static void LogMessage(string messageFrom, string messageContent)
        {
            Console.WriteLine("Save message in db");
           
        }
            
    }
}
