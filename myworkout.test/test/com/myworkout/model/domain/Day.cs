using System;
using System.Text;

namespace domain
{
	//Day object that holds the exercises the user should do for that day
	public class Day
	{
		//The day number
		int dayNumber;

		//The first exercise the user should do
		Exercise exercise1;

		//The second exercise the user should do
		Exercise exercise2;

		//The third exercise the user should do
		Exercise exercise3;


		//Default constructor
		public Day()
		{
		}

		//Constructor with param of day number, exercise one, exercise two, exercise three
		public Day(int dayNumber, Exercise exercise1, Exercise exercise2, Exercise exercise3)
		{
			this.dayNumber = dayNumber;
			this.exercise1 = exercise1;
			this.exercise2 = exercise2;
			this.exercise3 = exercise3;
		}


		public void setDayNumber(int dayNumber)
		{
			this.dayNumber = dayNumber;
		}
		public int getDayNumber()
		{
			return dayNumber;
		}

		public void setExercise1(Exercise exercise1)
		{
			this.exercise1 = exercise1;
		}
		public Exercise getExercise1()
		{
			return exercise1;
		}

		public void setExercise2(Exercise exercise2)
		{
			this.exercise2 = exercise2;
		}
		public Exercise getExercise2()
		{
			return exercise2;
		}

		public void setExercise3(Exercise exercise3)
		{
			this.exercise3 = exercise3;
		}
		public Exercise getExercise3()
		{
			return exercise3;
		}


		//Method makes a copy of the current day object and returns the new day object
		public Day cloneDay()
		{
			Exercise newExercise1 = exercise1.cloneExercise();
			Exercise newExercise2 = exercise2.cloneExercise();
			Exercise newExercise3 = exercise3.cloneExercise();
			Day day = new Day(dayNumber, newExercise1, newExercise2, newExercise3);

			return day;
		}//End of closeDay


		public bool Equals(Day day)
		{
			bool isEqual = true;
			if (!day.dayNumber.Equals(this.dayNumber))
			{
				isEqual = false;
			}
			else if (!day.getExercise1().Equals(this.exercise1))
			{
				isEqual = false;
			} 
			else if (!day.getExercise2().Equals(this.exercise2))
			{
				isEqual = false;
			} 
			else if (!day.getExercise3().Equals(this.exercise3))
			{
				isEqual = false;
			}

			return isEqual;

		}

		//Check to see if the Day object is valid
		public bool valid()
		{
			bool isValid = true;
			if (dayNumber == 0)
			{
				isValid = false;
			}
			else if (!exercise1.valid())
			{
				isValid = false;
			}
			else if (!exercise2.valid())
			{
				isValid = false;
			}
			else if (!exercise3.valid())
			{
				isValid = false;
			}

			return isValid;
		}//end of valid

		//Method to get the Day object as a string
		public override string ToString()
		{
			StringBuilder str = new StringBuilder();
			str.Append("\nExercse 1\n");
			str.Append(exercise1.ToString());
			str.Append("\nExercise 2\n");
			str.Append(exercise2.ToString());
			str.Append("\nExercise 3\n");
			str.Append(exercise3.ToString());

			return str.ToString();
		}


	}//end of Class
}
