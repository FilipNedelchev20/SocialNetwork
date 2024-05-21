using SocialNetwork.ViewModels;

namespace SocialNetwork.Services
{
    public interface ISecurityService
    {
        void SaveUserToDB(RegisterViewModel model);
    }
}
