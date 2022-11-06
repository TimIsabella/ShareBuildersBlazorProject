using ShareBuildersProject_Business.Repository.IRepository;
using ShareBuildersProject_DataAccess;
using ShareBuildersProject_DataAccess.Data;
using ShareBuildersProject_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareBuildersProject_Business.Repository
{
	public class CategoryRepository : ICategoryRepository
	{
		private readonly ApplicationDbContext _dbContext;

		public CategoryRepository(ApplicationDbContext dbContext)
		{
			_dbContext = dbContext;
		}

		public Category Create(Category obj)
		{
			Category newCategory = new Category()
			{
				Id = obj.Id,
				Name = obj.Name,
				CreationDate = DateTime.Now
			};

			_dbContext.Categories.Add(newCategory);
			_dbContext.SaveChanges();

			return newCategory;
		}

		public IEnumerable<Category> GetAll()
		{
			var obj = _dbContext.Categories.ToList();

			return obj;
		}

		public Category GetById(int id)
		{
			var obj = _dbContext.Categories.First(category => category.Id == id);

			if(obj != null)
			{
				return obj;
			}
			else return new Category();
		}

		public Category Update(Category obj)
		{
			var category = _dbContext.Categories.First(category => category.Id == obj.Id);

			if(category != null)
			{
				Category updatedCategory = new Category()
				{
					Id = category.Id,
					Name = obj.Name,
					CreationDate = category.CreationDate
				};

				_dbContext.Categories.Update(updatedCategory);
				_dbContext.SaveChanges();

				return updatedCategory;
			}
			else return obj;
		}

		public int Delete(int id)
		{
			var obj = _dbContext.Categories.First(category => category.Id == id);

			if(obj != null)
			{
				_dbContext.Categories.Remove(obj);
				return _dbContext.SaveChanges();
			}
			else return 0;
		}
	}
}
