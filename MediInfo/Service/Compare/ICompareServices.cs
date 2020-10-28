using MediInfo.Models;
using System.Linq;

namespace MediInfo.Service.Compares
{
    public partial interface ICompareService
    {
        void Insert(Compare Compare);
        void Delete(int Id);
        void Update(Compare Compare);
    }
}