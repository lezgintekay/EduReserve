using EduReserve.Core.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace EduReserve.Core.Models;

public class User
{
    public User(string passwordHash)
    {
        PasswordHash = passwordHash;
    }

    public int Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string  Email { get; set; } = string.Empty;
    [Column("PasswordHash")] 
    public string PasswordHash { get; set; }   
    public UserRole Role { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public bool IsActive { get; set; } = true; 

}