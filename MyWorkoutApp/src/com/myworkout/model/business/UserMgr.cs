using System;
using System.Collections.Generic;
using System.Collections;

using myworkout.model.domain;
using myworkout.model.service.newUserSetupService;
using myworkout.model.service.factory;
using myworkout.model.service.databaseService;
using myworkout.model.service.exceptions.UserFileException;
using myworkout.model.service.exceptions.InvalidUserException;


namespace myworkout.model.business
{
	public class UserMgr : Manager
	{

		public User createUser()
		{
			INewUserSetUpService newUserService = (INewUserSetUpService)GetService(typeof(INewUserSetUpService).Name);
			User user = newUserService.newUserSetUp();


			return user;
		}


		public User getUser(int id)
		{
			User user = null;
			try
			{
				IDatabaseService dataBaseService = (IDatabaseService)GetService(typeof(IDatabaseService).Name);
				user = dataBaseService.getUser(id);
			}
			catch (UserFileException)
			{
			}


			return user;
		}



		public User saveUser(User u)
		{
			User user = null;
			try
			{
				IDatabaseService dataBaseService = (IDatabaseService)GetService(typeof(IDatabaseService).Name);
				user = dataBaseService.saveUser(u);
			}
			catch (UserFileException)
			{
			}
			return user;
		}

	}
}
