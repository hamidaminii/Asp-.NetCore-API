using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ApiProject.Models;
using ApiProject.Repositories;

namespace ApiProject.Controllers
{
    [Route("api/account")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountInfoRepository _accountInfoRepository;

        public AccountController(IAccountInfoRepository accountInfoRepository)
        {
            _accountInfoRepository = accountInfoRepository ?? 
                throw new ArgumentNullException(nameof(accountInfoRepository));
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Account>>> GetAccounts()
        {
            var Accounts = await _accountInfoRepository.GetAccountsAsync();

            var resault = new List<Account>();

            foreach (var account in Accounts)
            {
                resault.Add(new Account()
                {
                    Id = account.Id,
                    Name = account.Name,
                    Family = account.Family,
                    Email = account.Email,
                    Password = account.Password,
                    Phone = account.Phone,
                });
            }

            return Ok(resault);
        }

        //[HttpPost]
        //public ActionResult<Account> CreateAccount(
        //    int id, Account anaccount
        //    )
        //{

        //    return null;
        //}
        
    }
}
