using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatAppMAUI.Model
{
    public class ChatMessage
    {
        public required string Text { get; set; }
        public required string User { get; set; }
        public bool IsIncoming { get; set; }

        public required string Time {  get; set; }

        public required string UserImage { get; set; }

    }
}
