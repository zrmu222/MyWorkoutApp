using System;
using myworkout.model.domain;


namespace myworkout.model.service.databaseService
{
	public class SqlSvcImpl : IDatabaseService
	{
		public SqlSvcImpl()
		{
		}

		public User getUser(int id)
		{
			Console.WriteLine("Starting getUser service");
			User user = new User();
			return user;
		}

		User IDatabaseService.saveUser(User user)
		{
			throw new NotImplementedException();
		}
	}
}
