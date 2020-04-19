using DifferentialCalculus.Interfaces;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DifferentialCalculus.Shared
{
    public partial class SideMenu : ComponentBase, IDisposable
    {
        [Inject]
        public SiteState SiteState { get; set; }
        [Inject]
        public IProblemRepository ProblemRepository { get; set; }
        protected override void OnInitialized()
        {
            base.OnInitialized();
            SiteState.DisplaySideMenuEventHandler += SiteState_DisplaySideMenuEventHandler;
        }

        private void SiteState_DisplaySideMenuEventHandler(object sender, EventArgs e)
        {
            InvokeAsync(StateHasChanged);
        }

        public void Dispose()
        {
            SiteState.DisplaySideMenuEventHandler -= SiteState_DisplaySideMenuEventHandler;
        }
    }
}
