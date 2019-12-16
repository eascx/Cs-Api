using DatabaseContext;
using Model;
using System.Text.RegularExpressions;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Services
{

    class UserService
    {
        UserContext _userContext;

        public UserService(UserContext userContext)
        {
            _userContext = userContext;
        }
        public async Task< bool> IsExistUsername(User user) {
            var ex= await _userContext.users.FirstOrDefaultAsync(u => u.username == user.username);
            return ex != null;
        }
        public async Task<User> AddUser(User user) {
            var added= await _userContext.users.AddAsync(user);
            if (added.State == EntityState.Unchanged) {
                return null;
            }
            return added.Entity;
        }
        public async Task<User> getUserByUsernameAndPassword(User user) {
            var ex = await _userContext.users.FirstOrDefaultAsync(u => u.username == user.username&&u.password==user.password);
            return ex;
        }
        public async Task<User> BanUser(User user) { 
            
        }
        public static bool IsFieldUsernameIllegal(User user) {
            string reg = @"\A[a-zA-Z]\w{5,19}\Z";
            return user.username == null || Regex.IsMatch(user.username,reg);
        }
        public static bool IsFieldPasswordIllegal(User user) {
            string reg = @"\A[\w@#$%&*.]{8,16}\Z";
            return user.password == null || Regex.IsMatch(user.password, reg);
        }
        public static bool IsFieldEmailIllegal(User user)
        {
            string reg = @"\A\w+@\w+.\w+\Z";
            return user.email == null || Regex.IsMatch(user.email, reg);
        }
        public static bool IsFieldNameIllegal(User user)
        {
            return user.name == null || user.name.Length>0;
        }
        public static bool IsFieldUserPramIllegal(User user)
        {
            return user.userPram==0;
        }

    }
}
