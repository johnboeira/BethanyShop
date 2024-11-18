using Microsoft.AspNetCore.Components;

namespace BethanyShop.Components
{
    public partial class ProfilePicture
    {
        [Parameter]
        public RenderFragment? ChildContent { get; set; }
    }
}