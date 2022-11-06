using Microsoft.AspNetCore.Mvc;
using ShareBuildersProject_Business.Repository.IRepository;
using ShareBuildersProject_DataAccess.Models;

namespace ShareBuildersProjectWeb_Api.Controllers
{
	[Route("api/Markets")]
	[ApiController]
	public class MarketController : ControllerBase
	{
		private readonly IMarketRepository _marketRepository;

		public MarketController(IMarketRepository marketRepository)
		{ _marketRepository = marketRepository; }

		[HttpPost("CreateMarket")]
		public IActionResult CreateMarket([FromForm] Market marketData)
		{
			var result = _marketRepository.Create(marketData);
			return StatusCode(201, result);
		}

		[HttpGet("GetAllMarkets")]
		public IActionResult GetAllMarkets()
		{
			var result = _marketRepository.GetAll();
			return StatusCode(200, result);
		}

		[HttpGet("GetMarketById/{id}")]
		public IActionResult GetMarketById(int id)
		{
			var result = _marketRepository.GetById(id);
			return StatusCode(200, result);
		}

		[HttpPut("UpdateMarket")]
		public IActionResult Update([FromForm] Market marketData)
		{
			var result = _marketRepository.Update(marketData);
			return StatusCode(200, result);
		}

		[HttpDelete("DeleteMarket/{id}")]
		public IActionResult Delete(int id)
		{
			var result = _marketRepository.Delete(id);
			return StatusCode(200, result);
		}
	}
}
