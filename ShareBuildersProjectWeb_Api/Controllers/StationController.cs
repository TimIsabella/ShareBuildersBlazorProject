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
				if(stationData.AffiliateIds != null)
				{ _stationCompositeRepository.CreateAffiliate((int)result.Id, stationData.AffiliateIds); }
				
				if(stationData.BroadcastTypeIds != null)
				{ _stationCompositeRepository.CreateBroadcastType((int)result.Id, stationData.BroadcastTypeIds); }
				
				if(stationData.MarketIds != null)
				{ _stationCompositeRepository.CreateMarket((int)result.Id, stationData.MarketIds); }
			}

			return StatusCode(201, result);
		}

		[HttpGet("GetStationById/{id}")]
		public IActionResult GetStationById(int id)
		{
			var result = from station in new List<Station>() { _stationRepository.GetById(id) }
						 select new
						 {
							 Id = station.Id,
							 CallLetters = station.CallLetters,
							 Owner = station.Owner,
							 Format = station.Format,

							 AffiliatesAssigned = (from affiliate in _affiliateRepository.GetAll()
												   join affiliateComp in _stationCompositeRepository.GetAllAffiliates()
												   on affiliate.Id equals affiliateComp.AffiliateId
												   where affiliateComp.StationId == station.Id
												   select new
												   {
													   Id = affiliate.Id,
													   Name = affiliate.Name,
													   ShortName = affiliate.ShortName,
													   City = affiliate.City,
													   State = affiliate.State
												   }).ToList(),

							 BroadcastTypesAssigned = (from broadcastType in _broadcastTypeRepository.GetAll()
													   join broadcastTypeComp in _stationCompositeRepository.GetAllBroadcastTypes()
													   on broadcastType.Id equals broadcastTypeComp.BroadcastTypeId
													   where station.Id == broadcastTypeComp.StationId
													   select new
													   {
														   Id = broadcastType.Id,
														   Name = broadcastType.Name
													   }).ToList(),

							 MarketsAssigned = (from market in _marketRepository.GetAll()
												join marketComp in _stationCompositeRepository.GetAllMarkets()
												on market.Id equals marketComp.MarketId
												where station.Id == marketComp.StationId
												select new
												{
													Id = market.Id,
													Name = market.Name,
													State = market.State
												}).ToList(),
						 };

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

							 AffiliatesAssigned = (from affiliate in _affiliateRepository.GetAll()
												   join affiliateComp in _stationCompositeRepository.GetAllAffiliates()
												   on affiliate.Id equals affiliateComp.AffiliateId
												   where affiliateComp.StationId == station.Id
												   select new
												   {
													   Id = affiliate.Id,
													   Name = affiliate.Name,
													   ShortName = affiliate.ShortName,
													   City = affiliate.City,
													   State = affiliate.State
												   }).ToList(),

							 BroadcastTypesAssigned = (from broadcastType in _broadcastTypeRepository.GetAll()
													   join broadcastTypeComp in _stationCompositeRepository.GetAllBroadcastTypes()
													   on broadcastType.Id equals broadcastTypeComp.BroadcastTypeId
													   where station.Id == broadcastTypeComp.StationId
													   select new
													   {
														   Id = broadcastType.Id,
														   Name = broadcastType.Name
													   }).ToList(),

							 MarketsAssigned = (from market in _marketRepository.GetAll()
												join marketComp in _stationCompositeRepository.GetAllMarkets()
												on market.Id equals marketComp.MarketId
												where station.Id == marketComp.StationId
												select new
												{
													Id = market.Id,
													Name = market.Name,
													State = market.State
												}).ToList(),
						 };

			return StatusCode(200, result);
		}

		[HttpPut("UpdateStation")]
		public IActionResult Update([FromForm] StationDTO stationData)
		{
			Station updatedStation = new Station()
			{
				Id = stationData.Id,
				CallLetters = stationData.CallLetters,
				Owner = stationData.Owner,
				Format = stationData.Format,
			};

			var result = _stationRepository.Update(updatedStation);

			_stationCompositeRepository.DeleteAffiliate((int)stationData.Id);
			_stationCompositeRepository.DeleteBroadcastType((int)stationData.Id);
			_stationCompositeRepository.DeleteMarket((int)stationData.Id);

			if(stationData.AffiliateIds != null)
			{ _stationCompositeRepository.CreateAffiliate((int)result.Id, stationData.AffiliateIds); }

			if(stationData.BroadcastTypeIds != null)
			{ _stationCompositeRepository.CreateBroadcastType((int)result.Id, stationData.BroadcastTypeIds); }

			if(stationData.MarketIds != null)
			{ _stationCompositeRepository.CreateMarket((int)result.Id, stationData.MarketIds); }

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
