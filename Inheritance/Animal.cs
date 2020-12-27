using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Animal
    {
        protected string name = "";
        public Animal(string name)
        {
            this.name = name;
        }
        public Animal()
        {
            this.name = "無名";
        }

        protected int shoutNum = 3;
        public int ShoutNum
        {
            get
            {
                return shoutNum;
            }
            set
            {
                shoutNum = value;
            }
        }
    }

    class Cat : Animal
    {
        public Cat() : base() { }
        public Cat(string name) : base(name) { }

        public string Shout()
        {
            string result = "";
            for (int i = 0; i < shoutNum; i++)
            {
                result += "喵，";
            }
            return "我的名字叫" + name + " " + result;
        }
    }

    class Dog : Animal
    {
        public Dog() : base() { }
        public Dog(string name) : base(name) { }

        public string Shout()
        {
            string result = "";
            for (int i = 0; i < shoutNum; i++)
            {
                result += "汪，";
            }
            return "我的名字叫" + name + " " + result;
        }
    }
}
