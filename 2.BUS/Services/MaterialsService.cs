using _1.DAL.IResponsitories;
using _1.DAL.Models;
using _1.DAL.Responsitories;
using _2.BUS.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public class MaterialsService : IMaterialService
    {
        IMaterialResponsitories _materialRepo;
        public MaterialsService()
        {
            _materialRepo = new MaterialResponsitories();
        }
        public string AddMaterials(Material p)
        {
            if(p == null) return "Unsuccessfully";
            if (_materialRepo.AddMaterials(p)) return "successfully";
            return "Unsuccessfully";
        }

        public List<Material> GetMaterials()
        {
            return _materialRepo.GetMaterials().ToList();
        }

        public Material GetMaterialsById(Guid id)
        {
            return _materialRepo.GetMaterials().FirstOrDefault(c => c.IdMaterial == id);
        }

        public List<Material> GetMaterialsByName(string name)
        {
            return _materialRepo.GetMaterials().Where(c => c.Name.Contains(name) || c.Code.Contains(name)).ToList();
        }

        public string RemoveMaterials(Guid id)
        {
            if(_materialRepo.RemoveMaterials(id)) return "Successfully";
            return "Unsuccessfully";
        }

        public string UpdateMaterials(Material p)
        {
            if(p == null) return "Unsuccessfully";
            var temp = _materialRepo.GetMaterials().FirstOrDefault(c => c.IdMaterial == p.IdMaterial);
            //temp.Code = p.Code;
            temp.Name = p.Name;
            temp.Status = p.Status;
            if (_materialRepo.UpdateMaterials(temp)) return "Successfully";
            return "Unsuccessfully";
        }
    }
}
