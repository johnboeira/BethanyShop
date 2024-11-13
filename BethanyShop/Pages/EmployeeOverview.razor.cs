using BethanyShop.Models;
using BethanysPieShopHRM.Shared.Domain;

namespace BethanyShop.Pages;

public partial class EmployeeOverview
{
    public List<Employee>? employees { get; set; } = default;

    protected override void OnInitialized()
    {
        employees = MockDataService.Employees;
    }
}