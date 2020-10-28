using MediInfo.Models;

namespace MediInfo.Service.Types
{
    public partial interface ITypeService
    {
        void Insert(Type Type);
        void Delete(int Id);
        void Update(Type Type);
    }
}