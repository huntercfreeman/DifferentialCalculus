using DifferentialCalculus.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DifferentialCalculus.Pages
{
    public partial class Index : ComponentBase, IDisposable
    {
        [Inject]
        public SiteState SiteState { get; set; }

        protected override void OnInitialized()
        {
            base.OnInitialized();
            SiteState.CurrentProblemEventHandler += CurrentItemEventHandler;
            SiteState.CurrentSectionTitleEventHandler += CurrentItemEventHandler;
            SiteState.CurrentBookEventHandler += CurrentItemEventHandler;
        }

        private void CurrentItemEventHandler(object sender, EventArgs e)
        {
            InvokeAsync(StateHasChanged);
        }

        public void Dispose()
        {
            SiteState.CurrentProblemEventHandler -= CurrentItemEventHandler;
            SiteState.CurrentSectionTitleEventHandler -= CurrentItemEventHandler;
            SiteState.CurrentBookEventHandler -= CurrentItemEventHandler;
        }
    }
}
