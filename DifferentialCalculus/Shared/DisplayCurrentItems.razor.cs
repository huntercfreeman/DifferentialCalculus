using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DifferentialCalculus.Shared
{
    public partial class DisplayCurrentItems : ComponentBase, IDisposable
    {
        [Inject]
        public SiteState SiteState { get; set; }

        protected override void OnInitialized()
        {
            base.OnInitialized();
            SiteState.CurrentProblemEventHandler += CurrentItemChanged;
            SiteState.CurrentSectionTitleEventHandler += CurrentItemChanged;
        }

        private void CurrentItemChanged(object sender, EventArgs e)
        {
            InvokeAsync(StateHasChanged);
        }

        public void Dispose()
        {
            SiteState.CurrentProblemEventHandler -= CurrentItemChanged;
            SiteState.CurrentSectionTitleEventHandler -= CurrentItemChanged;
        }
    }
}
