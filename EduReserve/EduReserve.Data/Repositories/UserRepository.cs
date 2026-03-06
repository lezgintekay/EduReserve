using EduReserve.Core.Models;
using EduReserve.Core.Interfaces;
using EduReserve.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace EduReserve.Data.Repositories;

public class UserRepository : IUserRepository
{
    private readonly AppDbContext _context;

    public UserRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<User> GetByIdAsync(int id) => 
        await _context.Users.FindAsync(id);

    public async Task<IEnumerable<User>> GetAllAsync() => 
        await _context.Users.ToListAsync();

    public async Task AddAsync(User user) => 
        await _context.Users.AddAsync(user);

    public void Update(User user) => 
        _context.Users.Update(user);

    public void Delete(User user) => 
        _context.Users.Remove(user);

    public async Task<bool> SaveChangesAsync() => 
        await _context.SaveChangesAsync() > 0;
}