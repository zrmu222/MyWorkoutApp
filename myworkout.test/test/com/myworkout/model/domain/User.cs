using System;
using System.Text;

using System.Collections;

namespace domain
{
	//User object that holds the user info along with the workout information
	public class User
	{
		//The day the user is currently on
		Day currentDay;
		//The week the user is currently on
		Week currentWeek;
		//The day the user should complete after the current day is complete 
		Day nextDay;
		//The week the user should complete after the current week is complete 
		Week nextWeek;
		//Exercise object that holds the overhead press exercise
		Exercise overheadPress;
		//Exercise object that holds the chinup exercise
		Exercise chinUps;
		//Exercise object that holds the squats exercise
		Exercise squats;
		//Exercise object that holds the benchPress exercise
		Exercise benchPress;
		//Exercise object that holds the barbellRows exercise
		Exercise barbellRows;
		//Exercise object that holds the dealift exercise
		Exercise deadLifts;
		//Hashtable that holds the weeks the user can complete. key = week number value = Week Object
		Hashtable completedWeeks = new Hashtable();

		//Default contructor
		public User()
		{
		}

		public User(Day currentDay, Week currentWeek, Day nextDay, Week nextWeek, Exercise overheadPress,
		           Exercise chinUps, Exercise squats, Exercise benchPress, Exercise barbellRows, Exercise deadLifts)
		{
			this.currentDay = currentDay;
			this.currentWeek = currentWeek;
			this.nextDay = nextDay;
			this.nextWeek = nextWeek;
			this.overheadPress = overheadPress;
			this.chinUps = chinUps;
			this.squats = squats;
			this.benchPress = benchPress;
			this.barbellRows = barbellRows;
			this.deadLifts = deadLifts;

		}


		public void setCurrentDay(Day currentDay)
		{
			this.currentDay = currentDay;
		}
		public Day getCurrentDay()
		{
			return currentDay;
		}

		public void setCurrentWeek(Week currentWeek)
		{
			this.currentWeek = currentWeek;
		}
		public Week getCurrentWeek()
		{
			return currentWeek;
		}

		public void setNextDay(Day nextDay)
		{
			this.nextDay = nextDay;
		}
		public Day getNextDay()
		{
			return nextDay;
		}

		public void setNextWeek(Week nextWeek)
		{
			this.nextWeek = nextWeek;
		}
		public Week getNextWeek()
		{
			return nextWeek;
		}

		public void setOverheadPress(Exercise overheadPress)
		{
			this.overheadPress = overheadPress;
		}
		public Exercise getOverheadPress()
		{
			return overheadPress;
		}

		public void setChinUps(Exercise chinUps)
		{
			this.chinUps = chinUps;
		}
		public Exercise getChinUps()
		{
			return chinUps;
		}

		public void setSquats(Exercise squats)
		{
			this.squats = squats;
		}
		public Exercise getSquats()
		{
			return squats;
		}

		public void setBenchPress(Exercise benchPress)
		{
			this.benchPress = benchPress;
		}
		public Exercise getBenchPress()
		{
			return benchPress;
		}

		public void setBarbellRows(Exercise barbellRows)
		{
			this.barbellRows = barbellRows;
		}
		public Exercise getBarbellRows()
		{
			return barbellRows;
		}

		public void setDeadLifts(Exercise deadLifts)
		{
			this.deadLifts = deadLifts;
		}
		public Exercise getDeadLifts()
		{
			return deadLifts;
		}

		//Method that adds a week to the completed week hashtable. Takes in a Week object
		public void addCompletedWeek(Week completedWeek)
		{
			completedWeeks.Add(completedWeek.getWeekNumber(), completedWeek);
		}
		//Method that returns a hashtable that contains the weeks the user has completed
		public Hashtable getCompletedWeeks()
		{
			return completedWeeks;
		}

		//Method to check if this user is equal to another user
		public override bool Equals(object obj)
		{
			bool isEqual = true;
			User user = (User)obj;

			if (!user.getCurrentDay().Equals(currentDay)){isEqual = false; }
			else if (!user.getCurrentWeek().Equals(currentWeek)) { isEqual = false; }
			else if (!user.getNextDay().Equals(nextDay)) { isEqual = false; }
			else if (!user.getNextWeek().Equals(nextWeek)) { isEqual = false; }
			else if (!user.getOverheadPress().Equals(overheadPress)) { isEqual = false; }
			else if (!user.getChinUps().Equals(chinUps)) { isEqual = false; }
			else if (!user.getSquats().Equals(squats)) { isEqual = false; }
			else if (!user.getDeadLifts().Equals(deadLifts)) { isEqual = false; }
			else if (!user.getBenchPress().Equals(benchPress)) { isEqual = false; }
			else if (!user.getBarbellRows().Equals(barbellRows)) { isEqual = false; }
			else if (!user.getCompletedWeeks().Equals(completedWeeks)) { isEqual = false; }

			return isEqual;
		}

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}


		//Method to validate user object
		public bool valid()
		{
			bool isValid = true;

			if (!currentDay.valid()) { isValid = false; }
			else if (!currentWeek.valid()){ isValid = false;}
			else if (!nextDay.valid()){ isValid = false; }
			else if (!nextWeek.valid()) { isValid = false; }
			else if (!overheadPress.valid()) { isValid = false; }
			else if (!chinUps.valid()) { isValid = false; }
			else if (!squats.valid()) { isValid = false; }
			else if (!deadLifts.valid()) { isValid = false; }
			else if (!benchPress.valid()) { isValid = false; }
			else if (!barbellRows.valid()) { isValid = false; }


			return isValid;
		}

		//Method to change User object into a string
		public override string ToString()
		{
			StringBuilder str = new StringBuilder();
			str.Append("Current Day: " + currentDay.ToString());
			str.Append("\nCurrent Week: " + currentWeek.ToString());
			str.Append("\nNext Day: " + nextDay.ToString());
			str.Append("\nNext Week: " + nextWeek.ToString());
			str.Append("\nOverhead Press: " + overheadPress.ToString());
			str.Append("\nChinup: " + chinUps.ToString());
			str.Append("\nSquats: " + squats.ToString());
			str.Append("\nBench Press: " + benchPress.ToString());
			str.Append("\nBarbell Rows: " + barbellRows.ToString());
			str.Append("\nDead Lifts: " + deadLifts.ToString());
			str.Append("\nCompleted Weeks: " + completedWeeks.ToString());

			return str.ToString();
		}

	}
}
