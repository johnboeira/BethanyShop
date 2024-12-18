﻿using BethanysPieShopHRM.Shared.Domain;

namespace BethanyShop.Services
{
    public interface IEmployeeDataService
    {
        Task<IEnumerable<Employee>> GetAllEmployees(bool refreshRequired = false);

        Task<Employee> GetEmployeeDetails(int employeeId);

        Task<Employee> AddEmployee(Employee employee);

        Task UpdateEmployee(Employee employee);

        Task DeleteEmployee(int employeeId);
    }
}