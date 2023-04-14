using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IResponsitories
{
    public interface IMaterialDetailsResponsitories
    {
        public bool AddMaterialDetails(MaterialDetail p);
        public bool RemoveMaterialDetails(Guid id);
        public bool UpdateMaterialDetails(MaterialDetail p);
        public List<MaterialDetail> GetMaterialDetails();
        public MaterialDetail GetMaterialDetailsById(Guid id);
        public List<MaterialDetail> GetMaterialDetailsByName(string name);
    }
}
