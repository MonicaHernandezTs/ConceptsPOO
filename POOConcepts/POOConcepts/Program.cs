﻿
using ConceptsPOO;

Console.WriteLine("ConceptsPOO");
Console.WriteLine("============");

Employee employee1 = new SalaryEmployee()
{
    Id = 1010,
    FirstName = "Monica",
    LastName = "Hernandez",
    BirtDate = new Date(1990, 5, 23),
    HiringDate = new Date(2022, 1, 15),
    IsActive = true,
    Salary = 1845453.45M
};
Console.WriteLine(employee1);

Employee employee2 = new CommissionEmployee()
{
    Id = 2020,
    FirstName = "Camilo",
    LastName = "Guevara",
    BirtDate = new Date(1990, 5, 22),
    HiringDate = new Date(2022, 1, 15),
    IsActive = true,
    Sales = 320000000M,
    CommissionPercentaje = 0.03F
};
Console.WriteLine(employee2);


