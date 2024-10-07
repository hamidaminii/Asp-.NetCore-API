using ApiProject.Enities;
using ApiProject.DBContexts;
using Microsoft.EntityFrameworkCore;

namespace ApiProject.Repositories
{
    public class AccountInfoRepository : IAccountInfoRepository
    {
        private readonly AccountDBContexts _context;
        public AccountInfoRepository(AccountDBContexts context)
        {
            _context = context ?? throw new ArgumentException(nameof(context));
        }
        

        public async Task<IEnumerable<Account>> GetAccountsAsync()
        {
            return await _context.Accounts
                .OrderBy(c => c.Email).ToListAsync();
        }

        public async Task<Account?> GetAccountAsync(int id)
        {
            return await _context.Accounts
                .Where(c=> c.Id == id).FirstOrDefaultAsync();
        }
    }
}
