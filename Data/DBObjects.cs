using System;
using System.Collections.Generic;
using System.Linq;
using TestDotNet.Data.Models;

namespace TestDotNet.Data
{
    public class DBObjects
    {
        private static Dictionary<string, Position> positions;
        private static Dictionary<string, Employee> employees;

        public static void Initial(AppDBContext context)
        {
            if(!context.Position.Any())
            {
                context.Position.AddRange(GetPositions.Select(p => p.Value));
            }

            if(!context.Employee.Any())
            {
                 context.Employee.AddRange(GetEmployees.Select(e => e.Value));
            }

            if(!context.BusinessTrip.Any())
            {
                context.AddRange(
                    new BusinessTrip
                    {
                        city = "Москва",
                        departureDate = DateTime.Today,
                        arrivalDate = DateTime.Today.Add(new TimeSpan(12, 0, 0, 0)),
                        Employee = GetEmployees["Соловьёв"]
                    },
                    new BusinessTrip
                    {
                        city = "Казань",
                        departureDate = DateTime.Today,
                        arrivalDate = DateTime.Today.Add(new TimeSpan(18, 0, 0, 0)),
                        Employee = GetEmployees["Соловьёв"]
                    },
                    new BusinessTrip
                    {
                        city = "Екатеринбург",
                        departureDate = DateTime.Today,
                        arrivalDate = DateTime.Today.Add(new TimeSpan(14, 0, 0, 0)),
                        Employee = GetEmployees["Зыков"]
                    },
                    new BusinessTrip
                    {
                        city = "Новосибирск",
                        departureDate = DateTime.Today,
                        arrivalDate = DateTime.Today.Add(new TimeSpan(63, 0, 0, 0)),
                        Employee = GetEmployees["Зыков"]
                    },
                    new BusinessTrip
                    {
                        city = "Анапа",
                        departureDate = DateTime.Today,
                        arrivalDate = DateTime.Today.Add(new TimeSpan(25, 0, 0, 0)),
                        Employee = GetEmployees["Соловьёв"]
                    },
                    new BusinessTrip
                    {
                        city = "Уфа",
                        departureDate = DateTime.Today,
                        arrivalDate = DateTime.Today.Add(new TimeSpan(2, 0, 0, 0)),
                        Employee = GetEmployees["Зыков"]
                    }
                );
            }

            context.SaveChanges();
        }

        public static Dictionary<string, Position>  GetPositions
        {
            get
            {
                if (positions == null)
                {
                    var list = new Position[]
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

                    positions = new Dictionary<string, Position>();
                    foreach (var position in list)
                    {
                        positions.Add(position.positionName, position);
                    }
                }

                return positions;
            }
        }

        public static Dictionary<string, Employee>  GetEmployees
        {
            get
            {
                if (employees == null)
                {
                    var list = new Employee[]
                    {
                        new Employee
                        {
                            id = "1",
                            firstName = "Даниил",
                            lastName = "Соловьёв",
                            middleName = "Эльдарович",
                            Position = GetPositions["Welder"]
                        },
                        new Employee
                        {
                            id = "2",
                            firstName = "Вадим",
                            lastName = "Зыков",
                            middleName = "Русланович",
                            Position = GetPositions["Locksmith"]
                        }
                    };

                    employees = new Dictionary<string, Employee>();
                    foreach (var employee in list)
                    {
                        employees.Add(employee.lastName, employee);
                    }
                }

                return employees;
            }
        }
    }
}