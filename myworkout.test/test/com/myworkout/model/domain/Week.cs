using System;
using System.Text;

namespace domain
{
	//Week object that holds the days the user should complete that week
	public class Week
	{
		//The week number
		int weekNumber;

		//The first day the user should complete
		Day day1;

		//The second day the user should complete
		Day day2;

		//The third day the user should complete
		Day day3;

		//Default constructor
		public Week()
		{
		}

		//Constructor with the param of week number, day one, day two, day three
		public Week(int weekNumber, Day day1, Day day2, Day day3)
		{
			this.weekNumber = weekNumber;
			this.day1 = day1;
			this.day2 = day2;
			this.day3 = day2;
		}

		public void setWeekNumber(int weekNumber)
		{
			this.weekNumber = weekNumber;
		}
		public int getWeekNumber()
		{
			return weekNumber;
		}

		public void setDay1(Day day1)
		{
			this.day1 = day1;
		}
		public Day getDay1()
		{
			return day1;
		}

		public void setDay2(Day day2)
		{
			this.day2 = day2;
		}
		public Day getDay2()
		{
			return day2;
		}

		public void setDay3(Day day3)
		{
			this.day3 = day3;
		}
		public Day getDay3()
		{
			return day3;
		}

		//Method that copies the current week object and returns a new week object
		public Week cloneWeek()
		{
			Day newDay1 = day1.cloneDay();
			Day newDay2 = day2.cloneDay();
			Day newDay3 = day3.cloneDay();
			Week week = new Week(weekNumber, newDay1, newDay2, newDay3);
			return week;
		}

		//Method to see if this object equals another Week object
		public override bool Equals(Object obj)
		{
			bool isEqual = true;
			Week week = (Week)obj;

			if (!week.getWeekNumber().Equals(weekNumber)){isEqual = false;}
			else if (!week.getDay1().Equals(day1)){isEqual = false;}
			else if (!week.getDay2().Equals(day2)){ isEqual = false;}
			else if (!week.getDay3().Equals(day3)) { isEqual = false; }

			return isEqual;
		}


		//Method to see if the object is valid
		public bool valid()
		{
			bool isValid = true;

			if (weekNumber == 0) { isValid = false; }
			else if (!day1.valid()) { isValid = false; }
			else if (!day2.valid()) { isValid = false; }
			else if (!day3.valid()) { isValid = false; }

			return isValid;
		}

		//Method to return the object as a string
		public override string ToString()
		{
			StringBuilder str = new StringBuilder();
			str.Append("Week Number: " + weekNumber);
			str.Append("\nDay1: " + day1.ToString());
			str.Append("\nDay2: " + day2.ToString());
			str.Append("\nDay3: " + day3.ToString());

			return str.ToString();

		}


	}//end of Class
}
