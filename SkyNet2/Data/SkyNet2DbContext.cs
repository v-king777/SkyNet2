using Microsoft.EntityFrameworkCore;
using SkyNet2.Models.Users;

namespace SkyNet2.Data;

public class SkyNet2DbContext : IdentityDbContext<User>
{
    public SkyNet2DbContext(DbContextOptions<SkyNet2DbContext> options) : base(options)
    {
        Database.EnsureCreated();
    }
}