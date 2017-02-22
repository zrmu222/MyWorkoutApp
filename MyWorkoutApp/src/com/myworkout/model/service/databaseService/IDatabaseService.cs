using System;
using myworkout.model.domain;

namespace myworkout.model.service.databaseService
{
	public interface IDatabaseService : IService
	{
		User getUser(int id);

		User saveUser(User user);

	}


}
