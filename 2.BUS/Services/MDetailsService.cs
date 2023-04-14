using _1.DAL.IResponsitories;
using _1.DAL.Models;
using _1.DAL.Responsitories;
using _2.BUS.IServices;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public class MDetailsService : IMaterialDetailsService
    {
        IMaterialResponsitories _MaterialRepo;
        IMaterialDetailsResponsitories _MaterialDetailsRepo;
        IProducerResponsitories _ProducerRepo;
        public MDetailsService()
        {
            _MaterialDetailsRepo = new MaterialDetailsResponsitories();
            _MaterialRepo = new MaterialResponsitories();
            _ProducerRepo = new ProducerResponsitories();
        }
        public string AddMaterialDetails(MaterialDetailsView p)
        {
            if (p == null) return "Unsuccessfully";
            var m = new MaterialDetail() {
                IdMaterial = p.IdMaterial,
                IdMDetail = p.IdMDetail,
                Price = p.Price,
                Amount = p.Amount,
                IdProducer = p.IdProducer,
                ImportPrice = p.ImportPrice,
                Unit = p.Unit,
            };
            if (_MaterialDetailsRepo.AddMaterialDetails(m)) return "Successfully";
            return "Unsuccessfully";
        }

        public List<MaterialDetailsView> GetMaterialDetails()
        {
            var list = (from a in _MaterialDetailsRepo.GetMaterialDetails()
                        join b in _MaterialRepo.GetMaterials() on a.IdMaterial equals b.IdMaterial
                        join c in _ProducerRepo.GetAll() on a.IdProducer equals c.IdProducer
                        select new MaterialDetailsView()
                        {
                            IdMaterial = a.IdMaterial,
                            Amount = a.Amount,
                            Code = b.Code,
                            Status = b.Status,
                            IdMDetail = a.IdMDetail,
                            IdProducer = c.IdProducer,
                            ImportPrice = a.ImportPrice,
                            Name = b.Name,
                            NameProducer = c.Name,
                            Price = a.Price,
                            Unit = a.Unit,
                        }).ToList();
            return list;
        }

        public MaterialDetailsView GetMaterialDetailsById(Guid id)
        {
            return GetMaterialDetails().FirstOrDefault(c => c.IdMaterial == id);
        }

        public List<MaterialDetailsView> GetMaterialDetailsByName(string name)
        {
            return GetMaterialDetails().Where(c => c.Name.Contains(name) || c.Code.Contains(name)).ToList();
        }

        public List<Material> GetMaterials()
        {
            return _MaterialRepo.GetMaterials();
        }

        public List<Producer> GetProducers()
        {
            return _ProducerRepo.GetAll();
        }

        public string RemoveMaterialDetails(Guid id)
        {
            if(_MaterialDetailsRepo.RemoveMaterialDetails(id)) return "Successfully";
            return "Unsuccessfully";
        }

        public string UpdateMaterialDetails(MaterialDetailsView p)
        {
            if (p == null) return "Unsuccessfully";
            var m = _MaterialDetailsRepo.GetMaterialDetails().FirstOrDefault(c => c.IdMDetail == p.IdMDetail);
            m.IdProducer = p.IdProducer;
            m.ImportPrice = p.ImportPrice;
            m.IdMaterial = p.IdMaterial;
            m.Amount = p.Amount;
            m.Unit = p.Unit;
            m.Price = p.Price;
            
            if (_MaterialDetailsRepo.UpdateMaterialDetails(m)) return "Successfully";
            return "Unsuccessfully";
        }
    }
}
