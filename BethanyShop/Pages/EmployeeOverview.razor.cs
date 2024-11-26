using BethanyShop.Models;
using BethanyShop.Services;
using BethanysPieShopHRM.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace BethanyShop.Pages;

public partial class EmployeeOverview
{
    [Inject]
    public IEmployeeDataService? EmployeeDataService { get; set; }

    public List<Employee>? Employees { get; set; } = default;
    private Employee? _selectedEmployee;
    private string title = "Employee Overview";

    protected override async Task OnInitializedAsync()
    {
        Employees = (await EmployeeDataService!.GetAllEmployees()).ToList();
    }

    public void ShowQuickViewPopup(Employee selectedEmployee)
    {
        _selectedEmployee = selectedEmployee;
    }
}