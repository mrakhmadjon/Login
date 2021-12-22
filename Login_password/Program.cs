using Login_password.Homework;
using System;

namespace Login_password
{
    internal class Program 
    {
        static void Main(string[] args)
        {
           SignIn signIn = new SignIn();
            Console.Write("Your Login : ");
            signIn.Login = Console.ReadLine();

            Console.Write("Your Password : ");
            signIn.Password = Console.ReadLine();

            User user = new User();

            
            user.Show(Validation.GetAudentification(signIn));

           
        }
    }
}
