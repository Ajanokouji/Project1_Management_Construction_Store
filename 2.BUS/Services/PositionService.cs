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
    public class PositionService : IPositionService
    {
        IPositionResponsitories _PositionRepo;
        public PositionService()
        {
            _PositionRepo = new PositionResponsitories();
        }
        public string AddPositions(PositionView p)
        {
            if (p == null) return "Unsuccessly";
            var po = new Position()
            {
                IdPosition = p.IdPosition,
                Code = p.Code,
                Status = p.Status,
                Name = p.Name,
            };
            if(_PositionRepo.AddPositions(po)) return "Successfully";
            return "Unsuccessly";
        }

        public List<PositionView> GetPositions()
        {
            var list = (from a in _PositionRepo.GetPositions()
                        select new PositionView()
                        {
                            Code = a.Code,
                            Status = a.Status,
                            IdPosition = a.IdPosition,
                            Name = a.Name,
                        }).ToList();
            return list;
        }

        public Position GetPositionsById(Guid id)
        {
            return _PositionRepo.GetPositionsById(id);
        }

        public List<PositionView> GetPositionsByName(string name)
        {
            return GetPositions().Where(c => c.Name.Contains(name) || c.Code.Contains(name)).ToList();
        }

        public string RemovePositions(Guid id)
        {
            if (_PositionRepo.RemovePositions(id)) return "Successfully";
            return "Unsuccessfully";
        }

        public string UpdatePositions(PositionView p)
        {
            if(p == null) return "Unsuccessfully";
            var po = _PositionRepo.GetPositions().FirstOrDefault(c => c.IdPosition == p.IdPosition);
            po.IdPosition = p.IdPosition;
            po.Name = p.Name;
            po.Status = p.Status;
            po.Code = p.Code;
            if (_PositionRepo.UpdatePositions(po)) return "Successfully";
            return "Unsuccessfully";
        }
    }
}
