using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObject
{
    class Cat
    {
        private string name = "";
        private int shoutNum = 3;

        public Cat(string name)
        {
            this.name = name;
        }

        public Cat()
        {
            this.name = "無名";
        }

        public int ShoutNum
        {
            get
            {
                return shoutNum;
            }
            set
            {
                if (value <= 10)
                {
                    shoutNum = value;
                }
                else
                {
                    shoutNum = 10;
                }
            }
        }

        public string Shout()
        {
            string result = "";
            for (int i = 0; i < shoutNum; i++)
            {
                result += "喵 ";
            }
            return "我的名字叫" + name + " " + result;
        }
    }
}
