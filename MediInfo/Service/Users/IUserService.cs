using MediInfo.Models;

namespace MediInfo.Service.Users
{
    public interface IUserService
    {
        bool Insert(User User);
        void Delete(int Id);
        void Update(User User);
        bool is_valid(string email, string password);
        bool check_existing_user(string email);
    }
}