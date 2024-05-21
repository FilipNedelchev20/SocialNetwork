using SocialNetwork.Data;
using SocialNetwork.Models;
using SocialNetwork.ViewModels;

namespace SocialNetwork.Services
{
    public class SecurityService : ISecurityService
    {
        private ApplicationDbContext _context;
        public SecurityService()
        {
           _context = new ApplicationDbContext();
        }
        public void SaveUserToDB(RegisterViewModel model)
        {
            UserDetail userDetail = new UserDetail();
            userDetail.FirstName = model.FirstName;
            userDetail.LastName = model.LastName;
            userDetail.Email = model.Email;
            userDetail.Password = model.Password;

            _context.UserDetails.Add(userDetail);
            _context.SaveChanges();
        }
        public bool IsValidUser(LogonVIewModel model) 
        {
            UserDetail user = new UserDetail();
            user = _context.UserDetails.SingleOrDefault(c => c.Email.Equals(model.Username) && c.Password.Equals(model.Password));
            if (user == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
