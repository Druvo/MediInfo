using MediInfo.Models;
using System.Linq;

namespace MediInfo.Service.Consumers
{
    public partial interface IConsumerService
    {
        void Insert(Consumer Consumer);
        void Delete(int Id);
        void Update(Consumer Consumer);
    }
}