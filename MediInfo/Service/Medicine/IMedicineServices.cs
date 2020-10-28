using MediInfo.Models;
using System.Linq;

namespace MediInfo.Service.Medicines
{
    public partial interface IMedicineService
    {
        void Insert(Medicine Medicine);
        void Delete(int Id);
        void Update(Medicine Medicine);
    }
}