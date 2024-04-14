using MagicVilla_Api.Data;
using MagicVilla_Api.Model;
using MagicVilla_Api.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace MagicVilla_Api.Repository
{
    public class VillaRepository : Repository<Villa>,IvillaRepository
    {
         ApplicationDbContext _db;
        public VillaRepository(ApplicationDbContext db):base(db) 
        {
            _db = db;
        }
        
        public async Task<Villa> UpdateAsync(Villa entity)
        {
            entity.UpdatedDate = DateTime.Now;
            _db.Villas.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
