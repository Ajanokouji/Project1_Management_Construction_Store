using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IResponsitories
{
    public interface IMaterialResponsitories
    {
        public bool AddMaterials(Material p);
        public bool RemoveMaterials(Guid id);
        public bool UpdateMaterials(Material p);
        public List<Material> GetMaterials();
        public Material GetMaterialsById(Guid id);
        public List<Material> GetMaterialsByName(string name);
    }
}
