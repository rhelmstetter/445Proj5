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
            XmlTextReader reader = null;
            List<Pet> petList = new List<Pet>();

            try
            {
                string path = "c:\\Listing.xml";
                reader = new XmlTextReader(path);
                reader.WhitespaceHandling = WhitespaceHandling.None;
               
                while(reader.Read())
                {
                    if (reader.Name == "Type")
                    {
                        string petType = reader.Value;
                        string breed;
                        string color;
                        double weight;
                        string type;
                        string id;
                        int age;
                        double price;
                        string descr;
                        switch (petType)
                        {
                            case "Dog":
                                reader.Read();
                                breed = reader.Value;
                                reader.Read();
                                color = reader.Value;
                                reader.Read();
                                id = reader.Value;
                                reader.Read();
                                age = Convert.ToInt32(reader.Value);
                                reader.Read();
                                price = Convert.ToDouble(reader.Value);
                                reader.Read();
                                descr = reader.Value;

                                Dog dog = new Dog();
                                dog.setPetType(petType);
                                dog.setId(id);
                                dog.setAge(age);
                                dog.setColor(color);
                                dog.setPrice(price);
                                dog.setDescription(descr);

                                petList.Add(dog);
                                break;
                            case "Cat":
                                reader.Read();
                                breed = reader.Value;
                                reader.Read();
                                color = reader.Value;
                                reader.Read();
                                id = reader.Value;
                                reader.Read();
                                age = Convert.ToInt32(reader.Value);
                                reader.Read();
                                price = Convert.ToDouble(reader.Value);
                                reader.Read();
                                descr = reader.Value;

                                Cat cat = new Cat();
                                cat.setPetType(petType);
                                cat.setId(id);
                                cat.setAge(age);
                                cat.setColor(color);
                                cat.setPrice(price);
                                cat.setDescription(descr);

                                petList.Add(cat);

                                break;
                            case "Bird":
                                reader.Read();
                                type = reader.Value;
                                reader.Read();
                                weight = Convert.ToDouble(reader.Value);
                                reader.Read();
                                id = reader.Value;
                                reader.Read();
                                age = Convert.ToInt32(reader.Value);
                                reader.Read();
                                price = Convert.ToDouble(reader.Value);
                                reader.Read();
                                descr = reader.Value;

                                Bird bird = new Bird();
                                bird.setPetType(petType);
                                bird.setId(id);
                                bird.setAge(age);
                                bird.setWeight(weight);
                                bird.setPrice(price);
                                bird.setDescription(descr);

                                petList.Add(bird);


                                break;
                            default:
                                Debug.WriteLine(petType);
                                Debug.WriteLine(reader.Value + " " + reader.Name);
                                break;
                        }
                    }                 

                } 

            }
            finally
            {
                reader.Close();
            }
            Debug.Write(petList.Count);
            return petList;
        }
    }

}

