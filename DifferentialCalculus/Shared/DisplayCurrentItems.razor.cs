using DifferentialCalculus.Interfaces;
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
        [Inject]
        public IProblemRepository ProblemRepository { get; set; }

        protected override void OnInitialized()
        {
            base.OnInitialized();
            SiteState.CurrentProblemEventHandler += CurrentItemChanged;
            SiteState.CurrentSectionTitleEventHandler += CurrentItemChanged;
            SiteState.CurrentBookEventHandler += CurrentBookChanged;
        }

        private void CurrentItemChanged(object sender, EventArgs e)
        {
            InvokeAsync(StateHasChanged);
        }

        private void CurrentBookChanged(object sender, EventArgs e)
        {
            SiteState.CurrentSectionTitle = "1.1";
            SiteState.CurrentProblem = ProblemRepository.GetProblems(SiteState.CurrentBook, SiteState.CurrentSectionTitle)[0];

        }

        public void Dispose()
        {
            SiteState.CurrentProblemEventHandler -= CurrentItemChanged;
            SiteState.CurrentSectionTitleEventHandler -= CurrentItemChanged;
            SiteState.CurrentBookEventHandler -= CurrentBookChanged;
        }
    }
}
