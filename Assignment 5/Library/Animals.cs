using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Web;
using System.Diagnostics;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace Library
{
    [Serializable]
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

    [Serializable]
    public class Dog : Pet 
    {
        string breed;
        string color;

        public Dog() { }
        public Dog(Pet p)
        {
            setPetType("Dog");
            setId(p.getId());
            setAge(p.getAge());
            setPrice(p.getPrice());
            setDescription(p.getDescription());

        }
        public void setBreed(string breed) { this.breed = breed; }
        public string getBreed() { return breed; }
        public void setColor(string color) { this.color = color; }
        public string getColor() { return color; }

    }

    [Serializable]
    public class Cat : Pet
    {
        string color;
        string breed;

        public Cat() { }
        public Cat(Pet p)
        {
            setPetType("Cat");
            setId(p.getId());
            setAge(p.getAge());
            setPrice(p.getPrice());
            setDescription(p.getDescription());

        }
        public void setBreed(string breed) { this.breed = breed; }
        public string getBreed() { return breed; }
        public void setColor(string color) { this.color = color; }
        public string getColor() { return color; }
    }

    [Serializable]
    public class Bird : Pet
    {
        string type;
        double weight;

        public Bird() { }
        public Bird(Pet p)
        {
            setPetType("Bird");
            setId(p.getId());
            setAge(p.getAge());
            setPrice(p.getPrice());
            setDescription(p.getDescription());

        }
        public void setType(string type) { this.type = type; }
        public string getType() { return type; }
        public void setWeight(double weight) { this.weight = weight; }
        public double getWeight() { return weight; }

    }


    public class PetDao
    {
        public PetDao() { }

        public void addPet(Pet p) 
        {
            string path = "c:\\Listing.txt";
            string[] lines = System.IO.File.ReadAllLines(path);
            for (int x = 0; x < lines.Count(); x++)
            {
                string[] ind = lines[x].Split('\t');
                if (ind.Count() > 3)
                {
                    if (p.getId() == ind[3])
                    {
                        return;
                    }
                }
            }
            string result = "";

            result += p.getPetType() + "\t";
            switch (p.getPetType())
            {
                case "Dog":
                    Dog d = new Dog();
                    d = (Dog)p;
                    result += d.getBreed() + "\t" + d.getColor() + "\t" + d.getId() + "\t" + d.getAge() + "\t" + 
                        d.getPrice() + "\t" + d.getDescription();
                    break;
                case "Cat":
                    Cat c = new Cat();
                    c = (Cat)p;
                    result += c.getBreed() + "\t" + c.getColor() + "\t" + c.getId() + "\t" + c.getAge() + "\t" + 
                        c.getPrice() + "\t" + c.getDescription();
                    break;
                case "Bird":
                    Bird b = new Bird();
                    b = (Bird)p;
                    result += b.getType() + "\t" + b.getWeight() + "\t" + b.getId() + "\t" + b.getAge() + "\t" +
                        b.getPrice() + "\t" + b.getDescription();
                    break;
            }
            Debug.WriteLine(result);
            StreamWriter w = File.AppendText(path);
            
                w.WriteLine(result);
            
            w.Close();


        }

        public void deletePet(string petID)
        {
            int del = -1;
            //string path = "c:\\Listing.txt";
            string path = "C:/Users/Andrew/Desktop/new_cse445/445Proj5/Assignment 5/WebStore/Listing.txt";
            string[] lines = System.IO.File.ReadAllLines(path);
            for (int x = 0; x < lines.Count(); x++)
            {
                string[] ind = lines[x].Split('\t');
                if (ind.Count() > 3)
                {
                    if (petID == ind[3])
                    {
                        del = x;
                        break;
                    }
                }
            }
            System.IO.StreamWriter output = new System.IO.StreamWriter(@"C:/Users/Andrew/Desktop/new_cse445/445Proj5/Assignment 5/WebStore/Listing.txt");
            //System.IO.StreamWriter output = new System.IO.StreamWriter(@"C:\\Listing.txt");
            string[] newLines = new string[lines.Count() - 1];
            for (int x = 0; x < lines.Count(); x++)
            {
                if (x != del)
                    output.WriteLine(lines[x]);
            }
            output.Close();
        }

        public Pet getPet(string id)
        {
            return new Pet();
        }

        public int getPetCount()
        {
            string path = "C:\\Listing.txt";

            try
            {
                string[] pets = System.IO.File.ReadAllLines(path);
                return pets.Count();
            }
            catch ( Exception e)
            {
                Debug.WriteLine("error getting pet count");
                return -1;
            }

        }

        public List<Pet> listPets()
        {
            List<Pet> petList = new List<Pet>();

            //string path = "C:\\Listing.txt";
            string path = "C:/Users/Andrew/Desktop/new_cse445/445Proj5/Assignment 5/WebStore/Listing.txt";
            
            string[] lines = System.IO.File.ReadAllLines(path);
            for (int x = 0; x < lines.Count(); x++)
            {
                string temp = "";
                Dog d;
                Cat c;
                Bird b;
                string[] p = lines[x].Split('\t');
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
                        d.setDescription(temp);
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
                        c.setDescription(temp);
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
                        b.setDescription(temp);
                        petList.Add(b);
                        break;
                }
            }

            return petList;
        }

        public string ObjectToString(Pet obj)
        {
            MemoryStream ms = new MemoryStream();
            new BinaryFormatter().Serialize(ms, obj);
            return Convert.ToBase64String(ms.ToArray());
        }

        public Pet StringToObject(string base64String)
        {
            byte[] bytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(bytes, 0, bytes.Length);
            ms.Write(bytes, 0, bytes.Length);
            ms.Position = 0;
            return (Pet)new BinaryFormatter().Deserialize(ms);
        }
    }

}

