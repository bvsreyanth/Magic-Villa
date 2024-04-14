using MagicVilla_Api.Model;

namespace MagicVilla_Api.Repository.IRepository
{
    public interface IvillaRepository:IRepository<Villa>
    {
        Task<Villa> UpdateAsync(Villa entity);
    }
}
