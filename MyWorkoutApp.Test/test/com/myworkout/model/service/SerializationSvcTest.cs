using System;
using NUnit.Framework;
using System.Collections.Generic;

using myworkout.model.domain;
using myworkout.model.service.factory;
using myworkout.model.service.databaseService;
using myworkout.model.service.newUserSetupService;
using myworkout.model.service.exceptions.UserFileException;



namespace test.com.myworkout.model.service
{
	[TestFixture]
	public class SerializationSvcTest
	{
		Factory factory;
		IDatabaseService databaseSvc;
		User user;

		[SetUp]
		public void setUp()
		{
			factory = Factory.GetInstance();
			databaseSvc = (IDatabaseService)factory.getService(typeof(IDatabaseService).Name);
			INewUserSetUpService newUserSetUp = (INewUserSetUpService)factory.getService(typeof(INewUserSetUpService).Name);
			user = newUserSetUp.newUserSetUp();
			Dictionary<int, User> userList = new Dictionary<int, User>();
			userList.Add(0, new User());
		}


		[TestCase]
		public void saveUserTest()
		{
			Console.WriteLine("SerializationSvc : Starting saveUser Test");
			User user1 = null;
			try
			{
				user1 = databaseSvc.saveUser(user);
			}
			catch (UserFileException ufe)
			{
				Console.WriteLine(ufe.StackTrace);
			}

			Assert.NotNull(user1);
			Console.WriteLine("SaveUser Test Passed");
			Console.WriteLine("User_Id: " + user.UserId);

		}




	}
}
