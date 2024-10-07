using ApiProject.Enities;
using Microsoft.EntityFrameworkCore;

namespace ApiProject.DBContexts
{
    public class AccountDBContexts : DbContext
    {
        public AccountDBContexts
            (DbContextOptions<AccountDBContexts> options)
            : base(options)
        {

        }
        public DbSet<Account> Accounts { get; set; } = null!;


        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer();
        //    base.OnConfiguring(optionsBuilder);
        //}

    }
}
