using _1.DAL.Models;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IMaterialDetailsService
    {
        public string AddMaterialDetails(MaterialDetailsView p);
        public string RemoveMaterialDetails(Guid id);
        public string UpdateMaterialDetails(MaterialDetailsView p);
        public List<MaterialDetailsView> GetMaterialDetails();
        public MaterialDetailsView GetMaterialDetailsById(Guid id);
        public List<MaterialDetailsView> GetMaterialDetailsByName(string name);
        public List<Producer> GetProducers();
        public List<Material> GetMaterials();
    }
}
