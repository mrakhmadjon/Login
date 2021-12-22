using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_password.Homework
{

    public static class Validation 
    {

        public static User GetAudentification(SignIn signIn)
        {
           User user = new User();
            string[] allData = File.ReadAllLines(@"C:\Users\HP\Documents\Dot net projects\DotNet Lessons\HomeWorks\Login_password\Login_password\Homework\Data.txt").ToArray();

            foreach (string data in allData)
            {
                string[] sortedData = data.Split();
                if (signIn.Login == sortedData[4] && signIn.Password == sortedData[3])
                {
                    user.FirstName = sortedData[0];
                    user.LastName = sortedData[1];
                    user.Email = sortedData[2];

                    user.BirthDate = DateTime.ParseExact(sortedData[6], "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    if (sortedData[5] == "Erkak")
                        user.gender = Gender.Erkak;
                    else
                        user.gender = Gender.Ayol;

                }
            }
            return user;
        }

    }
}
