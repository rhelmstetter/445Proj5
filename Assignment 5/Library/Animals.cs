using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Web;
using System.Diagnostics;

namespace Library
{
    public class Pet
    {
        string petType;
        string id;
        int age;
        double price;
        string description;

        public void setPetType(string type) { this.petType = type; }
        public string getPetType() { return petType; }
        public void setId(string id) { this.id = id; }
        public string getId() { return id; }
        public void setAge(int age) { this.age = age; }
        public int getAge() { return age; }
        public void setPrice(double price) { this.price = price; }
        public double getPrice() { return price; }
        public string getDescription() { return description; }
        public void setDescription(string descr) { description = descr; }

    }

    public class Dog : Pet
    {
        string breed;
        string color;

        public Dog() { }
        public void setBreed(string breed) { this.breed = breed; }
        public string getBreed() { return breed; }
        public void setColor(string color) { this.color = color; }
        public string getColor() { return breed; }

    }

    public class Cat : Pet
    {
        string color;
        string breed;

        public Cat() { }
        public void setBreed(string breed) { this.breed = breed; }
        public string getBreed() { return breed; }
        public void setColor(string color) { this.color = color; }
        public string getColor() { return breed; }
    }

    public class Bird : Pet
    {
        string type;
        double weight;

        public Bird() { }
        public void setType(string type) { this.type = type; }
        public string getType() { return type; }
        public void setWeight(double weight) { this.weight = weight; }
        public double getWeight() { return weight; }

    }


    public class PetDao
    {
        public PetDao() { }

        public void addPet(Pet newPet) 
        {
        
        }

        public void deletePet(Pet pet) 
        {

        }

        public Pet getPet(string id)
        {
            return new Pet();
        }

        public List<Pet> listPets()
        {
            List<Pet> petList = new List<Pet>();

            string path = "C:\\Listing.txt";
            
            string[] lines = System.IO.File.ReadAllLines(path);
            for (int x = 0; x < lines.Count(); x++)
            {
                string temp = "";
                Dog d;
                Cat c;
                Bird b;
                string[] p = lines[x].Split(' ');
                switch (p[0])
                {
                    case "Dog":
                        d = new Dog();
                        d.setPetType(p[0]);
                        d.setBreed(p[1]);
                        d.setColor(p[2]);
                        d.setId(p[3]);
                        d.setAge(Convert.ToInt32(p[4]));
                        d.setPrice(Convert.ToDouble(p[5]));
                        for (int y = 6; y < p.Count(); y++) 
                            temp += p[y];
                        petList.Add(d);
                        break;
                    case "Cat":
                        c = new Cat();
                        c.setPetType(p[0]);
                        c.setBreed(p[1]);
                        c.setColor(p[2]);
                        c.setId(p[3]);
                        c.setAge(Convert.ToInt32(p[4]));
                        c.setPrice(Convert.ToDouble(p[5]));
                        for (int y = 6; y < p.Count(); y++) 
                            temp += p[y];
                        petList.Add(c);
                        break;
                    case "Bird":
                        b = new Bird();
                        b.setPetType(p[0]);
                        b.setType(p[1]);
                        b.setWeight(Convert.ToDouble(p[2]));
                        b.setId(p[3]);
                        b.setAge(Convert.ToInt32(p[4]));
                        b.setPrice(Convert.ToDouble(p[5]));
                        for (int y = 6; y < p.Count(); y++) 
                            temp += p[y];
                        petList.Add(b);
                        break;

                }
            }

            return petList;
        }
    }

}

