using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_password.Homework
{
   public enum Gender
    {
        Erkak, Ayol
    }
    public class User : SignIn
    {
       public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDate { get; set; } 

        public string Email { get; set; }
       
        public Gender gender { get; set; }

        public void Show(User user)
        {
            if(user.FirstName != null)
                Console.WriteLine($"FirstName {user.FirstName} LastName: {user.LastName} BirthDate: {user.BirthDate} Email: {user.Email} Gender: {user.gender}");
            else
                Console.WriteLine("Bunday User Yo'q");
        }

    }
}
