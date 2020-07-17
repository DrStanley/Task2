using System;
using Task2.Services;
namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t***This is task 2***");
            string fname = UserInfo.GetFirstName();
            string sname = UserInfo.GetSecondName();
            string age = UserInfo.GetAge();
            UserServices userServices = new UserServices(fname,sname,age);
            userServices.displayUserInfo();
        }
    }
}
