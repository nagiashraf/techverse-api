using Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public sealed class ApplicationDbContext(DbContextOptions options)
    : DbContext(options), IUnitOfWork
{
}
