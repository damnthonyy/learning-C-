using System;

namespace condition
{
    class Program
    {
        static void Main(string[] args)
        {
            string role ="admin";
            string acces = role switch
            {
                "admin" => "full access",
                "user" => "limited access",
                _ => "no access"
            };

            Console.WriteLine(acces);
        }
    }
}