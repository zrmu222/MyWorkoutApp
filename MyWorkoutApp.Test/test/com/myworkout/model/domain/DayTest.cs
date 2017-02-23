using System;
using NUnit.Framework;
using System.Collections.Generic;

using myworkout.model.domain;

namespace test.com.myworkout.model.domain
{
	//[TestFixture]
	public class DayTest
	{
		Day day;
		Day day2;
		Day dayFail;
		int dayNumber;
		int dayOrder;

		[SetUp]
		public void setUp()
		{
			dayNumber = 1;
			dayOrder = 1;
			IList<int> exerciseNumber = new List<int>();
			exerciseNumber.Add(1);
			exerciseNumber.Add(2);
			exerciseNumber.Add(3);
			day = new Day(dayNumber, dayOrder, exerciseNumber);
			day2 = new Day(dayNumber, dayOrder, exerciseNumber);
			dayFail = new Day();
		}


		//Test valid method
		[TestCase]
		public void validTest()
		{
			Console.WriteLine("Day : Starting Day Valid Test");
			Assert.True(day.validate());
			Console.WriteLine("Day Valid Test Passed");
		}

		//Test valid when it should fail
		[TestCase]
		public void validFailTest()
		{
			Console.WriteLine("Day : Starting Valid Fail Test");
			Assert.False(dayFail.validate());
			Console.WriteLine("Valida Fail Test Passed");
		}


		//Test toString method
		[TestCase]
		public void toStringTest()
		{
			Console.WriteLine("Day : Starting toString Test");
			string str = day.ToString();
			Assert.True(str != null);
			Console.WriteLine(str);
			Console.WriteLine("ToString Test Passed");
		}

		//Test Equals
		[TestCase]
		public void equalsTest()
		{
			Console.WriteLine("Day : Starting Equals Test");
			Assert.True(day.Equals(day2));
			Console.WriteLine("Equals Test Passed");
		}

		//TEst Equals when it should fail
		[TestCase]
		public void equalsFailTest()
		{
			Console.WriteLine("Day : Starting Equals Fail Test");
			Assert.False(day.Equals(dayFail));
			Console.WriteLine("Equals Fail Test Passed");
		}

	}//End of DayTest Class
}
