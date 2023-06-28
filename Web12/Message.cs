using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web12
{
    public class Message
    {
        public string nickname;
        public string message;
        public string timeStamp;
        public string color;
        public Message(string nickname, string mess, string time,string color)
        {
            this.nickname = nickname;
            this.message = mess;
            this.timeStamp = time;
            this.color = color;
        }
    }
}