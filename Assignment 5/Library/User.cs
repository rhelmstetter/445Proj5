using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace Library
{
    public class User
    {
        int admin;  // 0 = False, 1 = True
        String username;
        String password;


        public User() { }
        public User(int admin)
        {
            this.admin = admin;
        }
        public User(int admin, string user, string pass)
        {

            CryptoService.Service proxy = new CryptoService.Service();
            try
            {
                this.admin = admin;
                username = user;
                password = proxy.Encrypt(pass);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                
            }
        }

        public int getAdmin() { return admin; }
        public string getUsername() { return username; }
        public void setUsername(string user) { username = user; }
        public string getPassword() { return password; }
        public void setPassword(string pass) 
        {
            CryptoService.Service proxy = new CryptoService.Service();
            try
            {
                password = proxy.Encrypt(pass);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
    
            }
        }

        public string toString()
        {
            return admin + " " + username + " " + password;
        }
    }

    public class UserDao
    {
       

        public void addUser(User newUser)
        {
            //string path = @"c:\Users.txt";
            string path = "C:/Users/Andrew/Desktop/new_cse445/445Proj5/Assignment 5/WebStore/users.txt";

            // Load all users
            try
            {
                string users = File.ReadAllText(path);
                users = users + newUser.toString() + "\n";
                File.WriteAllText(users, "@" + path);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                Debug.WriteLine(e.GetType());
            }
        }

        public User loginUser(string username, string password)
        {
            User user = getUser(username);

            if (user == null)
            {
                return null;
            }

            CryptoService.Service proxy = new CryptoService.Service();

            try
            {
                if (password == proxy.Decrypt(user.getPassword()))
                {
                    return user;
                }
                else 
                {
                    return null;
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                return null;
            }


        }

        public User getUser(string username)
        {
            //string path = "C:\\Users.txt";
            string path = "C:/Users/Andrew/Desktop/new_cse445/445Proj5/Assignment 5/WebStore/users.txt";

            try
            {
                string[] users = File.ReadAllLines(path);

                for (int i = 0; i < users.Length; i++)
                {
                    string[] fields = users[i].Split(' ');
                    if (fields.Length == 3 && fields[1] == username)
                    {
                        User user = new User(Convert.ToInt32(fields[0]), fields[1], fields[2]);
                        return user;
                    }


                }

            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }

            return null;
        }
        


    }
}
