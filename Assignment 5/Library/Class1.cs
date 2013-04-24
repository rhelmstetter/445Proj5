using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Pet
    {
        int age;
        double price;
    }

    public class Dog : Pet
    {
        string breed;
    }

    public class Cat : Pet
    {
        string color;
        string breek;
    }

    public class Bird : Pet
    {
        string type;
    }
}
