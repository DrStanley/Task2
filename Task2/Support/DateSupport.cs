using System;
using System.Collections.Generic;
using System.Text;


namespace Task2.Support
{
	class DateSupport
	{
		public static int getAge(string getDate)
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
