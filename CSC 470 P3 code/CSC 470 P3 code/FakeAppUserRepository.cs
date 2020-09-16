using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC_470_P3_code
{
    public class FakeAppUserRepository : IAppUser
    {
        private static Dictionary<string, AppUser> Users;

        public FakeAppUserRepository()
        {
            if (Users == null)
            {
                Users = new Dictionary<string, AppUser>();
                Users.Add("JaronBurtnett", new AppUser
                {
                    UserName = "JaronBurtnett",
                    Password = "BadPassword1",
                    FirstName = "Jaron",
                    LastName = "Burtnett",
                    EmailAddress = "jaron.burtnett@trojans.dsu.edu",
                    IsAuthenticated = false
                });
                Users.Add("JoeyHopkins", new AppUser
                {
                    UserName = "JoeyHopkins",
                    Password = "BadPassword2",
                    FirstName = "Joey",
                    LastName = "Hopkins",
                    EmailAddress = "joey.hopkins@trojans.dsu.edu",
                    IsAuthenticated = false
                });
                Users.Add("AndrewReese", new AppUser
                {
                    UserName = "AndrewReese",
                    Password = "BadPassword3",
                    FirstName = "Andrew",
                    LastName = "Reese",
                    EmailAddress = "andrew.reese@trojans.dsu.edu",
                    IsAuthenticated = false
                });
            }
        }

        public List<AppUser> GetAll()
        {
            List<AppUser> users = new List<AppUser>();
            foreach (KeyValuePair<string, AppUser> user in Users) users.Add(user.Value);
            return users;
        }

        public AppUser GetByUserName(string UserName)
        {
            AppUser user;
            Users.TryGetValue(UserName, out user);
            return user;
        }

        public bool Login(string UserName, string Password)
        {
            AppUser user;
            Users.TryGetValue(UserName, out user);
            if (user == null) return false;
            if (user.Password != Password) return false;
            SetAuthentication(UserName, true);
            return true;
        }

        public void SetAuthentication(string UserName, bool IsAuthenticated)
        {
            AppUser user;
            Users.TryGetValue(UserName, out user);
            user.IsAuthenticated = IsAuthenticated;
        }
    }
}
