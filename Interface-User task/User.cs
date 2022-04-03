using System;
using System.Collections.Generic;
using System.Text;

namespace Account
{
    class User : IAcccount
    {
        public string FullName { get; set; }
        public string Email;
        private string Password { get; set; }
        bool IsTrue = false;
        public bool CheckPassword(string pass)
        {
            int CountUpper = 0;
            int CountLower = 0;
            int CountDigit = 0;
            if (pass.Length >= 8)
            {
                foreach (var item in pass)
                {
                    if (char.IsUpper(item))
                    {
                        CountUpper++;
                    }
                    if (!char.IsLower(item))
                    {
                        CountLower++;
                    }
                    if (char.IsDigit(item))
                    {
                        CountDigit++;
                    }
                }
                if (CountUpper >= 1 && CountLower >= 1 && CountDigit >= 1)
                {
                    IsTrue = true;
                }
                else if (CountUpper < 1)
                {
                    Console.WriteLine("Not enough uppercase letters");
                }
                else if (CountLower < 1)
                {
                    Console.WriteLine("Not enough lowercase letters");
                }
                else
                {
                    Console.WriteLine("Not enough digits");
                }
            }
            else
            {
                Console.WriteLine("Not enough characters");
                IsTrue = false;
            }
            return IsTrue;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Username: {FullName}  Email: {Email}");
        }
        public User()
        {

        }
        public User(string fullName, string email, string password)
        {
            FullName = fullName;
            if (CheckPassword(password)==true)
            {
                Password = password;
            }
            else
            {
                Console.WriteLine("Please enter valid password");
            }
            if (Email == "" || Email == " ")
            {
                Console.WriteLine("Please enter email address");
            }
            else
            {
                Email = email;
            }
            
        }
    }
}
