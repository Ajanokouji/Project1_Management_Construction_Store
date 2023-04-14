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
    public class MaterialResponsitories : IMaterialResponsitories
    {
        MaterialWarehouseDbContext _dbContext;
        public MaterialResponsitories()
        {
            _dbContext = new MaterialWarehouseDbContext();
        }
        public bool AddMaterials(Material p)
        {
            _dbContext.Materials.Add(p);
            _dbContext.SaveChanges();
            return true;
        }

        public List<Material> GetMaterials()
        {
            return _dbContext.Materials.ToList();
        }

        public Material GetMaterialsById(Guid id)
        {
            return _dbContext.Materials.FirstOrDefault(c => c.IdMaterial == id);
        }

        public List<Material> GetMaterialsByName(string name)
        {
            return _dbContext.Materials.Where(c => c.Name.Contains(name)).ToList();
        }

        public bool RemoveMaterials(Guid id)
        {
            var temp = _dbContext.Materials.FirstOrDefault(c => c.IdMaterial == id);
            _dbContext.Materials.Remove(temp);
            _dbContext.SaveChanges();
            return true;
        }

        public bool UpdateMaterials(Material p)
        {
            var temp = _dbContext.Materials.FirstOrDefault(c => c.IdMaterial == p.IdMaterial);
            _dbContext.Materials.Update(temp);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
