﻿using BethanysPieShopHRM.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace BethanyShop.Components;

public partial class EmployeeCard
{
    [Parameter]
    public Employee Employee { get; set; } = default!;

    [Parameter]
    public EventCallback<Employee> EmployeeQuickViewClicked { get; set; }

    [Inject]
    public NavigationManager NavigationManager { get; set; } = default!;

    protected override void OnInitialized()
    {
        if (string.IsNullOrEmpty(Employee.LastName))
        {
            throw new Exception();
        }
    }

    public void NavigateToDetails(Employee employee)
    {
        NavigationManager.NavigateTo($"/employeedetail/{employee.EmployeeId}");
    }
}