using MediInfo.Models;

namespace MediInfo.Service.Users
{
    public interface IUserService
    {
        void Insert(User User);
        void Delete(int Id);
        void Update(User User);
    }
}