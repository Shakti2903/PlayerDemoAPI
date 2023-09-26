using PlayerData.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
namespace PlayerServices
{
    public class UserServices : IUserServices
    {
        public readonly TeamplayerContext _teamplayerContext;

        public UserServices(TeamplayerContext teamplayerContext)
        {
            _teamplayerContext = teamplayerContext;
        }

        public UserInfo Login(LoginVM login)
        {
            try
            {
                UserInfo user = new UserInfo();

                user = _teamplayerContext.UserInfos.Where(x => x.Email == login.Email && x.Password == login.Password).FirstOrDefault();

                return user;

                if (user != null) {
                    return user; 
                }
                else
                {
                    return user = null;
                }

                //if (user != null)
                //{
                //    if (user.roleId == 1)
                //    {
                //        //UserInfo user1 = new List<UserInfo>();
                //        return _teamplayerContext.UserInfos.ToList();
                //        //return user1;
                //    }
                //} else
               
            }
            catch (Exception)
            {

                throw;
            }
            

        }

        public int Changepassword(LoginVM login)
        {
            try
            {
                UserInfo user = new UserInfo();
                user = _teamplayerContext.UserInfos.Where(x => x.Email == login.Email).FirstOrDefault();
                if (user == null)
                {
                    // Email not exist
                    return 3;

                }
                else
                {

                    user.Password = login.Password;
                    _teamplayerContext.UserInfos.Update(user);
                    _teamplayerContext.SaveChanges();
                    string bodyMessage = "Your new password is :" + user.Password;
                     var isMail = MailClass.SendMail(user.Email,"Change Password",bodyMessage);
                    if(isMail)
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
           
        }

        public int AddUser(AddPlayer userser)
        {
            try
            {
                var resCout = _teamplayerContext.UserInfos.Select(x => x.id).ToList();
                if (resCout.Count > 15)
                {
                    return 3;
                }
                var checkEmail = _teamplayerContext.UserInfos.Where(x => x.Email == userser.Email).FirstOrDefault();
                if (checkEmail != null)
                {
                    return 4;
                }
                var user = new UserInfo();
                user.Firstname = userser.Firstname;
                user.Lastname = userser.Lastname;
                user.Email = userser.Email;
                user.roleId = userser.roleId;
                user.Height = userser.Height;
                user.Weight = userser.Weight;
                user.TotalmatchPlayed = userser.TotalmatchPlayed;
                user.Contactno = userser.Contactno;
                user.Password = "team1234";

                _teamplayerContext.UserInfos.Add(user);
                int res = _teamplayerContext.SaveChanges();
                if (res == 1) { return 1; }
                else { return 2; }


            }
            catch (Exception)
            {

                throw;
            }
              
        }

        public List<UserInfo> GetAllPlayer()
        {
            try
            {
                var user = new List<UserInfo>();
                user = _teamplayerContext.UserInfos.ToList();
                return user;
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}
