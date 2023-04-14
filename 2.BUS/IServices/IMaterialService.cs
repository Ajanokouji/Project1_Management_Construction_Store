using _1.DAL.Models;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IMaterialService
    {
        public string AddMaterials(Material p);
        public string RemoveMaterials(Guid id);
        public string UpdateMaterials(Material p);
        public List<Material> GetMaterials();
        public Material GetMaterialsById(Guid id);
        public List<Material> GetMaterialsByName(string name);
    }
}
