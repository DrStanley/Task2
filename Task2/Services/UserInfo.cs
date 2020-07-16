using System;
using System.Collections.Generic;
using System.Text;

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

			int age = getAge(getDate);

			return  age.ToString();
		}

        private static int getAge(string getDate)
        {

			//gets the current date
			int currentYear = DateTime.Now.Year;
			int currentMonth = DateTime.Now.Month;
			int currentDay = DateTime.Now.Day;
			int age = 0;
			try
			{
				//converts user input to Date object
				DateTime dob = Convert.ToDateTime(getDate);
				//getting the dates
				int birthYear = dob.Year;
				int birthMonth = dob.Month;
				int birthDay = dob.Day;
				age = currentYear - birthYear;
				if (currentMonth < birthMonth)
				{
					--age;
				}
				else if (currentMonth == birthMonth)
				{
					if (currentDay > birthDay)
					{
						--age;
					}

				}
			}
			catch (Exception e)
			{
				Console.WriteLine("Error: " + e.Message);
			}
			return age;
		}
    }
}
