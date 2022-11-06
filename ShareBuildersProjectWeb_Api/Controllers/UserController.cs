﻿using Microsoft.AspNetCore.Mvc;
using ShareBuildersProject_Business.Repository.IRepository;
using ShareBuildersProject_DataAccess.Models;
using ShareBuildersProject_Models.BlazorModels;

namespace ShareBuildersProjectWeb_Api.Controllers
{
	public class UserController : ControllerBase
	{
		private readonly IUserRepository _userRepository;
		private readonly IUserCompositeRepository _userCompositeRepository;
		private readonly IStationRepository _stationRepository;

		public UserController(IUserRepository userRepository, IUserCompositeRepository userCompositeRepository, IStationRepository stationRepository)
		{
			_userRepository = userRepository;
			_userCompositeRepository = userCompositeRepository;
			_stationRepository = stationRepository;
		}

		[HttpPost("CreateUser")]
		public IActionResult CreateUser([FromForm] UserDTO userData)
		{
			User newUser = new User()
			{
				FirstName = userData.FirstName,
				LastName = userData.LastName,
			};

			var result = _userRepository.Create(newUser);

			if(result.Id != null)
			{ _userCompositeRepository.Create((int)result.Id, userData.StationIds); }

			return StatusCode(201, result);
		}

		[HttpGet("GetAllUsers")]
		public IActionResult GetAllUsers()
		{
			var result = _userRepository.GetAll();

			return StatusCode(200, result);
		}

		[HttpGet("GetAllUsersAssignedToStations")]
		public IActionResult GetAllUsersAssignedToStations()
		{
			var result = from user in _userRepository.GetAll()
						 select new
						 {
							 Id = user.Id,
							 FirstName = user.FirstName,
							 LastName = user.LastName,
							 StationsAssigned = (from userComp in _userCompositeRepository.GetAll()
												 where user.Id == userComp.UserId
												 from station in _stationRepository.GetAll()
												 where station.Id == userComp.StationId
												 select new
												 {
													 Id = station.Id,
													 Name = station.CallLetters,
													 Owner = station.Owner,
													 Format = station.Format
												 }).ToList(),

							CreationDate = user.CreationDate
						 };

			return StatusCode(200, result);
		}

		[HttpPut("UpdateUser")]
		public IActionResult Update([FromForm] UserDTO userData)
		{
			User newUser = new User()
			{
				Id = userData.Id,
				FirstName = userData.FirstName,
				LastName = userData.LastName,
			};

			var result = _userRepository.Update(newUser);

			_userCompositeRepository.Delete((int)userData.Id);
			_userCompositeRepository.Create((int)userData.Id, userData.StationIds);

			return StatusCode(200, result);
		}

		[HttpDelete("DeleteUser")]
		public IActionResult Delete(int id)
		{
			var result = _userRepository.Delete(id);
			_userCompositeRepository.Delete(id);

			return StatusCode(200, result);
		}
	}
}