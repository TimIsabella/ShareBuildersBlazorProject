using ShareBuildersProject_Business.Repository.IRepository;
using ShareBuildersProject_DataAccess.Data;
using ShareBuildersProject_DataAccess.Models;

namespace ShareBuildersProject_Business.Repository
{
	public class UserRepository : IUserRepository
	{
		private readonly ApplicationDbContext _dbContext;

		public UserRepository(ApplicationDbContext dbContext)
		{
			_dbContext = dbContext;
		}

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
			var obj = _dbContext.Users.ToList();

			return obj;
		}

		public User GetById(int id)
		{
			var obj = _dbContext.Users.First(user => user.Id == id);

			if(obj != null)
			{
				return obj;
			}
			else return new User();
		}

		public User Update(User obj)
		{
			var user = _dbContext.Users.First(user => user.Id == obj.Id);

			if(user != null)
			{
				User newUser = new User()
				{
					Id = user.Id,
					FirstName = obj.FirstName,
					LastName = obj.LastName,
					CreationDate = user.CreationDate
				};

				_dbContext.Users.Update(newUser);
				_dbContext.SaveChanges();

				return newUser;
			}
			else return obj;
		}

		public int Delete(int id)
		{
			var obj = _dbContext.Users.First(user => user.Id == id);

			if(obj != null)
			{
				_dbContext.Users.Remove(obj);
				return _dbContext.SaveChanges();
			}
			else return 0;
		}
	}
}
