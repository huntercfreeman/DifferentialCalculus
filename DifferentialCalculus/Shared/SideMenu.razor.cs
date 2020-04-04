using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DifferentialCalculus.Shared
{
    public partial class SideMenu : ComponentBase
    {
        [Inject]
        public SiteState SiteState { get; set; }

        protected override void OnInitialized()
        {
            base.OnInitialized();
            SiteState.DisplaySideMenuEventHandler += SiteState_DisplaySideMenuEventHandler;
        }

        private void SiteState_DisplaySideMenuEventHandler(object sender, EventArgs e)
        {
            InvokeAsync(StateHasChanged);
        }
    }
}
