using BethanysPieShopHRM.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace BethanyShop.Components;

public partial class EmployeeCard
{
    [Parameter]
    public Employee Employee { get; set; } = default!;
}