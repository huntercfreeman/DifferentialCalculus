using DifferentialCalculus.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DifferentialCalculus.Shared
{
    public partial class SideMenuProblem : ComponentBase
    {
        [Inject]
        public SiteState SiteState { get; set; }
        [Parameter]
        public Problem Problem { get; set; }
        private bool IsHovered { get; set; }
        public string IsHoveredCSS 
        {
            get => IsHovered ? "background-color: lightgray;" : "background-color: white;";
        }
    }
}
