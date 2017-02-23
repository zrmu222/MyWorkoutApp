using System;
using NUnit.Framework;

using myworkout.model.domain;
using myworkout.model.service.factory;
using myworkout.model.service.newUserSetupService;


namespace test.com.myworkout.model.service
{
	[TestFixture]
	public class NewUserSetupTest
	{

		Factory factory;
		INewUserSetUpService userSetUp1;


		[SetUp]
		public void setUp()
		{
			factory = Factory.GetInstance();
			userSetUp1 = (INewUserSetUpService)factory.getService(typeof(INewUserSetUpService).Name);

		}


		[TestCase]
		public void getNewUserTest()
		{
			Console.WriteLine("NewUserSetup : Starting getNewUser Test");
			User user = userSetUp1.newUserSetUp();
			Assert.True(user.validate());
			Console.WriteLine(user);
			Console.WriteLine("GetNewUser Test Passed");



		}


	}
	
}
