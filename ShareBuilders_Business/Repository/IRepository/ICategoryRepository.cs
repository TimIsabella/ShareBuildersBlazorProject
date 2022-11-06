using ShareBuildersProject_DataAccess;
using ShareBuildersProject_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareBuildersProject_Business.Repository.IRepository
{
	public interface ICategoryRepository
	{
		public Category Create(Category obj);
		public Category GetById(int id);
		public IEnumerable<Category> GetAll();
		public Category Update(Category obj);
		public int Delete(int id);
	}
}
