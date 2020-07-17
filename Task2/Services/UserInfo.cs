using System;
using System.Collections.Generic;
using System.Text;
using Task2.Support;


namespace Task2.Services
{
    class UserInfo
    {

		public static string GetFirstName()
		{
			Console.WriteLine("Enter your First name");
			//reads users input from console
			string getName = Console.ReadLine();
			Console.WriteLine("......");
			return getName;
		}
		public static string GetSecondName()
		{
			Console.WriteLine("Enter your Second name");
			//reads users input from console
			string getSName = Console.ReadLine();
			Console.WriteLine("......");

			return getSName;
		}
		public static string GetAge()
		{

			Console.WriteLine("Enter your Date of Birth (DD/MM/YYYY)");
			//reads users input from console
			string getDate = Console.ReadLine();
			int age = DateSupport.getAge(getDate);
			return  age.ToString();
		}

       
    }
}
