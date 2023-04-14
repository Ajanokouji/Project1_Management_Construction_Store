using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IResponsitories
{
    public interface IPositionResponsitories
    {
        public bool AddPositions(Position p);
        public bool RemovePositions(Guid id);
        public bool UpdatePositions(Position p);
        public List<Position> GetPositions();
        public Position GetPositionsById(Guid id);
        public List<Position> GetPositionsByName(string name);
    }
}
