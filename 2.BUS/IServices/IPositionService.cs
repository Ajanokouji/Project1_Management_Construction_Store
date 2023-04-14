using _1.DAL.Models;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IPositionService
    {
        public string AddPositions(PositionView p);
        public string RemovePositions(Guid id);
        public string UpdatePositions(PositionView p);
        public List<PositionView> GetPositions();
        public Position GetPositionsById(Guid id);
        public List<PositionView> GetPositionsByName(string name);
    }
}
