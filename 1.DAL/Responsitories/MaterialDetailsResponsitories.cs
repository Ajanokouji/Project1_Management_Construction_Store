using _1.DAL.Context;
using _1.DAL.IResponsitories;
using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Responsitories
{
    public class MaterialDetailsResponsitories : IMaterialDetailsResponsitories
    {
        MaterialWarehouseDbContext _dbContext;
        public MaterialDetailsResponsitories()
        {
            _dbContext = new MaterialWarehouseDbContext();
        }
        public bool AddMaterialDetails(MaterialDetail p)
        {
            _dbContext.MaterialDetails.Add(p);
            _dbContext.SaveChanges();
            return true;
        }

        public List<MaterialDetail> GetMaterialDetails()
        {
            return _dbContext.MaterialDetails.ToList();
        }

        public List<MaterialDetail> GetMaterialDetailsByName(string name)
        {
            throw new NotImplementedException();
        }

        public MaterialDetail GetMaterialDetailsById(Guid id)
        {
            return _dbContext.MaterialDetails.FirstOrDefault(c => c.IdMDetail == id);
        }

        public bool RemoveMaterialDetails(Guid id)
        {
            var temp = _dbContext.MaterialDetails.FirstOrDefault(c => c.IdMDetail == id);
            _dbContext.MaterialDetails.Remove(temp);
            _dbContext.SaveChanges();
            return true;
        }

        public bool UpdateMaterialDetails(MaterialDetail p)
        {
            var temp = _dbContext.MaterialDetails.FirstOrDefault(c => c.IdMDetail == p.IdMDetail);
            _dbContext.MaterialDetails.Update(temp);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
