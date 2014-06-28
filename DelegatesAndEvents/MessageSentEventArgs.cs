using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
   public class MessageSentEventArgs : EventArgs
    {
        public string MessageContent { get; set; }
        public string Sender { get; set; }
    }
}
