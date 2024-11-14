using BethanyShop.Models;
using BethanysPieShopHRM.Shared.Domain;

namespace BethanyShop.Pages;

public partial class EmployeeOverview
{
    public List<Employee>? Employees { get; set; } = default;

    protected override void OnInitialized()
    {
        Employees = MockDataService.Employees;
    }
}