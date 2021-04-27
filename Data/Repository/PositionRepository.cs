using System.Collections.Generic;
using TestDotNet.Data.Interfaces;
using TestDotNet.Data.Models;

namespace TestDotNet.Data.Repository
{
    public class PositionRepository : IPosition
    {
        private readonly AppDBContext appDBContext;

        public PositionRepository(AppDBContext appDBContext)
        {
            this.appDBContext = appDBContext;
        }

        public IEnumerable<Position> Positions => appDBContext.Position;
    }
}