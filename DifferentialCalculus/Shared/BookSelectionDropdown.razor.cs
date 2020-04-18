using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DifferentialCalculus.Shared
{
    public partial class BookSelectionDropdown : ComponentBase, IDisposable
    {
        [Inject]
        public SiteState SiteState { get; set; }

        protected override void OnInitialized()
        {
            base.OnInitialized();
            SiteState.DisplayBookMenuEventHandler += SiteState_DisplayBookMenuEventHandler;
        }

        private void SiteState_DisplayBookMenuEventHandler(object sender, EventArgs e)
        {
            InvokeAsync(StateHasChanged);
        }

        public void Dispose()
        {
            SiteState.DisplayBookMenuEventHandler -= SiteState_DisplayBookMenuEventHandler;
        }
    }
}
