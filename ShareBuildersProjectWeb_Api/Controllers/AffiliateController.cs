using Microsoft.AspNetCore.Mvc;
using ShareBuildersProject_Business.Repository.IRepository;
using ShareBuildersProject_DataAccess.Models;

namespace ShareBuildersProjectWeb_Api.Controllers
{
	[Route("api/Affiliates")]
	[ApiController]
	public class AffiliateController : ControllerBase
	{
		private readonly IAffiliateRepository _affiliateRepository;

		public AffiliateController(IAffiliateRepository affiliateRepository)
		{ _affiliateRepository = affiliateRepository; }

		[HttpPost("CreateAffiliate")]
		public IActionResult CreateAffiliate([FromForm] Affiliate affiliateData)
		{
			var result = _affiliateRepository.Create(affiliateData);
			return StatusCode(201, result);
		}

		[HttpGet("GetAllAffiliates")]
		public IActionResult GetAllAffiliates()
		{
			var result = _affiliateRepository.GetAll();
			return StatusCode(200, result);
		}

		[HttpGet("GetAffiliateById/{id}")]
		public IActionResult GetAffiliateById(int id)
		{
			var result = _affiliateRepository.GetById(id);
			return StatusCode(200, result);
		}

		[HttpPut("UpdateAffiliate")]
		public IActionResult Update([FromForm] Affiliate affiliateData)
		{
			var result = _affiliateRepository.Update(affiliateData);
			return StatusCode(200, result);
		}

		[HttpDelete("DeleteAffiliate/{id}")]
		public IActionResult Delete(int id)
		{
			var result = _affiliateRepository.Delete(id);
			return StatusCode(200, result);
		}
	}
}
