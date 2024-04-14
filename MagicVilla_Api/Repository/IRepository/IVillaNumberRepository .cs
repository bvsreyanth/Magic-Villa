using MagicVilla_Api.Model;

namespace MagicVilla_Api.Repository.IRepository
{
    public interface IVillaNumberRepository:IRepository<VillaNumber>
    {
        Task<VillaNumber> UpdateAsync(VillaNumber entity);
    }
}
