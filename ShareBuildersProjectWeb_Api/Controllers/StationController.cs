using Microsoft.AspNetCore.Mvc;
using ShareBuildersProject_Business.Repository.IRepository;
using ShareBuildersProject_DataAccess.Models;
using ShareBuildersProject_Models.BlazorModels;

namespace ShareBuildersProjectWeb_Api.Controllers
{
	[Route("api/Stations")]
	[ApiController]
	public class StationController : ControllerBase
	{
		private readonly IAffiliateRepository _affiliateRepository;
		private readonly IBroadcastTypeRepository _broadcastTypeRepository;
		private readonly IMarketRepository _marketRepository;
		private readonly IStationRepository _stationRepository;
		private readonly IStationCompositeRepository _stationCompositeRepository;
		private readonly IUserRepository _userRepository;

		public StationController(IAffiliateRepository affiliateRepository, 
								IBroadcastTypeRepository broadcastTypeRepository, 
								IMarketRepository marketRepository, 
								IStationRepository stationRepository, 
								IStationCompositeRepository stationCompositeRepository, 
								IUserRepository userRepository)
		{
			_affiliateRepository = affiliateRepository;
			_broadcastTypeRepository = broadcastTypeRepository;
			_marketRepository = marketRepository;
			_stationRepository = stationRepository;
			_stationCompositeRepository = stationCompositeRepository;
			_userRepository = userRepository;
		}

		[HttpPost("CreateStation")]
		public IActionResult CreateStation([FromForm] StationDTO stationData)
		{
			Station newStation = new Station()
			{
				CallLetters = stationData.CallLetters,
				Owner = stationData.Owner,
				Format = stationData.Format,
			};

			var result = _stationRepository.Create(newStation);

			if(result.Id != null)
			{
				_stationCompositeRepository.CreateAffiliate((int)result.Id, stationData.AffiliateIds);			//Affiliate
				_stationCompositeRepository.CreateBroadcastType((int)result.Id, stationData.BroadcastTypeIds);	//BroadcastType
				_stationCompositeRepository.CreateMarket((int)result.Id, stationData.MarketIds);				//Market
			}

			return StatusCode(201, result);
		}

		[HttpGet("GetStationById/{id}")]
		public IActionResult GetStationById(int id)
		{
			var result = _stationRepository.GetById(id);
			return StatusCode(200, result);
		}

		[HttpGet("GetAllStations")]
		public IActionResult GetAllStations()
		{
			var result = from station in _stationRepository.GetAll()
						 select new
						 {
							 Id = station.Id,
							 CallLetters = station.CallLetters,
							 Owner = station.Owner,
							 Format = station.Format,

							 AffiliatesAssigned = (from affiliateComp in _stationCompositeRepository.GetAllAffiliates()
												   where station.Id == affiliateComp.StationId
												   from affiliate in _affiliateRepository.GetAll()
												   where affiliate.Id ==affiliateComp.StationId
												   select new
												   { 
														Id = affiliate.Id,
														Name = affiliate.Name,
														ShortName = affiliate.ShortName,
														City = affiliate.City,
														State = affiliate.State
												   }).ToList(),

							 //BroadcastTypesAssigned = ().ToList(),

							 //MarketsAssigned = ().ToList(),
						 };

			return StatusCode(200, result);
		}

		[HttpPut("UpdateStation")]
		public IActionResult Update([FromForm] StationDTO stationData)
		{
			Station updatedStation = new Station()
			{
				CallLetters = stationData.CallLetters,
				Owner = stationData.Owner,
				Format = stationData.Format,
			};

			var result = _stationRepository.Update(updatedStation);

			_stationCompositeRepository.DeleteAffiliate((int)stationData.Id);
			_stationCompositeRepository.DeleteBroadcastType((int)stationData.Id);
			_stationCompositeRepository.DeleteMarket((int)stationData.Id);

			_stationCompositeRepository.CreateAffiliate((int)stationData.Id, stationData.AffiliateIds);
			_stationCompositeRepository.CreateBroadcastType((int)stationData.Id, stationData.BroadcastTypeIds);
			_stationCompositeRepository.CreateMarket((int)stationData.Id, stationData.MarketIds);

			return StatusCode(200, result);
		}

		[HttpDelete("DeleteStation/{id}")]
		public IActionResult Delete(int id)
		{
			var result = _stationRepository.Delete(id);

			_stationCompositeRepository.DeleteAffiliate(id);
			_stationCompositeRepository.DeleteBroadcastType(id);
			_stationCompositeRepository.DeleteMarket(id);

			return StatusCode(200, result);
		}
	}
}
