using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using MealVote.Api.Contracts;
using MealVote.Domain;
using MealVote.Infrastructure;
using MealVoteApi;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace MealVote.Api.Services {
    public class AccountService : IAccountService {
        private readonly IAccountRepository _repository;
        private readonly AppSettings _appSettings;

        public AccountService (IOptions<AppSettings> appSettings, IAccountRepository repository) {
            _appSettings = appSettings.Value;
            _repository = repository;
        }

        public async Task CreateAccount (AccountRequest request) {
            var account = new Account {
                Id = new Guid (),
                Email = request.Email,
                Password = request.Password,
                UserName = request.UserName,
                AccountCreatedDate = DateTime.Now
            };

            await _repository.Create (account);
        }

        public Profile Authenticate (string username, string password) {

            // Need to search MongoDB to verify user exists
            //var user = _users.SingleOrDefault (x => x.Username == username && x.Password == password);

            // return null if user not found
            if (user == null)
                return null;

            // authentication successful so generate jwt token
            var tokenHandler = new JwtSecurityTokenHandler ();
            var key = Encoding.ASCII.GetBytes (_appSettings.);
            var tokenDescriptor = new SecurityTokenDescriptor {
                Subject = new ClaimsIdentity (new Claim[] {
                new Claim (ClaimTypes.Name, user.Id.ToString ())
                }),
                Expires = DateTime.UtcNow.AddDays (7),
                SigningCredentials = new SigningCredentials (new SymmetricSecurityKey (key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken (tokenDescriptor);
            user.Token = tokenHandler.WriteToken (token);

            return user.WithoutPassword ();
        }

    }
}