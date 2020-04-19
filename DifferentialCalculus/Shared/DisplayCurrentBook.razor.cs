using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DifferentialCalculus.Shared
{
    public partial class DisplayCurrentBook : ComponentBase, IDisposable
    {
        [Inject]
        public SiteState SiteState { get; set; }

        protected override void OnInitialized()
        {
            base.OnInitialized();
            SiteState.CurrentBookEventHandler += SiteState_CurrentBookEventHandler;
        }

        private void SiteState_CurrentBookEventHandler(object sender, EventArgs e)
        {
            InvokeAsync(StateHasChanged);
        }
        public void Dispose()
        {
            SiteState.CurrentBookEventHandler -= SiteState_CurrentBookEventHandler;
        }
    }
}
