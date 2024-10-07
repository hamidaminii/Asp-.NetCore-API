using ApiProject.Enities;

namespace ApiProject.Repositories
{
    public interface IAccountInfoRepository
    {
        Task<IEnumerable<Account>> GetAccountsAsync();
        Task<Account?> GetAccountAsync(int id);
    }
}
