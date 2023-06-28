using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web12
{
    public class Member
    {
        public string nickName;
        public string color;
        public Member(string name, string mau)
        {
            this.nickName = name;
            this.color = mau;
        }
        public Member()
        {
        }
    }
}