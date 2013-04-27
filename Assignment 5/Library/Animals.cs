using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Web;

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
        public void addPet(Pet newPet) 
        {
        
        }

        public void deletePet(Pet pet) 
        {

        }

        public List<Pet> listPets()
        {
            XmlTextReader reader = null;
            List<Pet> petList = new List<Pet>();

            try
            {
                reader = new XmlTextReader("~/Listing.xml");
                reader.WhitespaceHandling = WhitespaceHandling.None;
                while (true)
                {
                    
                }

            }
            finally
            {
                reader.Close();
            }
        }
    }

}

