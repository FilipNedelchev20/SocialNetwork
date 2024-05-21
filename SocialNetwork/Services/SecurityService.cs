using SocialNetwork.Data;
using SocialNetwork.Models;
using SocialNetwork.ViewModels;

namespace SocialNetwork.Services
{
    public class SecurityService : ISecurityService
    {
        private ApplicationDbContext _context = null;
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
    }
}
