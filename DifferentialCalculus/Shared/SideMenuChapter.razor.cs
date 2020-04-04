using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DifferentialCalculus.Shared
{
    public partial class SideMenuChapter : ComponentBase
    {
        [Parameter]
        public string SectionTitle { get; set; }
    }
}
