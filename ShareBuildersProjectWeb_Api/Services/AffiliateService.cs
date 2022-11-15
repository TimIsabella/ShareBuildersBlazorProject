using ShareBuildersProject_Business.Repository.IRepository;
using ShareBuildersProject_DataAccess.Models;

namespace ShareBuildersProjectWeb_Api.Services
{
	public class AffiliateService
	{
		private readonly IAffiliateRepository _affiliateRepository;

		public AffiliateService(IAffiliateRepository affiliateRepository)
		{ _affiliateRepository = affiliateRepository; }

		public Affiliate CreateAffiliate(Affiliate affiliateData)
		{ return _affiliateRepository.Create(affiliateData); }

		public IEnumerable<Affiliate> GetAllAffiliates()
		{ return _affiliateRepository.GetAll(); }

		public Affiliate GetAffiliateById(int id)
		{ return _affiliateRepository.GetById(id); }

		public Affiliate Update(Affiliate affiliateData)
		{ return _affiliateRepository.Update(affiliateData); }

		public int Delete(int id)
		{ return _affiliateRepository.Delete(id); }
	}
}
