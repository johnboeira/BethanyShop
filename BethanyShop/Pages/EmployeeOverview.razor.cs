using BethanyShop.Models;
using BethanyShop.Services;
using BethanysPieShopHRM.Shared.Domain;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace BethanyShop.Pages;

public partial class EmployeeOverview
{
    [Inject]
    public HttpClient httpClient { get; set; }

    [Inject]
    public IEmployeeDataService? EmployeeDataService { get; set; }

    public List<Employee>? Employees { get; set; } = default;
    private Employee? _selectedEmployee;
    private string title = "Employee Overview";

    //protected override async Task OnInitializedAsync()
    //{
    //    Employees = (await EmployeeDataService.GetAllEmployees(false)).ToList();
    //}

    protected override async Task OnInitializedAsync()
    {
        Employees = await httpClient.GetFromJsonAsync<List<Employee>>("https://localhost:7039/api/Employee");
    }

    public void ShowQuickViewPopup(Employee selectedEmployee)
    {
        _selectedEmployee = selectedEmployee;
    }
}