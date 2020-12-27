using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            cat.ShoutNum = 5;
            Console.WriteLine(cat.Shout());
            Console.ReadLine();

            Dog dog = new Dog("狗~");
            dog.ShoutNum = 11;
            Console.WriteLine(dog.Shout());
            Console.ReadLine();
        }
    }
}
