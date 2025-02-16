using DotnetEfPropsTesting.Entities;
using Microsoft.EntityFrameworkCore;

namespace DotnetEfPropsTesting.Database;

public class AppDbContext : DbContext
{
    public required DbSet<User> Users { get; set; }
}