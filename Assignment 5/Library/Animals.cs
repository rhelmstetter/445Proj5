using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Pet
    {
        string petType;
        string id;
        int age;
        double price;
        string description;
    }

    public class Dog : Pet
    {
        string breed;
    }

    public class Cat : Pet
    {
        string color;
        string breed;
    }

    public class Bird : Pet
    {
        string type;
        double weight;
    }
}
