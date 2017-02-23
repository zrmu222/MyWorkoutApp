using System;
using NUnit.Framework;
using System.Collections.Generic;

using myworkout.model.domain;

namespace test.com.myworkout.model.domain
{
	//[TestFixture]
	public class WeekTest
	{
		Week wk1;
		Week wk2;
		Week wkFail = new Week();
		int weekNumber;
		int weekOrder;
		Day day1;
		IList<int> exerciseList;
		IList<Day> days;


		[SetUp]
		public void setUp()
		{
			weekNumber = 1;
			weekOrder = 1;
			exerciseList = new List<int>();
			exerciseList.Add(1);
			exerciseList.Add(2);
			exerciseList.Add(3);
			days = new List<Day>();
			day1 = new Day(1, 1, exerciseList);
			days.Add(day1);
			wk1 = new Week(weekNumber, weekOrder, days);

			wk2 = new Week(2, 2, days);
		}


		//Test Equals method
		[TestCase]
		public void equalsTest()
		{
			Console.WriteLine("Week : Starting Equals Test");
			Week week = new Week(1, 1, days);
			Assert.True(week.Equals(wk1));
			Console.WriteLine("Equals Test Passed");
		}

		//Test equals when it should fail
		[TestCase]
		public void equalsFailTest()
		{
			Console.WriteLine("Week : Starting Equals Fail Test");
			Assert.False(wk2.Equals(wk1));
			Console.WriteLine("Equals Fail Test Passed");
		}

		//Test Valid Method
		[TestCase]
		public void validTest()
		{
			Console.WriteLine("Week : Starting Valid Test");
			Assert.True(wk1.validate());
			Console.WriteLine("Valid Test Passed");
		}

		//test Valid method when it should fail
		[TestCase]
		public void validFailTest()
		{
			Console.WriteLine("Week : Starting Valid Fail Test");
			Assert.False(wkFail.validate());
			Console.WriteLine("Valid Fail Test Passed");

		}


		//Test ToString method
		[TestCase]
		public void toStringTest()
		{
			Console.WriteLine("Week : Starting ToString Test");
			string str = wk1.ToString();
			Assert.True(str != null);
			Console.WriteLine(str);
			Console.WriteLine("ToString Test Passed");
		}

		//Test GetHashCode method
		[TestCase]
		public void getHashCodeTest()
		{
			Console.WriteLine("Week : Starting getHashCode Test");
			int hashCode = wk1.GetHashCode();
			Assert.True(hashCode != 0);
			Console.WriteLine(hashCode);
			Console.WriteLine("GetHashCode Test Passed");
		}


	}//End of Class
}
