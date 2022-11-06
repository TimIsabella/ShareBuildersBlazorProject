using ShareBuildersProject_Business.Repository.IRepository;
using ShareBuildersProject_DataAccess.Data;
using ShareBuildersProject_DataAccess.Models;

namespace ShareBuildersProject_Business.Repository
{
	public class UserRepository : IUserRepository
	{
		private readonly ApplicationDbContext _dbContext;

		public UserRepository(ApplicationDbContext dbContext)
		{ _dbContext = dbContext; }

		public User Create(User obj)
		{
			User newUser = new User()
			{
				FirstName = obj.FirstName,
				LastName = obj.LastName,
				CreationDate = DateTime.Now
			};

			_dbContext.Users.Add(newUser);
			_dbContext.SaveChanges();

			return newUser;
		}

		public List<User> GetAll()
		{
			var userList = _dbContext.Users.ToList();
			return userList;
		}

		public User GetById(int id)
		{
			var user = _dbContext.Users.First(element => element.Id == id);

			if(user != null)
			{
				return user;
			}
			else return new User();
		}

		public User Update(User obj)
		{
			var user = _dbContext.Users.First(element => element.Id == obj.Id);

			if(user != null)
			{
				User updatedUser = new User()
				{
					Id = user.Id,
					FirstName = obj.FirstName,
					LastName = obj.LastName,
					CreationDate = user.CreationDate
				};

				_dbContext.Users.Update(updatedUser);
				_dbContext.SaveChanges();

				return updatedUser;
			}
			else return user;
		}

		public int Delete(int id)
		{
			var user = _dbContext.Users.First(element => element.Id == id);

			if(user != null)
			{
				_dbContext.Users.Remove(user);
				return _dbContext.SaveChanges();
			}
			else return 0;
		}
	}
}
