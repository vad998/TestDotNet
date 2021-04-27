using System.Collections.Generic;
using TestDotNet.Data.Models;

namespace TestDotNet.Data.Interfaces
{
    public interface IPosition
    {
        IEnumerable<Position> Positions { get; }
    }
}