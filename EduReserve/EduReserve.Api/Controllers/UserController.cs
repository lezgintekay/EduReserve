using EduReserve.Core.Interfaces;
using EduReserve.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace EduReserve.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    private readonly IUserRepository _userRepository;

    public UsersController(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    [HttpGet]
    public async Task<IActionResult> GetUsers()
    {
        var users = await _userRepository.GetAllAsync();
        return Ok(users);
    }

    [HttpPost]
    public async Task<IActionResult> CreateUser(User user)
    {
        await _userRepository.AddAsync(user);
        await _userRepository.SaveChangesAsync();
        return Ok(user);
    }
}