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

        public Cat(string name)
        {
            this.name = name;
        }

        public Cat()
        {
            this.name = "無名";
        }

        public string Shout()
        {
            return "我的名字叫" + name + " 喵";
        }
    }
}
