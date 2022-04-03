using System;

namespace Account
{
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User("Elnare ", "Semedova", "Elnare123");
            user1.ShowInfo();
        }
    }
}
