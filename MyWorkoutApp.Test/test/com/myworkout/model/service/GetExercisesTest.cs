using System;
using System.Collections.Generic;
using NUnit.Framework;

using myworkout.model.domain;
using myworkout.model.service.factory;
using myworkout.model.service.getExercisesService;
using myworkout.model.service.newUserSetupService;
using myworkout.model.service.exceptions.InvalidUserException;


namespace test.com.myworkout.model.service
{
	[TestFixture]
	public class GetExercisesTest
	{
		Factory factory;
		IGetExercisesService getExerciseSvc;
		INewUserSetUpService newUserService;
		User user;

		[SetUp]
		public void setUp()
		{
			factory = Factory.GetInstance();
			getExerciseSvc = (IGetExercisesService)factory.getService(typeof(IGetExercisesService).Name);
			newUserService = (INewUserSetUpService)factory.getService(typeof(INewUserSetUpService).Name);
			user = newUserService.newUserSetUp();
		}

		[TestCase]
		public void getUserExercises()
		{
			Console.WriteLine("GetExercises : Starting getUserExercises Test");
			IList<Exercise> exerciseList = getExerciseSvc.getExercises(user);
			Assert.IsNotNull(exerciseList);
			foreach (Exercise ex in exerciseList)
			{
				Console.WriteLine("Exercise Name: " + ex.Name);

			}

		}

		[TestCase]
		public void invalidUser()
		{
			Console.WriteLine("GetExercises : Starting invalidUser Test");
			User user1 = new User();
			IList<Exercise> exerciseList = null;
			bool passed = false;
			try
			{
				exerciseList = getExerciseSvc.getExercises(user1);
				passed = true;
			}
			catch (InvalidUserException iue)
			{
				Console.WriteLine(iue.Message);
			}

			Assert.False(passed);
			Console.WriteLine("InvalidUser Test Passed");

		}


	}
}
