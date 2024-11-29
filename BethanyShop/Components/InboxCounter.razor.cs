using Microsoft.AspNetCore.Components;

namespace BethanyShop.Components
{
    public partial class InboxCounter
    {
        public int MessageCount;

        [Inject]
        public ApplicationState ApplicationState { get; set; }

        protected override void OnInitialized()
        {
            MessageCount = new Random().Next(10);

            ApplicationState.NumberOfMassages = MessageCount;
        }
    }
}