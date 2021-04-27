using System.Collections.Generic;
using TestDotNet.Data.Interfaces;
using TestDotNet.Data.Models;
using System;

namespace TestDotNet.Data.Mocks
{
    public class MockPosition : IPosition
    {
        public IEnumerable<Position> Positions 
        {
            get
            {
                Random random = new Random();
                return new List<Position>
                {
                    new Position {
                        positionName = "Welder",
                        salary = 30288.89
                        },
                    new Position {
                        positionName = "Locksmith",
                        salary = 53429.82
                        }
                };
            }
        }
    }
}