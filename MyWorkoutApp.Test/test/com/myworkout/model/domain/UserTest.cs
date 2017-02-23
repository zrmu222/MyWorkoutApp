using System;
using NUnit.Framework;
using myworkout.model.domain;
using System.Collections.Generic;

namespace test.com.myworkout.model.domain
{
	//[TestFixture]
	public class UserTest
	{

		User user1;
		User user2;
		User userFail = new User();
		Week wk1;
		Exercise ex1;
		IList<int> exerciseNumber;
		IList<Exercise> exerciseList;
		IList<Day> days;
		IList<Week> weeks;

		[SetUp]
		public void setUp()
		{
			ex1 = new Exercise("Overhead Press", 1, 100);
			exerciseList = new List<Exercise>();
			exerciseList.Add(ex1);

			exerciseNumber = new List<int>();
			exerciseNumber.Add(1);
			Day day = new Day(1, 1, exerciseNumber);

			days = new List<Day>();
			days.Add(day);
			wk1 = new Week(1, 1, days);
			weeks = new List<Week>();
			weeks.Add(wk1);
			user1 = new User(1, 1, weeks, exerciseList);
			user2 = new User(1, 1, weeks, exerciseList);
		}


		//Test Equal method
		[TestCase]
		public void equalsTest()
		{
			Console.WriteLine("User : Starting Equals Test");
			Assert.True(user1.Equals(user2));
			Console.WriteLine("Equals Test Passed");
		}

		//Test Equals when it should fail
		[TestCase]
		public void equalsFailTest()
		{
			Console.WriteLine("User : Starting Equals Fail Test");
			Assert.False(user1.Equals(userFail));
			Console.WriteLine("Equals Fail Test Passed");
		}

		//Test getHashCode
		[TestCase]
		public void getHashCodeTest()
		{
			Console.WriteLine("User : Starting getHashCode Test");
			int hashCode = user1.GetHashCode();
			Assert.True(hashCode != 0);
			Console.WriteLine(hashCode);
			Console.WriteLine("GetHashCode Test Passed");
		}

		//Test Validate Method
		[TestCase]
		public void validateTest()
		{
			Console.WriteLine("User : Starting Validate Test");
			Assert.True(user1.validate());
			Console.WriteLine("Validate Test Passed");
		}

		//Test Valid when it should fail
		[TestCase]
		public void validFailTest()
		{
			Console.WriteLine("User : Starting Valid Fail Test");
			Assert.False(userFail.validate());
			Console.WriteLine("Valid Fail Test Passed");
		}

		//Test toString Method
		[TestCase]
		public void toStringTest()
		{
			Console.WriteLine("User : Starting toString Test");
			string str = user1.ToString();
			Assert.True(str != null);
			Console.WriteLine(str);
			Console.WriteLine("ToString Test Passed");
		}



	}//End of Class
}
