using Microsoft.AspNetCore.Mvc;
using ShareBuildersProject_Business.Repository.IRepository;
using ShareBuildersProject_DataAccess.Models;

namespace ShareBuildersProjectWeb_Api.Controllers
{
	[Route("api/BroadcastTypes")]
	[ApiController]
	public class BroadcastTypeController : ControllerBase
	{
		private readonly IBroadcastTypeRepository _broadcastTypeRepository;

		public BroadcastTypeController(IBroadcastTypeRepository broadcastTypeRepository)
		{ _broadcastTypeRepository = broadcastTypeRepository; }

		[HttpPost("CreateBroadcastType")]
		public IActionResult CreateBroadcastType([FromForm] BroadcastType broadcastTypeData)
		{
			var result = _broadcastTypeRepository.Create(broadcastTypeData);
			return StatusCode(201, result);
		}

		[HttpGet("GetAllBroadcastTypes")]
		public IActionResult GetAllBroadcastTypes()
		{
			var result = _broadcastTypeRepository.GetAll();
			return StatusCode(200, result);
		}

		[HttpGet("GetBroadcastTypeById/{id}")]
		public IActionResult GetBroadcastTypeById(int id)
		{
			var result = _broadcastTypeRepository.GetById(id);
			return StatusCode(200, result);
		}

		[HttpPut("UpdateBroadcastType")]
		public IActionResult Update([FromForm] BroadcastType broadcastTypeData)
		{
			var result = _broadcastTypeRepository.Update(broadcastTypeData);
			return StatusCode(200, result);
		}

		[HttpDelete("DeleteBroadcastType/{id}")]
		public IActionResult Delete(int id)
		{
			var result = _broadcastTypeRepository.Delete(id);
			return StatusCode(200, result);
		}
	}
}
