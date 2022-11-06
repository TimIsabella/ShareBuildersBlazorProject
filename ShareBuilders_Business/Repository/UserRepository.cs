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
			var user = _dbContext.Users.Find(id);

			if(user != null)
			{
				return user;
			}
			else return new User();
		}

		public User Update(User obj)
		{
			var user = _dbContext.Users.Find(obj.Id);

			if(user != null)
			{
				user.FirstName = obj.FirstName;
				user.LastName = obj.LastName;

				_dbContext.Users.Update(user);
				_dbContext.SaveChanges();

				return user;
			}
			else return user;
		}

		public int Delete(int id)
		{
			var user = _dbContext.Users.Find(id);

			if(user != null)
			{
				_dbContext.Users.Remove(user);
				return _dbContext.SaveChanges();
			}
			else return 0;
		}
	}
}
