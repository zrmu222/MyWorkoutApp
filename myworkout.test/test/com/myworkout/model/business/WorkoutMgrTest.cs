using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Collections;

using myworkout.model.business;
using myworkout.model.domain;


namespace test.com.myworkout.model.business
{
	[TestFixture]
	public class WorkoutMgrTest
	{
		WorkoutMgr workoutMgr;
		User user;

		[SetUp]
		public void setUp()
		{
			workoutMgr = new WorkoutMgr();
			UserMgr userManager = new UserMgr();
			user = userManager.createUser();
		}



		[TestCase]
		public void getExercisesTest()
		{
			Console.WriteLine("WorkoutMgr : Starting GetExercises Test");
			IList<Exercise> exerciseList = workoutMgr.getExercises(user);
			Assert.NotNull(exerciseList);
			Console.WriteLine("GetExercises Test Passed");
		}



		[TestCase]
		public void completeDayTest()
		{
			Console.WriteLine("UserMgr : Starting CompleteDay Test");

			Hashtable ht = new Hashtable();
			ht.Add(1, 5);
			ht.Add(3, 6);
			ht.Add(5, 5);
			User user1 = workoutMgr.completeDay(user, ht);

			Assert.NotNull(user1);
			Console.WriteLine("CompleteDay Test Passed");
			Console.WriteLine(user1);
		}

		
	}
}
