using MediInfo.Models;
using System.Linq;

namespace MediInfo.Service.Types
{
    public partial interface ITypeService
    {
        void Insert(Type Type);
        void Delete(int Id);
        void Update(Type Type);
        IQueryable<Type> GetAllTypes();
    }
}