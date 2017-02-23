using System;
using System.Collections;
using NUnit.Framework;

using myworkout.model.domain;
using myworkout.model.service.factory;
using myworkout.model.service.completeDayService;
using myworkout.model.service.newUserSetupService;
using myworkout.model.service.exceptions.InvalidUserException;


namespace test.com.myworkout.model.service
{
	[TestFixture]
	public class CompleteDayServiceTest
	{

		Factory factory;
		ICompleteDayService completeDayService;
		INewUserSetUpService newUserSvc;
		User user;
		double ex1Weight;
		double ex3Weight;
		double ex5Weight;


		[SetUp]
		public void setUp()
		{
			factory = Factory.GetInstance();
			completeDayService = (ICompleteDayService)factory.getService(typeof(ICompleteDayService).Name);
			newUserSvc = (INewUserSetUpService)factory.getService(typeof(INewUserSetUpService).Name);
			user = newUserSvc.newUserSetUp();

			foreach (Exercise ex in user.ExerciseList)
			{
				if (ex.ExerciseNumber == 1)
				{
					ex1Weight = ex.Weight;
				}
				else if (ex.ExerciseNumber == 3)
				{
					ex3Weight = ex.Weight;
				}
				else if (ex.ExerciseNumber == 5)
				{
					ex5Weight = ex.Weight;
				}
			}
		}



		//test complete day1 where lastReps are between 5-9
		[TestCase]
		public void completeDay1Test()
		{
			Console.WriteLine("CompleteDayService : Starting CompleteDay1Service Test");
			int currentDay = user.CurrentDay;

			Hashtable hashTable = new Hashtable();
			hashTable.Add(1, 6);
			hashTable.Add(3, 7);
			hashTable.Add(5, 9);

			double user1weight1 = 0;
			double user1weight3 = 0;
			double user1weight5 = 0;

			User user1 = completeDayService.completeDay(user, hashTable);

			if (user1 != null)
			{
				foreach (Exercise ex in user1.ExerciseList)
				{
					if (ex.ExerciseNumber == 1)
					{
						user1weight1 = ex.Weight;
					}
					else if (ex.ExerciseNumber == 3)
					{
						user1weight3 = ex.Weight;
					}
					else if (ex.ExerciseNumber == 5)
					{
						user1weight5 = ex.Weight;
					}
				}
			}
			Assert.True((ex1Weight + 2.5).Equals(user1weight1));
			Assert.True((ex3Weight + 2.5).Equals(user1weight3));
			Assert.True((ex5Weight + 5).Equals(user1weight5));
			Assert.True((currentDay + 1) == user1.CurrentDay);

			Console.WriteLine("CompleteDay1 Test Passed");

		}//End of completeDay1Test


		//Test day1 when lastSetReps are less than 5
		[TestCase]
		public void day1DeloadTest()
		{
			Console.WriteLine("CompleteDayService : Starting day1 deload Test");

			Hashtable hashTable = new Hashtable();
			hashTable.Add(1, 4);
			hashTable.Add(3, 0);
			hashTable.Add(5, 2);

			double user1weight1 = 0;
			double user1weight3 = 0;
			double user1weight5 = 0;

			User user1 = completeDayService.completeDay(user, hashTable);

			if (user1 != null)
			{
				foreach (Exercise ex in user1.ExerciseList)
				{
					if (ex.ExerciseNumber == 1)
					{
						user1weight1 = ex.Weight;
					}
					else if (ex.ExerciseNumber == 3)
					{
						user1weight3 = ex.Weight;
					}
					else if (ex.ExerciseNumber == 5)
					{
						user1weight5 = ex.Weight;
					}
				}
			}
			Assert.True((ex1Weight - (ex1Weight * .10)).Equals(user1weight1));
			Assert.True((ex3Weight - (ex3Weight * .10)).Equals(user1weight3));
			Assert.True((ex5Weight - (ex5Weight * .10)).Equals(user1weight5));

			Console.WriteLine("Day1 deload Test Passed");
		}//end of deload test



		//Test day1 when lastSetReps are grater than 10
		[TestCase]
		public void day1DoubledTest()
		{
			Console.WriteLine("CompleteDayService : Starting day1 double Test");

			Hashtable hashTable = new Hashtable();
			hashTable.Add(1, 10);
			hashTable.Add(3, 11);
			hashTable.Add(5, 15);

			double user1weight1 = 0;
			double user1weight3 = 0;
			double user1weight5 = 0;

			User user1 = completeDayService.completeDay(user, hashTable);

			if (user1 != null)
			{
				foreach (Exercise ex in user1.ExerciseList)
				{
					if (ex.ExerciseNumber == 1)
					{
						user1weight1 = ex.Weight;
					}
					else if (ex.ExerciseNumber == 3)
					{
						user1weight3 = ex.Weight;
					}
					else if (ex.ExerciseNumber == 5)
					{
						user1weight5 = ex.Weight;
					}
				}
			}
			Assert.True((ex1Weight + 5.0).Equals(user1weight1));
			Assert.True((ex3Weight + 5.0).Equals(user1weight3));
			Assert.True((ex5Weight + 10.0).Equals(user1weight5));

			Console.WriteLine("Day1 double Test Passed");
		}//end of deload test



		//Test that it updated the dayNumber correctly
		[TestCase]
		public void testDayNumber()
		{
			Console.WriteLine("CompleteDayService : Starting dayNumber Test");

			user.CurrentDay = 1;
			Hashtable hashTable = new Hashtable();
			hashTable.Add(2, 10);
			hashTable.Add(4, 11);
			hashTable.Add(6, 15);

			User user1 = completeDayService.completeDay(user, hashTable);

			foreach (Week wk in user1.Weeks)
			{
				if (wk.WeekOrderNumber == 1)
				{
					foreach (Day day in wk.Days)
					{
						if (day.DayOrderNumber == 1)
						{
							Assert.True(day.DayNumber == 7);
							Console.WriteLine("dayNumber Test Passed");
						}
					}//end foreach
				}//end of if
			}//end of foreach

		}//end of testDayNumber


		//Test weekOrderNumber changed correctly
		[TestCase]
		public void weekOrderNumberTest()
		{
			Console.WriteLine("CompleteDayService : Starting weekOrderNumberTest");

			user.CurrentDay = 3;
			Hashtable hashTable = new Hashtable();
			hashTable.Add(1, 6);
			hashTable.Add(3, 7);
			hashTable.Add(5, 8);

			User user1 = completeDayService.completeDay(user, hashTable);

			Assert.AreEqual(user1.CurrentWeek, 2);
			Assert.AreEqual(user1.CurrentDay, 1);
			Console.WriteLine("WeekOrderNumber Test Passed");

		}

		//Test weekNumber is updating correctly
		[TestCase]
		public void weekNumberTest()
		{
			Console.WriteLine("CompleteDayService : Starting weekNumber Test");

			user.CurrentDay = 3;
			Hashtable hashTable = new Hashtable();
			hashTable.Add(1, 6);
			hashTable.Add(3, 7);
			hashTable.Add(5, 8);

			User user1 = completeDayService.completeDay(user, hashTable);

			foreach (Week wk in user1.Weeks)
			{
				if (wk.WeekOrderNumber == 1)
				{
					Assert.True(wk.WeekNumber == 3);
					Console.WriteLine("WeekNumber Test Passed");
				}
			}//end of foreach

		}//end of weekNumberTest

		[TestCase]
		public void invalidUserTest()
		{
			Console.WriteLine("CompleteDayService : Starting invalidUser Test");
			User user2 = new User();
			Hashtable hashTable2 = new Hashtable();
			bool passed = false;
			try
			{
				completeDayService.completeDay(user2, hashTable2);
				passed = true;
			}
			catch (InvalidUserException iue)
			{
			}

			Assert.False(passed);
		}






	}//end of class
}
