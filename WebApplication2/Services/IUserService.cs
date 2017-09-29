using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Services
{
    public interface IUserService
    {
        Task<bool> ValidateCredentials(string username, string password, out User user);
        Task<bool> AddUser(string username, string password);
    }

    public class User
    {
        public User(string username)
        {
            UserName = username;
        }

        public string UserName { get; set; }
    }
}
