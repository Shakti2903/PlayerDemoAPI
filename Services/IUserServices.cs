using PlayerData.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerServices
{
    public interface IUserServices
    {
        public int AddUser(AddPlayer userser);
        public List<UserInfo> Login(LoginVM login);
        public int Changepassword(LoginVM login);
        public UserInfo GetAllPlayer();
    }
}
