using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace Library
{
    class User
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
            CryptoService.ServiceClient proxy = new CryptoService.ServiceClient();
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
            finally
            {
                proxy.Close();
            }
        }

        public int getAdmin() { return admin; }
        public string getUsername() { return username; }
        public void setUsername(string user) { username = user; }
        public string getPassword() { return password; }
        public void setPassword(string pass) 
        {
            CryptoService.ServiceClient proxy = new CryptoService.ServiceClient();
            try
            {
                password = proxy.Encrypt(pass);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
    
            }
            finally
            {
                proxy.Close();
            }
        }

        public string toString()
        {
            return admin + " " + username + " " + password;
        }
    }

    class UserDao
    {
        public void addUser(User newUser)
        {
            string path = "http:\\\\webstrar.fulton.asu.edu\\website9\\Page0\\Page00\\Users.txt";
            // Load all users
            try
            {
                string users = File.ReadAllText(path);
                users = users + newUser.toString() + "\n";
                File.WriteAllText(users, path);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
        }

        public User loginUser(string username, string password)
        {
            User user = getUser(username);

            if (user == null)
            {
                return null;
            }

            CryptoService.ServiceClient proxy = new CryptoService.ServiceClient();

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
            finally
            {
                proxy.Close();
            }


        }

        public User getUser(string username)
        {
            string path = "http:\\\\webstrar.fulton.asu.edu\\website9\\Page0\\Page00\\Users.txt";

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
