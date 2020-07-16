using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Task2.Models;

namespace Task2.Services
{
    class UserServices
    {
        private UserModel userModel;
        public UserServices(string fName, string sName, string age)
        {
            userModel = new UserModel()
            {
                FirstName = fName,
                SecondName = sName,
                Age = age
            };

        }

        public void displayUserInfo()
        {
            Console.WriteLine($"My name is {userModel.FirstName} {userModel.SecondName} and i am {userModel.Age} years.");
        }
    }
}
