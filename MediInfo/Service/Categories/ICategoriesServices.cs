using MediInfo.Models;
using System.Linq;

namespace MediInfo.Service.Categorie
{
    public partial interface ICategorieService
    {
        void Insert(Categories Categories);
        void Delete(int Id);
        void Update(Categories Categories);
    }
}