using ShareBuildersProject_DataAccess.Models;

namespace ShareBuildersProject_Business.Repository.IRepository
{
	public interface IUserRepository
	{
		public User Create(User obj);
		public User GetById(int id);
		public List<User> GetAll();
		public User Update(User obj);
		public int Delete(int id);
	}
}
