using DifferentialCalculus.Interfaces;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DifferentialCalculus.Shared
{
    public partial class SideMenuChapter : ComponentBase
    {
        [Inject]
        public IProblemRepository ProblemRepository { get; set; }
        [Parameter]
        public string SectionTitle { get; set; }
        private bool IsCollapsed { get; set; } = true;
    }
}
