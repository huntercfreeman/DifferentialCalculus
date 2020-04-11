using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DifferentialCalculus.Shared
{
    public partial class PreviousQuestion : ComponentBase
    {
        [Inject]
        public SiteState SiteState { get; set; }
    }
}
