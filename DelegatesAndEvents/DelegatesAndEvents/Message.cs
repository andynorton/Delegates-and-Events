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
       
        public MessageSentHandler msgHandler;

        public void SendMessage()
        {
            if(msgHandler != null)
            {
                msgHandler(this.Sender, this.MessageContent);
            }
            
        }


    }
}
