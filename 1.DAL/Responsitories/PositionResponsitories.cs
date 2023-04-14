using _1.DAL.Context;
using _1.DAL.IResponsitories;
using _1.DAL.Models;
using System;
using System.Linq;
using System.Collections.Generic;
namespace _1.DAL.Responsitories
{
    public class PositionResponsitories : IPositionResponsitories
    {
        MaterialWarehouseDbContext _dbContext;
        public PositionResponsitories()
        {
            _dbContext = new MaterialWarehouseDbContext();
        }
        public bool AddPositions(Position p)
        {
            _dbContext.positions.Add(p);
            _dbContext.SaveChanges();
            return true;
        }

        public List<Position> GetPositions()
        {
            return _dbContext.positions.ToList();
        }

        public Position GetPositionsById(Guid id)
        {
            return _dbContext.positions.FirstOrDefault(c => c.IdPosition == id);
        }

        public List<Position> GetPositionsByName(string name)
        {
            return _dbContext.positions.Where(c => c.Name.Contains(name)).ToList();
        }

        public bool RemovePositions(Guid id)
        {
            var temp = _dbContext.positions.FirstOrDefault(c => c.IdPosition == id);
            _dbContext.Remove(temp);
            _dbContext.SaveChanges();
            return true;
        }

        public bool UpdatePositions(Position p)
        {
            var temp = _dbContext.positions.FirstOrDefault(c => c.IdPosition == p.IdPosition);
            _dbContext.Update(temp);
            _dbContext.SaveChanges();
            return true;
        }

    }
}
