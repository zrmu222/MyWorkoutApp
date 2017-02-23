using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Collections;

using myworkout.model.business;
using myworkout.model.domain;

namespace test.com.myworkout.model.business
{
	[TestFixture]
	public class UserMgrTest
	{
		UserMgr userManager;
		User user1;

		[SetUp]
		public void setUp()
		{
			userManager = new UserMgr();
			user1 = userManager.createUser();
		}


		[TestCase]
		public void createuserTest()
		{
			Console.WriteLine("UserMgr : Starting CreateUser Test");
			User user = userManager.createUser();
			Assert.NotNull(user);
			Console.WriteLine("CreateUser Test Passed");
		}


		[TestCase]
		public void getUserTest()
		{
			Console.WriteLine("UserMgr : Starting GetUser Test");
			User user = userManager.getUser(1);
			Assert.NotNull(user);
			Console.WriteLine("GetUser Test Passed");
		}

		[TestCase]
		public void saveUserTest()
		{
			Console.WriteLine("UserMgr : Starting SaveUser Test");
			User user = userManager.saveUser(user1);
			Assert.NotNull(user);
			Console.WriteLine("SaveUser Test Passed");
		}

	}
}
