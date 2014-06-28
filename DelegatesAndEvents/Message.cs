using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    public class Message 
    {

        public string MessageContent { get; set; }
        public string Sender { get; set; }
       
        public event MessageSentHandler msgHandler;

        public void SendMessage()
        {
            if(msgHandler != null)
            {
                MessageSentEventArgs args = new MessageSentEventArgs();
                args.MessageContent = this.MessageContent;
                args.Sender = this.Sender;

                msgHandler(this, args);
            }
            
        }


    }
}
