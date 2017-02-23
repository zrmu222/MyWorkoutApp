using System;
using NUnit.Framework;

using myworkout.model.service.factory;
using myworkout.model.service.completeDayService;
using myworkout.model.service.getExercisesService;
using myworkout.model.service.newUserSetupService;
using myworkout.model.service.databaseService;


namespace test.com.myworkout.model.service
{
	[TestFixture]
	public class FactoryTest
	{
		Factory factory;

		[SetUp]
		public void setUp()
		{
			factory = Factory.GetInstance();
		}


		[TestCase]
		public void completeDayTest()
		{
			Console.WriteLine("Factory : Starting getCompleteDayService Test");
			ICompleteDayService completeDayservice = (ICompleteDayService)factory.getService(typeof(ICompleteDayService).Name);
			Assert.That(completeDayservice, Is.InstanceOf(typeof(ICompleteDayService)));
			Console.WriteLine("GetCompleteDayService Test Passed");
		}

		[TestCase]
		public void getExercisesSvcTest()
		{
			Console.WriteLine("Factory : Starting getExerciseSvc Test");
			IGetExercisesService exerciseService = (IGetExercisesService)factory.getService(typeof(IGetExercisesService).Name);
			Assert.That(exerciseService, Is.InstanceOf(typeof(IGetExercisesService)));
			Console.WriteLine("GetExerciseSvc Test Passed");
		}

		[TestCase]
		public void getNewUserSvcTest()
		{
			Console.WriteLine("Factory : Starting getNewUserSvc Test");
			INewUserSetUpService newUserService = (INewUserSetUpService) factory.getService(typeof(INewUserSetUpService).Name);
			Assert.That(newUserService, Is.InstanceOf(typeof(NewUserSvcImpl)));
			Console.WriteLine("GetNewUser Service Test Passed");
		}

		[TestCase]
		public void getSqlSvc()
		{
			Console.WriteLine("Factory : Starting databaseService Test");
			IDatabaseService dbService = (IDatabaseService)factory.getService(typeof(IDatabaseService).Name);
			Assert.That(dbService, Is.InstanceOf(typeof(IDatabaseService)));
			Console.WriteLine("getDatabaseService Service Test Passed");
		}


	}//End of Class
}
